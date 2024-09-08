import 'package:dio/dio.dart';

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

  bool get isFieldsResponse {
    if (response?.data is Map<String, dynamic>) {
      return (response!.data as Map).containsKey('fields');
    } else {
      return false;
    }
  }

  bool get hasValidationErrors {
    try {
      return response?.data['validationErrors'].isNotEmpty ?? false;
    } catch (_) {
      return false;
    }
  }
}
