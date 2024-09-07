import 'package:rs2_rent_sistem/shared/api_services/dio_service.dart';
import 'package:rs2_rent_sistem/shared/constants.dart';

class UserService {
  var dioService = DioService();

  Future<ApiResponse<String>> logIn(LoginData data) async {
    return dioService.post(Endpoints.login, data: {
      'email': data.email,
      'password': data.password,
    });
  }

// Future<ApiResponse> register() {

// }
}

class LoginData {
  final String password;
  final String email;

  LoginData({required this.password, required this.email});
}
