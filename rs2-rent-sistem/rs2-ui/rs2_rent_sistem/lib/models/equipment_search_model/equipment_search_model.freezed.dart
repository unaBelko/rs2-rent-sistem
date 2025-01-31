// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'equipment_search_model.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

EquipmentSearchModel _$EquipmentSearchModelFromJson(Map<String, dynamic> json) {
  return _EquipmentSearchModel.fromJson(json);
}

/// @nodoc
mixin _$EquipmentSearchModel {
  String get name => throw _privateConstructorUsedError;
  int? get manufacturerID => throw _privateConstructorUsedError;
  int? get equipmentCategoryID => throw _privateConstructorUsedError;
  bool get sortDescending => throw _privateConstructorUsedError;

  /// Serializes this EquipmentSearchModel to a JSON map.
  Map<String, dynamic> toJson() => throw _privateConstructorUsedError;

  /// Create a copy of EquipmentSearchModel
  /// with the given fields replaced by the non-null parameter values.
  @JsonKey(includeFromJson: false, includeToJson: false)
  $EquipmentSearchModelCopyWith<EquipmentSearchModel> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $EquipmentSearchModelCopyWith<$Res> {
  factory $EquipmentSearchModelCopyWith(EquipmentSearchModel value,
          $Res Function(EquipmentSearchModel) then) =
      _$EquipmentSearchModelCopyWithImpl<$Res, EquipmentSearchModel>;
  @useResult
  $Res call(
      {String name,
      int? manufacturerID,
      int? equipmentCategoryID,
      bool sortDescending});
}

/// @nodoc
class _$EquipmentSearchModelCopyWithImpl<$Res,
        $Val extends EquipmentSearchModel>
    implements $EquipmentSearchModelCopyWith<$Res> {
  _$EquipmentSearchModelCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;

  /// Create a copy of EquipmentSearchModel
  /// with the given fields replaced by the non-null parameter values.
  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? name = null,
    Object? manufacturerID = freezed,
    Object? equipmentCategoryID = freezed,
    Object? sortDescending = null,
  }) {
    return _then(_value.copyWith(
      name: null == name
          ? _value.name
          : name // ignore: cast_nullable_to_non_nullable
              as String,
      manufacturerID: freezed == manufacturerID
          ? _value.manufacturerID
          : manufacturerID // ignore: cast_nullable_to_non_nullable
              as int?,
      equipmentCategoryID: freezed == equipmentCategoryID
          ? _value.equipmentCategoryID
          : equipmentCategoryID // ignore: cast_nullable_to_non_nullable
              as int?,
      sortDescending: null == sortDescending
          ? _value.sortDescending
          : sortDescending // ignore: cast_nullable_to_non_nullable
              as bool,
    ) as $Val);
  }
}

/// @nodoc
abstract class _$$EquipmentSearchModelImplCopyWith<$Res>
    implements $EquipmentSearchModelCopyWith<$Res> {
  factory _$$EquipmentSearchModelImplCopyWith(_$EquipmentSearchModelImpl value,
          $Res Function(_$EquipmentSearchModelImpl) then) =
      __$$EquipmentSearchModelImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call(
      {String name,
      int? manufacturerID,
      int? equipmentCategoryID,
      bool sortDescending});
}

/// @nodoc
class __$$EquipmentSearchModelImplCopyWithImpl<$Res>
    extends _$EquipmentSearchModelCopyWithImpl<$Res, _$EquipmentSearchModelImpl>
    implements _$$EquipmentSearchModelImplCopyWith<$Res> {
  __$$EquipmentSearchModelImplCopyWithImpl(_$EquipmentSearchModelImpl _value,
      $Res Function(_$EquipmentSearchModelImpl) _then)
      : super(_value, _then);

  /// Create a copy of EquipmentSearchModel
  /// with the given fields replaced by the non-null parameter values.
  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? name = null,
    Object? manufacturerID = freezed,
    Object? equipmentCategoryID = freezed,
    Object? sortDescending = null,
  }) {
    return _then(_$EquipmentSearchModelImpl(
      name: null == name
          ? _value.name
          : name // ignore: cast_nullable_to_non_nullable
              as String,
      manufacturerID: freezed == manufacturerID
          ? _value.manufacturerID
          : manufacturerID // ignore: cast_nullable_to_non_nullable
              as int?,
      equipmentCategoryID: freezed == equipmentCategoryID
          ? _value.equipmentCategoryID
          : equipmentCategoryID // ignore: cast_nullable_to_non_nullable
              as int?,
      sortDescending: null == sortDescending
          ? _value.sortDescending
          : sortDescending // ignore: cast_nullable_to_non_nullable
              as bool,
    ));
  }
}

/// @nodoc
@JsonSerializable()
class _$EquipmentSearchModelImpl implements _EquipmentSearchModel {
  const _$EquipmentSearchModelImpl(
      {this.name = '',
      this.manufacturerID,
      this.equipmentCategoryID,
      this.sortDescending = true});

  factory _$EquipmentSearchModelImpl.fromJson(Map<String, dynamic> json) =>
      _$$EquipmentSearchModelImplFromJson(json);

  @override
  @JsonKey()
  final String name;
  @override
  final int? manufacturerID;
  @override
  final int? equipmentCategoryID;
  @override
  @JsonKey()
  final bool sortDescending;

  @override
  String toString() {
    return 'EquipmentSearchModel(name: $name, manufacturerID: $manufacturerID, equipmentCategoryID: $equipmentCategoryID, sortDescending: $sortDescending)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$EquipmentSearchModelImpl &&
            (identical(other.name, name) || other.name == name) &&
            (identical(other.manufacturerID, manufacturerID) ||
                other.manufacturerID == manufacturerID) &&
            (identical(other.equipmentCategoryID, equipmentCategoryID) ||
                other.equipmentCategoryID == equipmentCategoryID) &&
            (identical(other.sortDescending, sortDescending) ||
                other.sortDescending == sortDescending));
  }

  @JsonKey(includeFromJson: false, includeToJson: false)
  @override
  int get hashCode => Object.hash(
      runtimeType, name, manufacturerID, equipmentCategoryID, sortDescending);

  /// Create a copy of EquipmentSearchModel
  /// with the given fields replaced by the non-null parameter values.
  @JsonKey(includeFromJson: false, includeToJson: false)
  @override
  @pragma('vm:prefer-inline')
  _$$EquipmentSearchModelImplCopyWith<_$EquipmentSearchModelImpl>
      get copyWith =>
          __$$EquipmentSearchModelImplCopyWithImpl<_$EquipmentSearchModelImpl>(
              this, _$identity);

  @override
  Map<String, dynamic> toJson() {
    return _$$EquipmentSearchModelImplToJson(
      this,
    );
  }
}

abstract class _EquipmentSearchModel implements EquipmentSearchModel {
  const factory _EquipmentSearchModel(
      {final String name,
      final int? manufacturerID,
      final int? equipmentCategoryID,
      final bool sortDescending}) = _$EquipmentSearchModelImpl;

  factory _EquipmentSearchModel.fromJson(Map<String, dynamic> json) =
      _$EquipmentSearchModelImpl.fromJson;

  @override
  String get name;
  @override
  int? get manufacturerID;
  @override
  int? get equipmentCategoryID;
  @override
  bool get sortDescending;

  /// Create a copy of EquipmentSearchModel
  /// with the given fields replaced by the non-null parameter values.
  @override
  @JsonKey(includeFromJson: false, includeToJson: false)
  _$$EquipmentSearchModelImplCopyWith<_$EquipmentSearchModelImpl>
      get copyWith => throw _privateConstructorUsedError;
}
