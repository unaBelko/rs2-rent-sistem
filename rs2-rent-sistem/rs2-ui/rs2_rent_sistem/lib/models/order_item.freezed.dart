// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'order_item.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

OrderItem _$OrderItemFromJson(Map<String, dynamic> json) {
  return _OrderItem.fromJson(json);
}

/// @nodoc
mixin _$OrderItem {
  int get id => throw _privateConstructorUsedError;
  DateTime get startDate => throw _privateConstructorUsedError;
  DateTime get endDate => throw _privateConstructorUsedError;
  int get quantity => throw _privateConstructorUsedError;
  double get costPerUse => throw _privateConstructorUsedError;
  EquipmentListItem get equipment => throw _privateConstructorUsedError;

  Map<String, dynamic> toJson() => throw _privateConstructorUsedError;
  @JsonKey(ignore: true)
  $OrderItemCopyWith<OrderItem> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $OrderItemCopyWith<$Res> {
  factory $OrderItemCopyWith(OrderItem value, $Res Function(OrderItem) then) =
      _$OrderItemCopyWithImpl<$Res, OrderItem>;
  @useResult
  $Res call(
      {int id,
      DateTime startDate,
      DateTime endDate,
      int quantity,
      double costPerUse,
      EquipmentListItem equipment});

  $EquipmentListItemCopyWith<$Res> get equipment;
}

/// @nodoc
class _$OrderItemCopyWithImpl<$Res, $Val extends OrderItem>
    implements $OrderItemCopyWith<$Res> {
  _$OrderItemCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? startDate = null,
    Object? endDate = null,
    Object? quantity = null,
    Object? costPerUse = null,
    Object? equipment = null,
  }) {
    return _then(_value.copyWith(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as int,
      startDate: null == startDate
          ? _value.startDate
          : startDate // ignore: cast_nullable_to_non_nullable
              as DateTime,
      endDate: null == endDate
          ? _value.endDate
          : endDate // ignore: cast_nullable_to_non_nullable
              as DateTime,
      quantity: null == quantity
          ? _value.quantity
          : quantity // ignore: cast_nullable_to_non_nullable
              as int,
      costPerUse: null == costPerUse
          ? _value.costPerUse
          : costPerUse // ignore: cast_nullable_to_non_nullable
              as double,
      equipment: null == equipment
          ? _value.equipment
          : equipment // ignore: cast_nullable_to_non_nullable
              as EquipmentListItem,
    ) as $Val);
  }

  @override
  @pragma('vm:prefer-inline')
  $EquipmentListItemCopyWith<$Res> get equipment {
    return $EquipmentListItemCopyWith<$Res>(_value.equipment, (value) {
      return _then(_value.copyWith(equipment: value) as $Val);
    });
  }
}

/// @nodoc
abstract class _$$OrderItemImplCopyWith<$Res>
    implements $OrderItemCopyWith<$Res> {
  factory _$$OrderItemImplCopyWith(
          _$OrderItemImpl value, $Res Function(_$OrderItemImpl) then) =
      __$$OrderItemImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call(
      {int id,
      DateTime startDate,
      DateTime endDate,
      int quantity,
      double costPerUse,
      EquipmentListItem equipment});

  @override
  $EquipmentListItemCopyWith<$Res> get equipment;
}

/// @nodoc
class __$$OrderItemImplCopyWithImpl<$Res>
    extends _$OrderItemCopyWithImpl<$Res, _$OrderItemImpl>
    implements _$$OrderItemImplCopyWith<$Res> {
  __$$OrderItemImplCopyWithImpl(
      _$OrderItemImpl _value, $Res Function(_$OrderItemImpl) _then)
      : super(_value, _then);

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? startDate = null,
    Object? endDate = null,
    Object? quantity = null,
    Object? costPerUse = null,
    Object? equipment = null,
  }) {
    return _then(_$OrderItemImpl(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as int,
      startDate: null == startDate
          ? _value.startDate
          : startDate // ignore: cast_nullable_to_non_nullable
              as DateTime,
      endDate: null == endDate
          ? _value.endDate
          : endDate // ignore: cast_nullable_to_non_nullable
              as DateTime,
      quantity: null == quantity
          ? _value.quantity
          : quantity // ignore: cast_nullable_to_non_nullable
              as int,
      costPerUse: null == costPerUse
          ? _value.costPerUse
          : costPerUse // ignore: cast_nullable_to_non_nullable
              as double,
      equipment: null == equipment
          ? _value.equipment
          : equipment // ignore: cast_nullable_to_non_nullable
              as EquipmentListItem,
    ));
  }
}

/// @nodoc
@JsonSerializable()
class _$OrderItemImpl implements _OrderItem {
  const _$OrderItemImpl(
      {required this.id,
      required this.startDate,
      required this.endDate,
      this.quantity = 0,
      this.costPerUse = 0,
      required this.equipment});

  factory _$OrderItemImpl.fromJson(Map<String, dynamic> json) =>
      _$$OrderItemImplFromJson(json);

  @override
  final int id;
  @override
  final DateTime startDate;
  @override
  final DateTime endDate;
  @override
  @JsonKey()
  final int quantity;
  @override
  @JsonKey()
  final double costPerUse;
  @override
  final EquipmentListItem equipment;

  @override
  String toString() {
    return 'OrderItem(id: $id, startDate: $startDate, endDate: $endDate, quantity: $quantity, costPerUse: $costPerUse, equipment: $equipment)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$OrderItemImpl &&
            (identical(other.id, id) || other.id == id) &&
            (identical(other.startDate, startDate) ||
                other.startDate == startDate) &&
            (identical(other.endDate, endDate) || other.endDate == endDate) &&
            (identical(other.quantity, quantity) ||
                other.quantity == quantity) &&
            (identical(other.costPerUse, costPerUse) ||
                other.costPerUse == costPerUse) &&
            (identical(other.equipment, equipment) ||
                other.equipment == equipment));
  }

  @JsonKey(ignore: true)
  @override
  int get hashCode => Object.hash(
      runtimeType, id, startDate, endDate, quantity, costPerUse, equipment);

  @JsonKey(ignore: true)
  @override
  @pragma('vm:prefer-inline')
  _$$OrderItemImplCopyWith<_$OrderItemImpl> get copyWith =>
      __$$OrderItemImplCopyWithImpl<_$OrderItemImpl>(this, _$identity);

  @override
  Map<String, dynamic> toJson() {
    return _$$OrderItemImplToJson(
      this,
    );
  }
}

abstract class _OrderItem implements OrderItem {
  const factory _OrderItem(
      {required final int id,
      required final DateTime startDate,
      required final DateTime endDate,
      final int quantity,
      final double costPerUse,
      required final EquipmentListItem equipment}) = _$OrderItemImpl;

  factory _OrderItem.fromJson(Map<String, dynamic> json) =
      _$OrderItemImpl.fromJson;

  @override
  int get id;
  @override
  DateTime get startDate;
  @override
  DateTime get endDate;
  @override
  int get quantity;
  @override
  double get costPerUse;
  @override
  EquipmentListItem get equipment;
  @override
  @JsonKey(ignore: true)
  _$$OrderItemImplCopyWith<_$OrderItemImpl> get copyWith =>
      throw _privateConstructorUsedError;
}
