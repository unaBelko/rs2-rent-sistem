// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'registration_data.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

RegistrationData _$RegistrationDataFromJson(Map<String, dynamic> json) {
  return _RegistrationData.fromJson(json);
}

/// @nodoc
mixin _$RegistrationData {
  String get firstName => throw _privateConstructorUsedError;
  String get lastName => throw _privateConstructorUsedError;
  String get email => throw _privateConstructorUsedError;
  String get phone => throw _privateConstructorUsedError;
  String get password => throw _privateConstructorUsedError;
  String get platformType => throw _privateConstructorUsedError;

  /// Serializes this RegistrationData to a JSON map.
  Map<String, dynamic> toJson() => throw _privateConstructorUsedError;

  /// Create a copy of RegistrationData
  /// with the given fields replaced by the non-null parameter values.
  @JsonKey(includeFromJson: false, includeToJson: false)
  $RegistrationDataCopyWith<RegistrationData> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $RegistrationDataCopyWith<$Res> {
  factory $RegistrationDataCopyWith(
          RegistrationData value, $Res Function(RegistrationData) then) =
      _$RegistrationDataCopyWithImpl<$Res, RegistrationData>;
  @useResult
  $Res call(
      {String firstName,
      String lastName,
      String email,
      String phone,
      String password,
      String platformType});
}

/// @nodoc
class _$RegistrationDataCopyWithImpl<$Res, $Val extends RegistrationData>
    implements $RegistrationDataCopyWith<$Res> {
  _$RegistrationDataCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;

  /// Create a copy of RegistrationData
  /// with the given fields replaced by the non-null parameter values.
  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? firstName = null,
    Object? lastName = null,
    Object? email = null,
    Object? phone = null,
    Object? password = null,
    Object? platformType = null,
  }) {
    return _then(_value.copyWith(
      firstName: null == firstName
          ? _value.firstName
          : firstName // ignore: cast_nullable_to_non_nullable
              as String,
      lastName: null == lastName
          ? _value.lastName
          : lastName // ignore: cast_nullable_to_non_nullable
              as String,
      email: null == email
          ? _value.email
          : email // ignore: cast_nullable_to_non_nullable
              as String,
      phone: null == phone
          ? _value.phone
          : phone // ignore: cast_nullable_to_non_nullable
              as String,
      password: null == password
          ? _value.password
          : password // ignore: cast_nullable_to_non_nullable
              as String,
      platformType: null == platformType
          ? _value.platformType
          : platformType // ignore: cast_nullable_to_non_nullable
              as String,
    ) as $Val);
  }
}

/// @nodoc
abstract class _$$RegistrationDataImplCopyWith<$Res>
    implements $RegistrationDataCopyWith<$Res> {
  factory _$$RegistrationDataImplCopyWith(_$RegistrationDataImpl value,
          $Res Function(_$RegistrationDataImpl) then) =
      __$$RegistrationDataImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call(
      {String firstName,
      String lastName,
      String email,
      String phone,
      String password,
      String platformType});
}

/// @nodoc
class __$$RegistrationDataImplCopyWithImpl<$Res>
    extends _$RegistrationDataCopyWithImpl<$Res, _$RegistrationDataImpl>
    implements _$$RegistrationDataImplCopyWith<$Res> {
  __$$RegistrationDataImplCopyWithImpl(_$RegistrationDataImpl _value,
      $Res Function(_$RegistrationDataImpl) _then)
      : super(_value, _then);

  /// Create a copy of RegistrationData
  /// with the given fields replaced by the non-null parameter values.
  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? firstName = null,
    Object? lastName = null,
    Object? email = null,
    Object? phone = null,
    Object? password = null,
    Object? platformType = null,
  }) {
    return _then(_$RegistrationDataImpl(
      firstName: null == firstName
          ? _value.firstName
          : firstName // ignore: cast_nullable_to_non_nullable
              as String,
      lastName: null == lastName
          ? _value.lastName
          : lastName // ignore: cast_nullable_to_non_nullable
              as String,
      email: null == email
          ? _value.email
          : email // ignore: cast_nullable_to_non_nullable
              as String,
      phone: null == phone
          ? _value.phone
          : phone // ignore: cast_nullable_to_non_nullable
              as String,
      password: null == password
          ? _value.password
          : password // ignore: cast_nullable_to_non_nullable
              as String,
      platformType: null == platformType
          ? _value.platformType
          : platformType // ignore: cast_nullable_to_non_nullable
              as String,
    ));
  }
}

/// @nodoc
@JsonSerializable()
class _$RegistrationDataImpl implements _RegistrationData {
  const _$RegistrationDataImpl(
      {this.firstName = '',
      this.lastName = '',
      this.email = '',
      this.phone = '',
      this.password = '',
      this.platformType = ''});

  factory _$RegistrationDataImpl.fromJson(Map<String, dynamic> json) =>
      _$$RegistrationDataImplFromJson(json);

  @override
  @JsonKey()
  final String firstName;
  @override
  @JsonKey()
  final String lastName;
  @override
  @JsonKey()
  final String email;
  @override
  @JsonKey()
  final String phone;
  @override
  @JsonKey()
  final String password;
  @override
  @JsonKey()
  final String platformType;

  @override
  String toString() {
    return 'RegistrationData(firstName: $firstName, lastName: $lastName, email: $email, phone: $phone, password: $password, platformType: $platformType)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$RegistrationDataImpl &&
            (identical(other.firstName, firstName) ||
                other.firstName == firstName) &&
            (identical(other.lastName, lastName) ||
                other.lastName == lastName) &&
            (identical(other.email, email) || other.email == email) &&
            (identical(other.phone, phone) || other.phone == phone) &&
            (identical(other.password, password) ||
                other.password == password) &&
            (identical(other.platformType, platformType) ||
                other.platformType == platformType));
  }

  @JsonKey(includeFromJson: false, includeToJson: false)
  @override
  int get hashCode => Object.hash(
      runtimeType, firstName, lastName, email, phone, password, platformType);

  /// Create a copy of RegistrationData
  /// with the given fields replaced by the non-null parameter values.
  @JsonKey(includeFromJson: false, includeToJson: false)
  @override
  @pragma('vm:prefer-inline')
  _$$RegistrationDataImplCopyWith<_$RegistrationDataImpl> get copyWith =>
      __$$RegistrationDataImplCopyWithImpl<_$RegistrationDataImpl>(
          this, _$identity);

  @override
  Map<String, dynamic> toJson() {
    return _$$RegistrationDataImplToJson(
      this,
    );
  }
}

abstract class _RegistrationData implements RegistrationData {
  const factory _RegistrationData(
      {final String firstName,
      final String lastName,
      final String email,
      final String phone,
      final String password,
      final String platformType}) = _$RegistrationDataImpl;

  factory _RegistrationData.fromJson(Map<String, dynamic> json) =
      _$RegistrationDataImpl.fromJson;

  @override
  String get firstName;
  @override
  String get lastName;
  @override
  String get email;
  @override
  String get phone;
  @override
  String get password;
  @override
  String get platformType;

  /// Create a copy of RegistrationData
  /// with the given fields replaced by the non-null parameter values.
  @override
  @JsonKey(includeFromJson: false, includeToJson: false)
  _$$RegistrationDataImplCopyWith<_$RegistrationDataImpl> get copyWith =>
      throw _privateConstructorUsedError;
}
