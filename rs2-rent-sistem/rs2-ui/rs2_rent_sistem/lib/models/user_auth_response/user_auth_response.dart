import 'package:freezed_annotation/freezed_annotation.dart';

part 'user_auth_response.freezed.dart';
part 'user_auth_response.g.dart';

@Freezed()
class UserAuthResponse with _$UserAuthResponse {
  const factory UserAuthResponse({
    @Default('') String token,
    @Default('') String role,
  }) = _UserAuthResponse;
  factory UserAuthResponse.fromJson(Map<String, dynamic> json) => _$UserAuthResponseFromJson(json);
}
