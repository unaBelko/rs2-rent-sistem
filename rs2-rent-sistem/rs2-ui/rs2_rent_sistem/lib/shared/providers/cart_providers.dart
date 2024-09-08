import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/models/cart.dart';
import 'package:rs2_rent_sistem/shared/api_services/cart_service.dart';

final cartProvider = FutureProvider<Cart>((ref) async {
  final response = await CartService().getCart();

  if (response.isSuccess && response.data != null) {
    return response.data!;
  } else {
    throw Exception(response.error);
  }
});
