import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:intl/intl.dart';
import 'package:rs2_rent_sistem/models/order_list_item.dart';
import 'package:rs2_rent_sistem/shared/providers/order_providers.dart';

class ActiveReservationsPage extends ConsumerWidget {
  const ActiveReservationsPage({super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    return ref.watch(ordersListProvider).when(
          data: (items) => Stack(
            children: [
              SingleChildScrollView(
                child: Column(
                  children: items
                      .map(
                        (item) => ReservationItemCard(orderListItem: item),
                      )
                      .toList(),
                ),
              ),
            ],
          ),
          error: (err, st) => Text('Error: $err'),
          loading: () => const Center(
            child: CircularProgressIndicator(),
          ),
        );
  }
}

class ReservationItemCard extends StatelessWidget {
  final OrderListItem orderListItem;
  const ReservationItemCard({super.key, required this.orderListItem});

  @override
  Widget build(BuildContext context) {
    return Card(
      margin: const EdgeInsets.all(12),
      child: Row(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          Padding(
            padding: const EdgeInsets.symmetric(
              horizontal: 12.0,
              vertical: 8.0,
            ),
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Text(
                  orderListItem.id.toString(),
                  style: Theme.of(context).textTheme.headlineSmall?.copyWith(
                        fontWeight: FontWeight.w500,
                        fontStyle: FontStyle.italic,
                        fontSize: 18,
                      ),
                ),
                Text(DateFormat('dd.MM.yyyy').format(orderListItem.datePlaced.toLocal())),
                Text(
                  orderListItem.totalPrice.toString(),
                  style: Theme.of(context).textTheme.bodyMedium?.copyWith(
                        fontStyle: FontStyle.italic,
                        fontWeight: FontWeight.w500,
                      ),
                ),
              ],
            ),
          ),
        ],
      ),
    );
  }
}
