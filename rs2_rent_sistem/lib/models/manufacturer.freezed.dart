// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'manufacturer.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

Manufacturer _$ManufacturerFromJson(Map<String, dynamic> json) {
  return _Manufacturer.fromJson(json);
}

/// @nodoc
mixin _$Manufacturer {
  String get id => throw _privateConstructorUsedError;
  String get name => throw _privateConstructorUsedError;
  String get description => throw _privateConstructorUsedError;

  Map<String, dynamic> toJson() => throw _privateConstructorUsedError;
  @JsonKey(ignore: true)
  $ManufacturerCopyWith<Manufacturer> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $ManufacturerCopyWith<$Res> {
  factory $ManufacturerCopyWith(
          Manufacturer value, $Res Function(Manufacturer) then) =
      _$ManufacturerCopyWithImpl<$Res, Manufacturer>;
  @useResult
  $Res call({String id, String name, String description});
}

/// @nodoc
class _$ManufacturerCopyWithImpl<$Res, $Val extends Manufacturer>
    implements $ManufacturerCopyWith<$Res> {
  _$ManufacturerCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? name = null,
    Object? description = null,
  }) {
    return _then(_value.copyWith(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as String,
      name: null == name
          ? _value.name
          : name // ignore: cast_nullable_to_non_nullable
              as String,
      description: null == description
          ? _value.description
          : description // ignore: cast_nullable_to_non_nullable
              as String,
    ) as $Val);
  }
}

/// @nodoc
abstract class _$$ManufacturerImplCopyWith<$Res>
    implements $ManufacturerCopyWith<$Res> {
  factory _$$ManufacturerImplCopyWith(
          _$ManufacturerImpl value, $Res Function(_$ManufacturerImpl) then) =
      __$$ManufacturerImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call({String id, String name, String description});
}

/// @nodoc
class __$$ManufacturerImplCopyWithImpl<$Res>
    extends _$ManufacturerCopyWithImpl<$Res, _$ManufacturerImpl>
    implements _$$ManufacturerImplCopyWith<$Res> {
  __$$ManufacturerImplCopyWithImpl(
      _$ManufacturerImpl _value, $Res Function(_$ManufacturerImpl) _then)
      : super(_value, _then);

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? name = null,
    Object? description = null,
  }) {
    return _then(_$ManufacturerImpl(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as String,
      name: null == name
          ? _value.name
          : name // ignore: cast_nullable_to_non_nullable
              as String,
      description: null == description
          ? _value.description
          : description // ignore: cast_nullable_to_non_nullable
              as String,
    ));
  }
}

/// @nodoc
@JsonSerializable()
class _$ManufacturerImpl implements _Manufacturer {
  const _$ManufacturerImpl(
      {this.id = '', this.name = '', this.description = ''});

  factory _$ManufacturerImpl.fromJson(Map<String, dynamic> json) =>
      _$$ManufacturerImplFromJson(json);

  @override
  @JsonKey()
  final String id;
  @override
  @JsonKey()
  final String name;
  @override
  @JsonKey()
  final String description;

  @override
  String toString() {
    return 'Manufacturer(id: $id, name: $name, description: $description)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$ManufacturerImpl &&
            (identical(other.id, id) || other.id == id) &&
            (identical(other.name, name) || other.name == name) &&
            (identical(other.description, description) ||
                other.description == description));
  }

  @JsonKey(ignore: true)
  @override
  int get hashCode => Object.hash(runtimeType, id, name, description);

  @JsonKey(ignore: true)
  @override
  @pragma('vm:prefer-inline')
  _$$ManufacturerImplCopyWith<_$ManufacturerImpl> get copyWith =>
      __$$ManufacturerImplCopyWithImpl<_$ManufacturerImpl>(this, _$identity);

  @override
  Map<String, dynamic> toJson() {
    return _$$ManufacturerImplToJson(
      this,
    );
  }
}

abstract class _Manufacturer implements Manufacturer {
  const factory _Manufacturer(
      {final String id,
      final String name,
      final String description}) = _$ManufacturerImpl;

  factory _Manufacturer.fromJson(Map<String, dynamic> json) =
      _$ManufacturerImpl.fromJson;

  @override
  String get id;
  @override
  String get name;
  @override
  String get description;
  @override
  @JsonKey(ignore: true)
  _$$ManufacturerImplCopyWith<_$ManufacturerImpl> get copyWith =>
      throw _privateConstructorUsedError;
}
