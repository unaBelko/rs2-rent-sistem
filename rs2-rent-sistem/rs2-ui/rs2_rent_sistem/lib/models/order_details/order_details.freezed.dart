// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'order_details.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

OrderDetails _$OrderDetailsFromJson(Map<String, dynamic> json) {
  return _OrderDetails.fromJson(json);
}

/// @nodoc
mixin _$OrderDetails {
  int get id => throw _privateConstructorUsedError;
  DateTime get datePlaced => throw _privateConstructorUsedError;
  double get totalPrice => throw _privateConstructorUsedError;

  /// Serializes this OrderDetails to a JSON map.
  Map<String, dynamic> toJson() => throw _privateConstructorUsedError;

  /// Create a copy of OrderDetails
  /// with the given fields replaced by the non-null parameter values.
  @JsonKey(includeFromJson: false, includeToJson: false)
  $OrderDetailsCopyWith<OrderDetails> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $OrderDetailsCopyWith<$Res> {
  factory $OrderDetailsCopyWith(
          OrderDetails value, $Res Function(OrderDetails) then) =
      _$OrderDetailsCopyWithImpl<$Res, OrderDetails>;
  @useResult
  $Res call({int id, DateTime datePlaced, double totalPrice});
}

/// @nodoc
class _$OrderDetailsCopyWithImpl<$Res, $Val extends OrderDetails>
    implements $OrderDetailsCopyWith<$Res> {
  _$OrderDetailsCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;

  /// Create a copy of OrderDetails
  /// with the given fields replaced by the non-null parameter values.
  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? datePlaced = null,
    Object? totalPrice = null,
  }) {
    return _then(_value.copyWith(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as int,
      datePlaced: null == datePlaced
          ? _value.datePlaced
          : datePlaced // ignore: cast_nullable_to_non_nullable
              as DateTime,
      totalPrice: null == totalPrice
          ? _value.totalPrice
          : totalPrice // ignore: cast_nullable_to_non_nullable
              as double,
    ) as $Val);
  }
}

/// @nodoc
abstract class _$$OrderDetailsImplCopyWith<$Res>
    implements $OrderDetailsCopyWith<$Res> {
  factory _$$OrderDetailsImplCopyWith(
          _$OrderDetailsImpl value, $Res Function(_$OrderDetailsImpl) then) =
      __$$OrderDetailsImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call({int id, DateTime datePlaced, double totalPrice});
}

/// @nodoc
class __$$OrderDetailsImplCopyWithImpl<$Res>
    extends _$OrderDetailsCopyWithImpl<$Res, _$OrderDetailsImpl>
    implements _$$OrderDetailsImplCopyWith<$Res> {
  __$$OrderDetailsImplCopyWithImpl(
      _$OrderDetailsImpl _value, $Res Function(_$OrderDetailsImpl) _then)
      : super(_value, _then);

  /// Create a copy of OrderDetails
  /// with the given fields replaced by the non-null parameter values.
  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? datePlaced = null,
    Object? totalPrice = null,
  }) {
    return _then(_$OrderDetailsImpl(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as int,
      datePlaced: null == datePlaced
          ? _value.datePlaced
          : datePlaced // ignore: cast_nullable_to_non_nullable
              as DateTime,
      totalPrice: null == totalPrice
          ? _value.totalPrice
          : totalPrice // ignore: cast_nullable_to_non_nullable
              as double,
    ));
  }
}

/// @nodoc
@JsonSerializable()
class _$OrderDetailsImpl implements _OrderDetails {
  const _$OrderDetailsImpl(
      {required this.id, required this.datePlaced, this.totalPrice = 0.0});

  factory _$OrderDetailsImpl.fromJson(Map<String, dynamic> json) =>
      _$$OrderDetailsImplFromJson(json);

  @override
  final int id;
  @override
  final DateTime datePlaced;
  @override
  @JsonKey()
  final double totalPrice;

  @override
  String toString() {
    return 'OrderDetails(id: $id, datePlaced: $datePlaced, totalPrice: $totalPrice)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$OrderDetailsImpl &&
            (identical(other.id, id) || other.id == id) &&
            (identical(other.datePlaced, datePlaced) ||
                other.datePlaced == datePlaced) &&
            (identical(other.totalPrice, totalPrice) ||
                other.totalPrice == totalPrice));
  }

  @JsonKey(includeFromJson: false, includeToJson: false)
  @override
  int get hashCode => Object.hash(runtimeType, id, datePlaced, totalPrice);

  /// Create a copy of OrderDetails
  /// with the given fields replaced by the non-null parameter values.
  @JsonKey(includeFromJson: false, includeToJson: false)
  @override
  @pragma('vm:prefer-inline')
  _$$OrderDetailsImplCopyWith<_$OrderDetailsImpl> get copyWith =>
      __$$OrderDetailsImplCopyWithImpl<_$OrderDetailsImpl>(this, _$identity);

  @override
  Map<String, dynamic> toJson() {
    return _$$OrderDetailsImplToJson(
      this,
    );
  }
}

abstract class _OrderDetails implements OrderDetails {
  const factory _OrderDetails(
      {required final int id,
      required final DateTime datePlaced,
      final double totalPrice}) = _$OrderDetailsImpl;

  factory _OrderDetails.fromJson(Map<String, dynamic> json) =
      _$OrderDetailsImpl.fromJson;

  @override
  int get id;
  @override
  DateTime get datePlaced;
  @override
  double get totalPrice;

  /// Create a copy of OrderDetails
  /// with the given fields replaced by the non-null parameter values.
  @override
  @JsonKey(includeFromJson: false, includeToJson: false)
  _$$OrderDetailsImplCopyWith<_$OrderDetailsImpl> get copyWith =>
      throw _privateConstructorUsedError;
}
