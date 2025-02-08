// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'damage.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

Damage _$DamageFromJson(Map<String, dynamic> json) {
  return _Damage.fromJson(json);
}

/// @nodoc
mixin _$Damage {
  int get id => throw _privateConstructorUsedError;
  ItemInOrder get orderItem => throw _privateConstructorUsedError;
  String get comment => throw _privateConstructorUsedError;
  DateTime? get dateAdded => throw _privateConstructorUsedError;

  /// Serializes this Damage to a JSON map.
  Map<String, dynamic> toJson() => throw _privateConstructorUsedError;

  /// Create a copy of Damage
  /// with the given fields replaced by the non-null parameter values.
  @JsonKey(includeFromJson: false, includeToJson: false)
  $DamageCopyWith<Damage> get copyWith => throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $DamageCopyWith<$Res> {
  factory $DamageCopyWith(Damage value, $Res Function(Damage) then) =
      _$DamageCopyWithImpl<$Res, Damage>;
  @useResult
  $Res call(
      {int id, ItemInOrder orderItem, String comment, DateTime? dateAdded});

  $ItemInOrderCopyWith<$Res> get orderItem;
}

/// @nodoc
class _$DamageCopyWithImpl<$Res, $Val extends Damage>
    implements $DamageCopyWith<$Res> {
  _$DamageCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;

  /// Create a copy of Damage
  /// with the given fields replaced by the non-null parameter values.
  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? orderItem = null,
    Object? comment = null,
    Object? dateAdded = freezed,
  }) {
    return _then(_value.copyWith(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as int,
      orderItem: null == orderItem
          ? _value.orderItem
          : orderItem // ignore: cast_nullable_to_non_nullable
              as ItemInOrder,
      comment: null == comment
          ? _value.comment
          : comment // ignore: cast_nullable_to_non_nullable
              as String,
      dateAdded: freezed == dateAdded
          ? _value.dateAdded
          : dateAdded // ignore: cast_nullable_to_non_nullable
              as DateTime?,
    ) as $Val);
  }

  /// Create a copy of Damage
  /// with the given fields replaced by the non-null parameter values.
  @override
  @pragma('vm:prefer-inline')
  $ItemInOrderCopyWith<$Res> get orderItem {
    return $ItemInOrderCopyWith<$Res>(_value.orderItem, (value) {
      return _then(_value.copyWith(orderItem: value) as $Val);
    });
  }
}

/// @nodoc
abstract class _$$DamageImplCopyWith<$Res> implements $DamageCopyWith<$Res> {
  factory _$$DamageImplCopyWith(
          _$DamageImpl value, $Res Function(_$DamageImpl) then) =
      __$$DamageImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call(
      {int id, ItemInOrder orderItem, String comment, DateTime? dateAdded});

  @override
  $ItemInOrderCopyWith<$Res> get orderItem;
}

/// @nodoc
class __$$DamageImplCopyWithImpl<$Res>
    extends _$DamageCopyWithImpl<$Res, _$DamageImpl>
    implements _$$DamageImplCopyWith<$Res> {
  __$$DamageImplCopyWithImpl(
      _$DamageImpl _value, $Res Function(_$DamageImpl) _then)
      : super(_value, _then);

  /// Create a copy of Damage
  /// with the given fields replaced by the non-null parameter values.
  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? orderItem = null,
    Object? comment = null,
    Object? dateAdded = freezed,
  }) {
    return _then(_$DamageImpl(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as int,
      orderItem: null == orderItem
          ? _value.orderItem
          : orderItem // ignore: cast_nullable_to_non_nullable
              as ItemInOrder,
      comment: null == comment
          ? _value.comment
          : comment // ignore: cast_nullable_to_non_nullable
              as String,
      dateAdded: freezed == dateAdded
          ? _value.dateAdded
          : dateAdded // ignore: cast_nullable_to_non_nullable
              as DateTime?,
    ));
  }
}

/// @nodoc
@JsonSerializable()
class _$DamageImpl implements _Damage {
  const _$DamageImpl(
      {required this.id,
      required this.orderItem,
      this.comment = '',
      this.dateAdded});

  factory _$DamageImpl.fromJson(Map<String, dynamic> json) =>
      _$$DamageImplFromJson(json);

  @override
  final int id;
  @override
  final ItemInOrder orderItem;
  @override
  @JsonKey()
  final String comment;
  @override
  final DateTime? dateAdded;

  @override
  String toString() {
    return 'Damage(id: $id, orderItem: $orderItem, comment: $comment, dateAdded: $dateAdded)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$DamageImpl &&
            (identical(other.id, id) || other.id == id) &&
            (identical(other.orderItem, orderItem) ||
                other.orderItem == orderItem) &&
            (identical(other.comment, comment) || other.comment == comment) &&
            (identical(other.dateAdded, dateAdded) ||
                other.dateAdded == dateAdded));
  }

  @JsonKey(includeFromJson: false, includeToJson: false)
  @override
  int get hashCode =>
      Object.hash(runtimeType, id, orderItem, comment, dateAdded);

  /// Create a copy of Damage
  /// with the given fields replaced by the non-null parameter values.
  @JsonKey(includeFromJson: false, includeToJson: false)
  @override
  @pragma('vm:prefer-inline')
  _$$DamageImplCopyWith<_$DamageImpl> get copyWith =>
      __$$DamageImplCopyWithImpl<_$DamageImpl>(this, _$identity);

  @override
  Map<String, dynamic> toJson() {
    return _$$DamageImplToJson(
      this,
    );
  }
}

abstract class _Damage implements Damage {
  const factory _Damage(
      {required final int id,
      required final ItemInOrder orderItem,
      final String comment,
      final DateTime? dateAdded}) = _$DamageImpl;

  factory _Damage.fromJson(Map<String, dynamic> json) = _$DamageImpl.fromJson;

  @override
  int get id;
  @override
  ItemInOrder get orderItem;
  @override
  String get comment;
  @override
  DateTime? get dateAdded;

  /// Create a copy of Damage
  /// with the given fields replaced by the non-null parameter values.
  @override
  @JsonKey(includeFromJson: false, includeToJson: false)
  _$$DamageImplCopyWith<_$DamageImpl> get copyWith =>
      throw _privateConstructorUsedError;
}
