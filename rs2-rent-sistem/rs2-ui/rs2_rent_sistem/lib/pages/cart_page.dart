import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/pages/available_equipment_page.dart';
import 'package:rs2_rent_sistem/pages/order_creation_info_page.dart';
import 'package:rs2_rent_sistem/shared/providers/cart_providers.dart';
import 'package:rs2_rent_sistem/shared/widgets/common_scaffold.dart';

class CartPage extends ConsumerWidget {
  const CartPage({super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    return CommonScaffold(
      title: 'Cart',
      child: Stack(
        children: [
          SingleChildScrollView(
            padding: const EdgeInsets.only(bottom: 80.0), // Add padding to avoid overlap with the button
            child: ref.watch(cartProvider).when(
                  data: (cartInfo) => Column(
                    children: [
                      Padding(
                        padding: const EdgeInsets.symmetric(
                          horizontal: 20.0,
                          vertical: 12.0,
                        ),
                        child: Row(
                          mainAxisAlignment: MainAxisAlignment.spaceBetween,
                          children: [
                            Text(
                              'Total price:',
                              style: Theme.of(context).textTheme.bodyLarge?.copyWith(
                                    fontWeight: FontWeight.w700,
                                  ),
                            ),
                            Text(
                              cartInfo.totalPrice.toString(),
                              style: Theme.of(context).textTheme.bodyLarge?.copyWith(
                                    fontWeight: FontWeight.w700,
                                  ),
                            ),
                          ],
                        ),
                      ),
                      Column(
                        children: cartInfo.cartItems
                            .map(
                              (ci) => EquipmentCard(
                                ci.equipment,
                                isCartItem: true,
                                startDate: ci.startDate,
                                endDate: ci.endDate,
                                quantity: ci.quantity,
                              ),
                            )
                            .toList(),
                      ),
                    ],
                  ),
                  error: (err, st) => Text('Buggy cart'),
                  loading: () => const Center(
                    child: CircularProgressIndicator(),
                  ),
                ),
          ),
          Positioned(
            bottom: 0,
            left: 0,
            right: 0,
            child: Padding(
              padding: const EdgeInsets.all(16.0),
              child: ElevatedButton(
                onPressed: () {
                  ref.watch(cartProvider).whenData((cartData) {
                    if (cartData.cartItems.isNotEmpty) {
                      Navigator.of(context).push(
                        MaterialPageRoute(builder: (context) => OrderCreationInfoPage()),
                      );
                    } else {
                      ScaffoldMessenger.of(context).showSnackBar(
                        const SnackBar(
                          content: Text('Add some items to cart first!'),
                        ),
                      );
                    }
                  });
                },
                style: ElevatedButton.styleFrom(
                  padding: const EdgeInsets.symmetric(vertical: 16.0),
                ),
                child: const Text('Rent Now'),
              ),
            ),
          ),
        ],
      ),
    );
  }
}
