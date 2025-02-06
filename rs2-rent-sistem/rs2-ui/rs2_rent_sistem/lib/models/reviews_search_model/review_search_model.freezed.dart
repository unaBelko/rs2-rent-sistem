// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'review_search_model.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

ReviewSearchModel _$ReviewSearchModelFromJson(Map<String, dynamic> json) {
  return _ReviewSearchModel.fromJson(json);
}

/// @nodoc
mixin _$ReviewSearchModel {
  String get searchForUserId => throw _privateConstructorUsedError;
  String get searchForEquipmentId => throw _privateConstructorUsedError;

  /// Serializes this ReviewSearchModel to a JSON map.
  Map<String, dynamic> toJson() => throw _privateConstructorUsedError;

  /// Create a copy of ReviewSearchModel
  /// with the given fields replaced by the non-null parameter values.
  @JsonKey(includeFromJson: false, includeToJson: false)
  $ReviewSearchModelCopyWith<ReviewSearchModel> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $ReviewSearchModelCopyWith<$Res> {
  factory $ReviewSearchModelCopyWith(
          ReviewSearchModel value, $Res Function(ReviewSearchModel) then) =
      _$ReviewSearchModelCopyWithImpl<$Res, ReviewSearchModel>;
  @useResult
  $Res call({String searchForUserId, String searchForEquipmentId});
}

/// @nodoc
class _$ReviewSearchModelCopyWithImpl<$Res, $Val extends ReviewSearchModel>
    implements $ReviewSearchModelCopyWith<$Res> {
  _$ReviewSearchModelCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;

  /// Create a copy of ReviewSearchModel
  /// with the given fields replaced by the non-null parameter values.
  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? searchForUserId = null,
    Object? searchForEquipmentId = null,
  }) {
    return _then(_value.copyWith(
      searchForUserId: null == searchForUserId
          ? _value.searchForUserId
          : searchForUserId // ignore: cast_nullable_to_non_nullable
              as String,
      searchForEquipmentId: null == searchForEquipmentId
          ? _value.searchForEquipmentId
          : searchForEquipmentId // ignore: cast_nullable_to_non_nullable
              as String,
    ) as $Val);
  }
}

/// @nodoc
abstract class _$$ReviewSearchModelImplCopyWith<$Res>
    implements $ReviewSearchModelCopyWith<$Res> {
  factory _$$ReviewSearchModelImplCopyWith(_$ReviewSearchModelImpl value,
          $Res Function(_$ReviewSearchModelImpl) then) =
      __$$ReviewSearchModelImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call({String searchForUserId, String searchForEquipmentId});
}

/// @nodoc
class __$$ReviewSearchModelImplCopyWithImpl<$Res>
    extends _$ReviewSearchModelCopyWithImpl<$Res, _$ReviewSearchModelImpl>
    implements _$$ReviewSearchModelImplCopyWith<$Res> {
  __$$ReviewSearchModelImplCopyWithImpl(_$ReviewSearchModelImpl _value,
      $Res Function(_$ReviewSearchModelImpl) _then)
      : super(_value, _then);

  /// Create a copy of ReviewSearchModel
  /// with the given fields replaced by the non-null parameter values.
  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? searchForUserId = null,
    Object? searchForEquipmentId = null,
  }) {
    return _then(_$ReviewSearchModelImpl(
      searchForUserId: null == searchForUserId
          ? _value.searchForUserId
          : searchForUserId // ignore: cast_nullable_to_non_nullable
              as String,
      searchForEquipmentId: null == searchForEquipmentId
          ? _value.searchForEquipmentId
          : searchForEquipmentId // ignore: cast_nullable_to_non_nullable
              as String,
    ));
  }
}

/// @nodoc
@JsonSerializable()
class _$ReviewSearchModelImpl implements _ReviewSearchModel {
  const _$ReviewSearchModelImpl(
      {this.searchForUserId = '', this.searchForEquipmentId = ''});

  factory _$ReviewSearchModelImpl.fromJson(Map<String, dynamic> json) =>
      _$$ReviewSearchModelImplFromJson(json);

  @override
  @JsonKey()
  final String searchForUserId;
  @override
  @JsonKey()
  final String searchForEquipmentId;

  @override
  String toString() {
    return 'ReviewSearchModel(searchForUserId: $searchForUserId, searchForEquipmentId: $searchForEquipmentId)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$ReviewSearchModelImpl &&
            (identical(other.searchForUserId, searchForUserId) ||
                other.searchForUserId == searchForUserId) &&
            (identical(other.searchForEquipmentId, searchForEquipmentId) ||
                other.searchForEquipmentId == searchForEquipmentId));
  }

  @JsonKey(includeFromJson: false, includeToJson: false)
  @override
  int get hashCode =>
      Object.hash(runtimeType, searchForUserId, searchForEquipmentId);

  /// Create a copy of ReviewSearchModel
  /// with the given fields replaced by the non-null parameter values.
  @JsonKey(includeFromJson: false, includeToJson: false)
  @override
  @pragma('vm:prefer-inline')
  _$$ReviewSearchModelImplCopyWith<_$ReviewSearchModelImpl> get copyWith =>
      __$$ReviewSearchModelImplCopyWithImpl<_$ReviewSearchModelImpl>(
          this, _$identity);

  @override
  Map<String, dynamic> toJson() {
    return _$$ReviewSearchModelImplToJson(
      this,
    );
  }
}

abstract class _ReviewSearchModel implements ReviewSearchModel {
  const factory _ReviewSearchModel(
      {final String searchForUserId,
      final String searchForEquipmentId}) = _$ReviewSearchModelImpl;

  factory _ReviewSearchModel.fromJson(Map<String, dynamic> json) =
      _$ReviewSearchModelImpl.fromJson;

  @override
  String get searchForUserId;
  @override
  String get searchForEquipmentId;

  /// Create a copy of ReviewSearchModel
  /// with the given fields replaced by the non-null parameter values.
  @override
  @JsonKey(includeFromJson: false, includeToJson: false)
  _$$ReviewSearchModelImplCopyWith<_$ReviewSearchModelImpl> get copyWith =>
      throw _privateConstructorUsedError;
}
