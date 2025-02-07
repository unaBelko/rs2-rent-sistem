import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/models/registration_data/registration_data.dart';
import 'package:rs2_rent_sistem/models/user/user.dart';
import 'package:rs2_rent_sistem/shared/api_services/user_service.dart';
import 'package:rs2_rent_sistem/shared/utilities/secure_storage_handler.dart';

final authTokenProvider = StateProvider<String?>((ref) => SecureStorageHandler.token);

final userServiceProvider = Provider<UserService>((ref) {
  return UserService();
});

final loginProvider =
    FutureProvider.family<bool, LoginData>((ref, loginData) async {
  final userService = ref.watch(userServiceProvider);

  final response = await userService.logIn(loginData);

  if (response.isSuccess && response.data != null) {
    // await SecureStorageHandler().saveToken(response.data!);
    return true;
  } else {
    return false;
  }
});

final usersListProvider = FutureProvider<List<User>>((ref) async {
  final response = await UserService().getUsersList();
  if (response.isSuccess && response.data != null) {
    return response.data!;
  } else {
    throw Exception(response.error);
  }
});

final userDetailsProvider = FutureProvider.family<User, int?>((ref, id) async {
  final response = await UserService().getUserDetails(id);
  if (response.isSuccess && response.data != null) {
    return response.data!;
  } else {
    throw Exception(response.error);
  }
});

final registrationProvider = FutureProvider.family<bool, RegistrationData>(
    (ref, registrationData) async {
  final userService = ref.watch(userServiceProvider);

  final response = await userService.register(registrationData);

  if (response.isSuccess && response.data != null) {
    // Optionally save token or handle registration success
    return true;
  } else {
    throw Exception(response.error); // Handle registration failure
  }
});
