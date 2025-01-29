import 'package:shared_preferences/shared_preferences.dart';

class SecureStorageHandler {
  static late SharedPreferences _storage;

  static Future<void> init() async {
    _storage = await SharedPreferences.getInstance();
  }

  static set token(String token) => _storage.setString('auth_token', token);

  static String get token => _storage.getString('auth_token') ?? '';

  Future<void> deleteToken() async {
    await _storage.remove('auth_token');
  }
}
