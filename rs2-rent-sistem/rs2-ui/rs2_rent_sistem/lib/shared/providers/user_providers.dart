import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/shared/utilities/secure_storage_handler.dart';
import 'package:rs2_rent_sistem/shared/api_services/user_service.dart';

final authTokenProvider = FutureProvider<String?>((ref) async {
  return await SecureStorageHandler().getToken();
});

final userServiceProvider = Provider<UserService>((ref) {
  return UserService();
});

final loginProvider = FutureProvider.family<bool, LoginData>((ref, loginData) async {
  final userService = ref.watch(userServiceProvider);

  final response = await userService.logIn(loginData);

  if (response.isSuccess && response.data != null) {
    await SecureStorageHandler().saveToken(response.data!);
    return true;
  } else {
    return false;
  }
});
