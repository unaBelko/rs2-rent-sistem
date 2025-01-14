import 'package:freezed_annotation/freezed_annotation.dart';

part 'registration_data.freezed.dart';
part 'registration_data.g.dart';

@Freezed()
class RegistrationData with _$RegistrationData {
  const factory RegistrationData({
    @Default('') String firstName,
    @Default('') String lastName,
    @Default('') String email,
    @Default('') String phone,
    @Default('') String password,
    @Default('') String platformType,
  }) = _RegistrationData;

  factory RegistrationData.fromJson(Map<String, dynamic> json) => _$RegistrationDataFromJson(json);
}
