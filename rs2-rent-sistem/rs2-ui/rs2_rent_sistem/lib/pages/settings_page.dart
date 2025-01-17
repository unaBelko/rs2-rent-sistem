import 'dart:developer';

import 'package:cached_network_image/cached_network_image.dart';
import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/pages/orders_history_page.dart';
import 'package:rs2_rent_sistem/shared/constants.dart';
import 'package:rs2_rent_sistem/shared/providers/user_providers.dart';
import 'package:rs2_rent_sistem/shared/widgets/rent_system_button.dart';

class SettingsPage extends ConsumerWidget {
  const SettingsPage({super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    return SafeArea(
        child: SingleChildScrollView(
      child: Column(
        children: [
          Padding(
            padding: const EdgeInsets.symmetric(
              horizontal: 20.0,
              vertical: 24.0,
            ),
            child: Row(
              children: [
                Text(
                  'Moj profil',
                  style: const TextStyle(
                    fontSize: 24,
                    fontWeight: FontWeight.w600,
                  ),
                ),
              ],
            ),
          ),
          Container(
            padding: const EdgeInsets.symmetric(
              horizontal: 16.0,
              vertical: 8.0,
            ),
            color: Colors.grey.withOpacity(0.1),
            child: Row(
              children: [
                ClipRRect(
                  borderRadius: BorderRadius.circular(50),
                  child: CircleAvatar(
                    radius: 50,
                    child: CachedNetworkImage(
                      imageUrl: Constants.imageUrl,
                    ),
                  ),
                ),
                const SizedBox(
                  width: 10,
                ),
                Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Text(
                      'Alem B',
                    ),
                    Text(
                      'alem@email.com',
                      style: TextStyle(
                        fontStyle: FontStyle.italic,
                        decoration: TextDecoration.underline,
                      ),
                    ),
                    Text(
                      'Registrovan 17.10.2022.',
                      style: TextStyle(
                        fontStyle: FontStyle.italic,
                      ),
                    ),
                  ],
                ),
              ],
            ),
          ),
          const SizedBox(
            height: 40,
          ),
          SettingsMenuItemWidget(
            title: 'Historija rezervacija',
            description: '3 rezervacije',
            onPressed: () {
              Navigator.of(context).push(MaterialPageRoute(builder: (ct) => OrdersHistoryPage()));
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
                          ref.read(authTokenProvider.notifier).state = '';
                        })),
              ],
            ),
          ),
        ],
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
