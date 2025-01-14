// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'registration_data.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$RegistrationDataImpl _$$RegistrationDataImplFromJson(
        Map<String, dynamic> json) =>
    _$RegistrationDataImpl(
      firstName: json['firstName'] as String? ?? '',
      lastName: json['lastName'] as String? ?? '',
      email: json['email'] as String? ?? '',
      phone: json['phone'] as String? ?? '',
      password: json['password'] as String? ?? '',
      platformType: json['platformType'] as String? ?? '',
    );

Map<String, dynamic> _$$RegistrationDataImplToJson(
        _$RegistrationDataImpl instance) =>
    <String, dynamic>{
      'firstName': instance.firstName,
      'lastName': instance.lastName,
      'email': instance.email,
      'phone': instance.phone,
      'password': instance.password,
      'platformType': instance.platformType,
    };
