// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'equipment_list.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

EquipmentList _$EquipmentListFromJson(Map<String, dynamic> json) {
  return _EquipmentList.fromJson(json);
}

/// @nodoc
mixin _$EquipmentList {
  List<EquipmentListItem> get result => throw _privateConstructorUsedError;
  int get count => throw _privateConstructorUsedError;

  /// Serializes this EquipmentList to a JSON map.
  Map<String, dynamic> toJson() => throw _privateConstructorUsedError;

  /// Create a copy of EquipmentList
  /// with the given fields replaced by the non-null parameter values.
  @JsonKey(includeFromJson: false, includeToJson: false)
  $EquipmentListCopyWith<EquipmentList> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $EquipmentListCopyWith<$Res> {
  factory $EquipmentListCopyWith(
          EquipmentList value, $Res Function(EquipmentList) then) =
      _$EquipmentListCopyWithImpl<$Res, EquipmentList>;
  @useResult
  $Res call({List<EquipmentListItem> result, int count});
}

/// @nodoc
class _$EquipmentListCopyWithImpl<$Res, $Val extends EquipmentList>
    implements $EquipmentListCopyWith<$Res> {
  _$EquipmentListCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;

  /// Create a copy of EquipmentList
  /// with the given fields replaced by the non-null parameter values.
  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? result = null,
    Object? count = null,
  }) {
    return _then(_value.copyWith(
      result: null == result
          ? _value.result
          : result // ignore: cast_nullable_to_non_nullable
              as List<EquipmentListItem>,
      count: null == count
          ? _value.count
          : count // ignore: cast_nullable_to_non_nullable
              as int,
    ) as $Val);
  }
}

/// @nodoc
abstract class _$$EquipmentListImplCopyWith<$Res>
    implements $EquipmentListCopyWith<$Res> {
  factory _$$EquipmentListImplCopyWith(
          _$EquipmentListImpl value, $Res Function(_$EquipmentListImpl) then) =
      __$$EquipmentListImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call({List<EquipmentListItem> result, int count});
}

/// @nodoc
class __$$EquipmentListImplCopyWithImpl<$Res>
    extends _$EquipmentListCopyWithImpl<$Res, _$EquipmentListImpl>
    implements _$$EquipmentListImplCopyWith<$Res> {
  __$$EquipmentListImplCopyWithImpl(
      _$EquipmentListImpl _value, $Res Function(_$EquipmentListImpl) _then)
      : super(_value, _then);

  /// Create a copy of EquipmentList
  /// with the given fields replaced by the non-null parameter values.
  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? result = null,
    Object? count = null,
  }) {
    return _then(_$EquipmentListImpl(
      result: null == result
          ? _value._result
          : result // ignore: cast_nullable_to_non_nullable
              as List<EquipmentListItem>,
      count: null == count
          ? _value.count
          : count // ignore: cast_nullable_to_non_nullable
              as int,
    ));
  }
}

/// @nodoc
@JsonSerializable()
class _$EquipmentListImpl implements _EquipmentList {
  _$EquipmentListImpl(
      {final List<EquipmentListItem> result = const [], required this.count})
      : _result = result;

  factory _$EquipmentListImpl.fromJson(Map<String, dynamic> json) =>
      _$$EquipmentListImplFromJson(json);

  final List<EquipmentListItem> _result;
  @override
  @JsonKey()
  List<EquipmentListItem> get result {
    if (_result is EqualUnmodifiableListView) return _result;
    // ignore: implicit_dynamic_type
    return EqualUnmodifiableListView(_result);
  }

  @override
  final int count;

  @override
  String toString() {
    return 'EquipmentList(result: $result, count: $count)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$EquipmentListImpl &&
            const DeepCollectionEquality().equals(other._result, _result) &&
            (identical(other.count, count) || other.count == count));
  }

  @JsonKey(includeFromJson: false, includeToJson: false)
  @override
  int get hashCode => Object.hash(
      runtimeType, const DeepCollectionEquality().hash(_result), count);

  /// Create a copy of EquipmentList
  /// with the given fields replaced by the non-null parameter values.
  @JsonKey(includeFromJson: false, includeToJson: false)
  @override
  @pragma('vm:prefer-inline')
  _$$EquipmentListImplCopyWith<_$EquipmentListImpl> get copyWith =>
      __$$EquipmentListImplCopyWithImpl<_$EquipmentListImpl>(this, _$identity);

  @override
  Map<String, dynamic> toJson() {
    return _$$EquipmentListImplToJson(
      this,
    );
  }
}

abstract class _EquipmentList implements EquipmentList {
  factory _EquipmentList(
      {final List<EquipmentListItem> result,
      required final int count}) = _$EquipmentListImpl;

  factory _EquipmentList.fromJson(Map<String, dynamic> json) =
      _$EquipmentListImpl.fromJson;

  @override
  List<EquipmentListItem> get result;
  @override
  int get count;

  /// Create a copy of EquipmentList
  /// with the given fields replaced by the non-null parameter values.
  @override
  @JsonKey(includeFromJson: false, includeToJson: false)
  _$$EquipmentListImplCopyWith<_$EquipmentListImpl> get copyWith =>
      throw _privateConstructorUsedError;
}
