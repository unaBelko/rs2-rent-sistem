import 'package:rs2_rent_sistem/models/registration_data/registration_data.dart';
import 'package:rs2_rent_sistem/models/user/user.dart';
import 'package:rs2_rent_sistem/models/user_auth_response.dart';
import 'package:rs2_rent_sistem/shared/api_services/dio_service.dart';
import 'package:rs2_rent_sistem/shared/constants.dart';

class UserService {
  var dioService = DioService();

  Future<ApiResponse<UserAuthResponse>> logIn(LoginData data) async {
    var response = dioService.post(Endpoints.login,
        data: {
          'email': data.email,
          'password': data.password,
        },
        fromJson: UserAuthResponse.fromJson);
    return response;
  }

  Future<ApiResponse<List<User>>> getUsersList() async {
    final response = await dioService.get(Endpoints.user);

    if (response.isSuccess && response.response?.data != null) {
      final resultData = response.response?.data['result'] as List<dynamic>;

      final usersList = resultData.map((item) => User.fromJson(item)).toList();

      return ApiResponse<List<User>>(
        response: response.response,
        httpStatus: response.httpStatus,
        httpMessage: response.httpMessage,
        data: usersList,
      );
    } else {
      return ApiResponse<List<User>>(
        response: response.response,
        httpStatus: response.httpStatus,
        httpMessage: response.httpMessage,
        exception: response.exception,
      );
    }
  }

  Future<ApiResponse<User>> getUserDetails(int id) async {
    final response = await dioService.get<User>('${Endpoints.user}/$id', fromJson: User.fromJson);
    return response;
  }

  Future<ApiResponse<User>> register(RegistrationData user) {
    return dioService.post(
      Endpoints.user,
      data: user.toJson(),
      fromJson: User.fromJson,
    );
  }
}

class LoginData {
  final String password;
  final String email;

  LoginData({required this.password, required this.email});
}
