// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'review_for_admin.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

ReviewForAdmin _$ReviewForAdminFromJson(Map<String, dynamic> json) {
  return _ReviewForAdmin.fromJson(json);
}

/// @nodoc
mixin _$ReviewForAdmin {
  String get id => throw _privateConstructorUsedError;
  String? get equipmentName => throw _privateConstructorUsedError;
  String get content => throw _privateConstructorUsedError;
  DateTime? get dateOfCreation => throw _privateConstructorUsedError;

  Map<String, dynamic> toJson() => throw _privateConstructorUsedError;
  @JsonKey(ignore: true)
  $ReviewForAdminCopyWith<ReviewForAdmin> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $ReviewForAdminCopyWith<$Res> {
  factory $ReviewForAdminCopyWith(
          ReviewForAdmin value, $Res Function(ReviewForAdmin) then) =
      _$ReviewForAdminCopyWithImpl<$Res, ReviewForAdmin>;
  @useResult
  $Res call(
      {String id,
      String? equipmentName,
      String content,
      DateTime? dateOfCreation});
}

/// @nodoc
class _$ReviewForAdminCopyWithImpl<$Res, $Val extends ReviewForAdmin>
    implements $ReviewForAdminCopyWith<$Res> {
  _$ReviewForAdminCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? equipmentName = freezed,
    Object? content = null,
    Object? dateOfCreation = freezed,
  }) {
    return _then(_value.copyWith(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as String,
      equipmentName: freezed == equipmentName
          ? _value.equipmentName
          : equipmentName // ignore: cast_nullable_to_non_nullable
              as String?,
      content: null == content
          ? _value.content
          : content // ignore: cast_nullable_to_non_nullable
              as String,
      dateOfCreation: freezed == dateOfCreation
          ? _value.dateOfCreation
          : dateOfCreation // ignore: cast_nullable_to_non_nullable
              as DateTime?,
    ) as $Val);
  }
}

/// @nodoc
abstract class _$$ReviewForAdminImplCopyWith<$Res>
    implements $ReviewForAdminCopyWith<$Res> {
  factory _$$ReviewForAdminImplCopyWith(_$ReviewForAdminImpl value,
          $Res Function(_$ReviewForAdminImpl) then) =
      __$$ReviewForAdminImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call(
      {String id,
      String? equipmentName,
      String content,
      DateTime? dateOfCreation});
}

/// @nodoc
class __$$ReviewForAdminImplCopyWithImpl<$Res>
    extends _$ReviewForAdminCopyWithImpl<$Res, _$ReviewForAdminImpl>
    implements _$$ReviewForAdminImplCopyWith<$Res> {
  __$$ReviewForAdminImplCopyWithImpl(
      _$ReviewForAdminImpl _value, $Res Function(_$ReviewForAdminImpl) _then)
      : super(_value, _then);

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? equipmentName = freezed,
    Object? content = null,
    Object? dateOfCreation = freezed,
  }) {
    return _then(_$ReviewForAdminImpl(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as String,
      equipmentName: freezed == equipmentName
          ? _value.equipmentName
          : equipmentName // ignore: cast_nullable_to_non_nullable
              as String?,
      content: null == content
          ? _value.content
          : content // ignore: cast_nullable_to_non_nullable
              as String,
      dateOfCreation: freezed == dateOfCreation
          ? _value.dateOfCreation
          : dateOfCreation // ignore: cast_nullable_to_non_nullable
              as DateTime?,
    ));
  }
}

/// @nodoc
@JsonSerializable()
class _$ReviewForAdminImpl implements _ReviewForAdmin {
  const _$ReviewForAdminImpl(
      {this.id = '',
      this.equipmentName,
      this.content = '',
      this.dateOfCreation});

  factory _$ReviewForAdminImpl.fromJson(Map<String, dynamic> json) =>
      _$$ReviewForAdminImplFromJson(json);

  @override
  @JsonKey()
  final String id;
  @override
  final String? equipmentName;
  @override
  @JsonKey()
  final String content;
  @override
  final DateTime? dateOfCreation;

  @override
  String toString() {
    return 'ReviewForAdmin(id: $id, equipmentName: $equipmentName, content: $content, dateOfCreation: $dateOfCreation)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$ReviewForAdminImpl &&
            (identical(other.id, id) || other.id == id) &&
            (identical(other.equipmentName, equipmentName) ||
                other.equipmentName == equipmentName) &&
            (identical(other.content, content) || other.content == content) &&
            (identical(other.dateOfCreation, dateOfCreation) ||
                other.dateOfCreation == dateOfCreation));
  }

  @JsonKey(ignore: true)
  @override
  int get hashCode =>
      Object.hash(runtimeType, id, equipmentName, content, dateOfCreation);

  @JsonKey(ignore: true)
  @override
  @pragma('vm:prefer-inline')
  _$$ReviewForAdminImplCopyWith<_$ReviewForAdminImpl> get copyWith =>
      __$$ReviewForAdminImplCopyWithImpl<_$ReviewForAdminImpl>(
          this, _$identity);

  @override
  Map<String, dynamic> toJson() {
    return _$$ReviewForAdminImplToJson(
      this,
    );
  }
}

abstract class _ReviewForAdmin implements ReviewForAdmin {
  const factory _ReviewForAdmin(
      {final String id,
      final String? equipmentName,
      final String content,
      final DateTime? dateOfCreation}) = _$ReviewForAdminImpl;

  factory _ReviewForAdmin.fromJson(Map<String, dynamic> json) =
      _$ReviewForAdminImpl.fromJson;

  @override
  String get id;
  @override
  String? get equipmentName;
  @override
  String get content;
  @override
  DateTime? get dateOfCreation;
  @override
  @JsonKey(ignore: true)
  _$$ReviewForAdminImplCopyWith<_$ReviewForAdminImpl> get copyWith =>
      throw _privateConstructorUsedError;
}
