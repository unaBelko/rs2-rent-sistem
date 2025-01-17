import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/models/add_to_cart_model/add_to_cart_model.dart';
import 'package:rs2_rent_sistem/models/cart/cart.dart';
import 'package:rs2_rent_sistem/shared/api_services/cart_service.dart';

final cartProvider = FutureProvider<Cart>((ref) async {
  final response = await CartService().getCart();

  if (response.isSuccess && response.data != null) {
    return response.data!;
  } else {
    throw Exception(response.error);
  }
});

final addToCartProvider = FutureProvider.family<void, AddToCartModel>((ref, AddToCartModel params) async {
  final response = await CartService().addItemToCart(params);

  if (!response.isSuccess) {
    throw Exception(response.error);
  }
});

final removeFromCartProvider = FutureProvider.family<void, int>((ref, int params) async {
  final response = await CartService().removeItemFromCart(params);

  if (!response.isSuccess) {
    throw Exception(response.error);
  }
});
