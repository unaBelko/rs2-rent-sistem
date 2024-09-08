// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'cart.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

Cart _$CartFromJson(Map<String, dynamic> json) {
  return _Cart.fromJson(json);
}

/// @nodoc
mixin _$Cart {
  int get id => throw _privateConstructorUsedError;
  List<CartItem> get cartItems => throw _privateConstructorUsedError;
  dynamic get totalPrice => throw _privateConstructorUsedError;

  Map<String, dynamic> toJson() => throw _privateConstructorUsedError;
  @JsonKey(ignore: true)
  $CartCopyWith<Cart> get copyWith => throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $CartCopyWith<$Res> {
  factory $CartCopyWith(Cart value, $Res Function(Cart) then) =
      _$CartCopyWithImpl<$Res, Cart>;
  @useResult
  $Res call({int id, List<CartItem> cartItems, dynamic totalPrice});
}

/// @nodoc
class _$CartCopyWithImpl<$Res, $Val extends Cart>
    implements $CartCopyWith<$Res> {
  _$CartCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? cartItems = null,
    Object? totalPrice = freezed,
  }) {
    return _then(_value.copyWith(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as int,
      cartItems: null == cartItems
          ? _value.cartItems
          : cartItems // ignore: cast_nullable_to_non_nullable
              as List<CartItem>,
      totalPrice: freezed == totalPrice
          ? _value.totalPrice
          : totalPrice // ignore: cast_nullable_to_non_nullable
              as dynamic,
    ) as $Val);
  }
}

/// @nodoc
abstract class _$$CartImplCopyWith<$Res> implements $CartCopyWith<$Res> {
  factory _$$CartImplCopyWith(
          _$CartImpl value, $Res Function(_$CartImpl) then) =
      __$$CartImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call({int id, List<CartItem> cartItems, dynamic totalPrice});
}

/// @nodoc
class __$$CartImplCopyWithImpl<$Res>
    extends _$CartCopyWithImpl<$Res, _$CartImpl>
    implements _$$CartImplCopyWith<$Res> {
  __$$CartImplCopyWithImpl(_$CartImpl _value, $Res Function(_$CartImpl) _then)
      : super(_value, _then);

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? cartItems = null,
    Object? totalPrice = freezed,
  }) {
    return _then(_$CartImpl(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as int,
      cartItems: null == cartItems
          ? _value._cartItems
          : cartItems // ignore: cast_nullable_to_non_nullable
              as List<CartItem>,
      totalPrice: freezed == totalPrice ? _value.totalPrice! : totalPrice,
    ));
  }
}

/// @nodoc
@JsonSerializable()
class _$CartImpl implements _Cart {
  const _$CartImpl(
      {required this.id,
      final List<CartItem> cartItems = const <CartItem>[],
      this.totalPrice = 0})
      : _cartItems = cartItems;

  factory _$CartImpl.fromJson(Map<String, dynamic> json) =>
      _$$CartImplFromJson(json);

  @override
  final int id;
  final List<CartItem> _cartItems;
  @override
  @JsonKey()
  List<CartItem> get cartItems {
    if (_cartItems is EqualUnmodifiableListView) return _cartItems;
    // ignore: implicit_dynamic_type
    return EqualUnmodifiableListView(_cartItems);
  }

  @override
  @JsonKey()
  final dynamic totalPrice;

  @override
  String toString() {
    return 'Cart(id: $id, cartItems: $cartItems, totalPrice: $totalPrice)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$CartImpl &&
            (identical(other.id, id) || other.id == id) &&
            const DeepCollectionEquality()
                .equals(other._cartItems, _cartItems) &&
            const DeepCollectionEquality()
                .equals(other.totalPrice, totalPrice));
  }

  @JsonKey(ignore: true)
  @override
  int get hashCode => Object.hash(
      runtimeType,
      id,
      const DeepCollectionEquality().hash(_cartItems),
      const DeepCollectionEquality().hash(totalPrice));

  @JsonKey(ignore: true)
  @override
  @pragma('vm:prefer-inline')
  _$$CartImplCopyWith<_$CartImpl> get copyWith =>
      __$$CartImplCopyWithImpl<_$CartImpl>(this, _$identity);

  @override
  Map<String, dynamic> toJson() {
    return _$$CartImplToJson(
      this,
    );
  }
}

abstract class _Cart implements Cart {
  const factory _Cart(
      {required final int id,
      final List<CartItem> cartItems,
      final dynamic totalPrice}) = _$CartImpl;

  factory _Cart.fromJson(Map<String, dynamic> json) = _$CartImpl.fromJson;

  @override
  int get id;
  @override
  List<CartItem> get cartItems;
  @override
  dynamic get totalPrice;
  @override
  @JsonKey(ignore: true)
  _$$CartImplCopyWith<_$CartImpl> get copyWith =>
      throw _privateConstructorUsedError;
}
