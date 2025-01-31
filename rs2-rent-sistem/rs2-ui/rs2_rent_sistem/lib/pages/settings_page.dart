import 'dart:developer';

import 'package:cached_network_image/cached_network_image.dart';
import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/pages/orders_history_page.dart';
import 'package:rs2_rent_sistem/shared/constants.dart';
import 'package:rs2_rent_sistem/shared/providers/cart_providers.dart';
import 'package:rs2_rent_sistem/shared/providers/order_providers.dart';
import 'package:rs2_rent_sistem/shared/providers/simple_state_providers.dart';
import 'package:rs2_rent_sistem/shared/providers/user_providers.dart';
import 'package:rs2_rent_sistem/shared/utilities/secure_storage_handler.dart';
import 'package:rs2_rent_sistem/shared/widgets/rent_system_button.dart';

class SettingsPage extends ConsumerWidget {
  const SettingsPage({super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    return SafeArea(
        child: SingleChildScrollView(
      child: ref.watch(userDetailsProvider(null)).when(
            data: (data) {
              return Column(
                children: [
                  Row(
                    children: [
                      Expanded(
                        child: Container(
                          padding: const EdgeInsets.symmetric(
                            horizontal: 16.0,
                            vertical: 8.0,
                          ),
                          color: Colors.grey.withOpacity(0.1),
                          child: Column(
                            crossAxisAlignment: CrossAxisAlignment.start,
                            children: [
                              Text(
                                '${data.firstName} ${data.lastName}',
                              ),
                              const SizedBox(
                                height: 20,
                              ),
                              Text(
                                data.email,
                                style: TextStyle(
                                  fontStyle: FontStyle.italic,
                                  decoration: TextDecoration.underline,
                                ),
                              ),
                            ],
                          ),
                        ),
                      ),
                    ],
                  ),
                  const SizedBox(
                    height: 40,
                  ),
                  SettingsMenuItemWidget(
                    title: 'Historija rezervacija',
                    description: 'Pregled rezervisane opreme',
                    onPressed: () {
                      Navigator.of(context).push(MaterialPageRoute(
                          builder: (ct) => OrdersHistoryPage()));
                    },
                  ),
                  SettingsMenuItemWidget(
                    title: 'Postavke',
                    description: 'Lozinka',
                    onPressed: () {
                      log('pressed');
                    },
                    isLastItem: false,
                  ),
                  Padding(
                    padding: const EdgeInsets.symmetric(
                      horizontal: 20.0,
                      vertical: 30.0,
                    ),
                    child: Row(
                      children: [
                        Expanded(
                            child: RentSystemButton(
                                label: 'ODJAVA',
                                onTap: () {
                                  ref
                                      .read(navigationIndexProvider.notifier)
                                      .state = 0;
                                  ref.invalidate(ordersListProvider);
                                  ref.invalidate(cartProvider);
                                  SecureStorageHandler.token = '';
                                  ref.read(authTokenProvider.notifier).state =
                                      null;
                                })),
                      ],
                    ),
                  ),
                ],
              );
            },
            error: (e, st) => Text('Korisnik nije ucitan.'),
            loading: () => Center(
              child: CircularProgressIndicator(),
            ),
          ),
    ));
  }
}

class SettingsMenuItemWidget extends StatelessWidget {
  final String title;
  final String description;
  final VoidCallback onPressed; // Use VoidCallback instead of Function
  final bool isLastItem;

  const SettingsMenuItemWidget({
    super.key,
    required this.title,
    required this.description,
    required this.onPressed,
    this.isLastItem = false,
  });

  @override
  Widget build(BuildContext context) {
    return GestureDetector(
      onTap: () {
        onPressed(); // Correctly invoke the onPressed function
      },
      child: Container(
        padding: const EdgeInsets.symmetric(
          vertical: 12,
          horizontal: 16,
        ),
        decoration: !isLastItem
            ? BoxDecoration(
                border: Border(
                  bottom: BorderSide(
                    color: Colors.grey.withOpacity(0.4),
                  ),
                ),
              )
            : null,
        child: Row(
          mainAxisAlignment: MainAxisAlignment.spaceBetween,
          children: [
            Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Text(
                  title,
                  style: const TextStyle(
                    fontSize: 16,
                  ),
                ),
                Text(
                  description,
                  style: const TextStyle(
                    fontSize: 11,
                    color: Colors.grey,
                  ),
                ),
              ],
            ),
            const Icon(
              Icons.chevron_right,
              color: Colors.black12,
            ),
          ],
        ),
      ),
    );
  }
}
