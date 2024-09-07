import 'package:freezed_annotation/freezed_annotation.dart';
import 'package:rs2_rent_sistem/models/cart_item.dart';

part 'cart.freezed.dart';
part 'cart.g.dart';

@Freezed()
class Cart with _$Cart {
  const factory Cart({
    required int id,
    @Default(<CartItem>[]) List<CartItem> cartItems,
  }) = _Cart;

  factory Cart.fromJson(Map<String, dynamic> json) => _$CartFromJson(json);
}
