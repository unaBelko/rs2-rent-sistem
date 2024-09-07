import 'package:dio/dio.dart';
import 'package:rs2_rent_sistem/shared/constants.dart';
import 'package:rs2_rent_sistem/shared/utilities/secure_storage_handler.dart';

class ApiResponse<T> {
  const ApiResponse({
    this.response,
    this.httpStatus = 0,
    this.httpMessage = "",
    this.data,
    this.exception,
  });

  final Response<dynamic>? response;
  final int httpStatus;
  final String httpMessage;
  final T? data;
  final Exception? exception;

  bool get isError => exception != null || httpStatus >= 400;

  bool get isSuccess => httpStatus >= 200 && httpStatus < 300;

  bool get hasData => data != null;

  bool get hasNoData => !hasData;

  String get error => exception?.toString() ?? ((httpMessage.isNotEmpty) ? httpMessage : "Unknown error");

  StackTrace? get stackTrace {
    try {
      return (exception as dynamic).stackTrace;
    } catch (_) {
      return null;
    }
  }

  @override
  String toString() {
    return isError ? error : super.toString();
  }

  bool get hasValidationErrors {
    try {
      return response?.data['validationErrors'].isNotEmpty ?? false;
    } catch (_) {
      return false;
    }
  }

  ApiResponse<T> fromJson<T>(T Function(Map<String, dynamic>) jsonParser) {
    if (isSuccess && response?.data is Map<String, dynamic>) {
      return ApiResponse<T>(
        response: response,
        httpStatus: httpStatus,
        httpMessage: httpMessage,
        data: jsonParser(response?.data as Map<String, dynamic>),
      );
    }
    return this as ApiResponse<T>;
  }
}

class DioService {
  late Dio _dio;

  DioService() {
    _dio = Dio(BaseOptions(
      baseUrl: Constants.apiUrl,
    ));

    _dio.interceptors.add(InterceptorsWrapper(
      onRequest: (options, handler) async {
        if (!_shouldSkipToken(options.path)) {
          String token = await _getToken();
          if (token.isNotEmpty) {
            options.headers['Authorization'] = 'Bearer $token';
          }
        }
        return handler.next(options);
      },
      onError: (DioException error, handler) {
        return handler.next(error);
      },
      onResponse: (response, handler) {
        return handler.next(response);
      },
    ));
  }

  Dio get dio => _dio;

  bool _shouldSkipToken(String path) {
    return path.contains('Login') || path.contains('register');
  }

  Future<String> _getToken() async {
    var token = await SecureStorageHandler().getToken() ?? '';
    return token;
  }

  Future<ApiResponse<T>> _handleRequest<T>(Future<Response<dynamic>> Function() request) async {
    try {
      final response = await request();
      return ApiResponse<T>(
        response: response,
        httpStatus: response.statusCode ?? 0,
        httpMessage: response.statusMessage ?? '',
        data: response.data is T ? response.data as T : null,
      );
    } on DioException catch (e) {
      return ApiResponse<T>(
        response: e.response,
        httpStatus: e.response?.statusCode ?? 0,
        httpMessage: e.response?.statusMessage ?? e.message ?? '',
        exception: e,
      );
    } catch (e) {
      return ApiResponse<T>(
        httpStatus: 0,
        httpMessage: 'Unknown error',
        exception: e is Exception ? e : Exception(e.toString()),
      );
    }
  }

  Future<ApiResponse<T>> get<T>(String path, {Map<String, dynamic>? queryParameters, T Function(Map<String, dynamic>)? fromJson}) async {
    final response = await _handleRequest<T>(() => _dio.get(path, queryParameters: queryParameters));
    if (fromJson != null && response.isSuccess) {
      return response.fromJson(fromJson);
    }
    return response;
  }

  Future<ApiResponse<T>> post<T>(String path, {dynamic data, Map<String, dynamic>? queryParameters, T Function(Map<String, dynamic>)? fromJson}) async {
    final response = await _handleRequest<T>(() => _dio.post(path, data: data, queryParameters: queryParameters));
    if (fromJson != null && response.isSuccess) {
      return response.fromJson(fromJson);
    }
    return response;
  }

  Future<ApiResponse<T>> put<T>(String path, {dynamic data, Map<String, dynamic>? queryParameters, T Function(Map<String, dynamic>)? fromJson}) async {
    final response = await _handleRequest<T>(() => _dio.put(path, data: data, queryParameters: queryParameters));
    if (fromJson != null && response.isSuccess) {
      return response.fromJson(fromJson);
    }
    return response;
  }

  Future<ApiResponse<T>> delete<T>(String path, {dynamic data, Map<String, dynamic>? queryParameters, T Function(Map<String, dynamic>)? fromJson}) async {
    final response = await _handleRequest<T>(() => _dio.delete(path, data: data, queryParameters: queryParameters));
    if (fromJson != null && response.isSuccess) {
      return response.fromJson(fromJson);
    }
    return response;
  }
}
