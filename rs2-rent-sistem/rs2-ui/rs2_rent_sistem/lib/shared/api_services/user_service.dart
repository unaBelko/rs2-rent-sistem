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

// Future<ApiResponse> register() {

// }
}

class LoginData {
  final String password;
  final String email;

  LoginData({required this.password, required this.email});
}
