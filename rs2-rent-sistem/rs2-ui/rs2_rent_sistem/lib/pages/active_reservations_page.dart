import 'package:cached_network_image/cached_network_image.dart';
import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/models/item_in_order/order_item.dart';
import 'package:rs2_rent_sistem/shared/providers/order_item_providers.dart';
import 'package:rs2_rent_sistem/shared/utilities/extensions/date_extensions.dart';

class ActiveReservationsPage extends ConsumerWidget {
  const ActiveReservationsPage({super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    return SingleChildScrollView(
      child: ref.watch(orderItemsProvider).when(
            data: (data) {
              return Column(
                children: [
                  Container(
                    padding: const EdgeInsets.symmetric(vertical: 12),
                    width: double.infinity,
                    color: Colors.green.withOpacity(0.2),
                    child: Text(
                      data.isEmpty
                          ? 'Trenutno nemate aktivnih rezervacija! '
                          : 'Trenutno imate sljedeci broj rezervisanih stavki: ${data.length}.\nUzivajte u planiranim aktivnostima!',
                      textAlign: TextAlign.center,
                    ),
                  ),
                  ...data.map((el) => OrderHistoryItemWidget(orderItem: el)),
                ],
              );
            },
            error: (e, st) => Center(
              child: Text('Aktivne rezervacije nisu ucitane.'),
            ),
            loading: () => Center(
              child: CircularProgressIndicator(),
            ),
          ),
    );
  }
}

class OrderHistoryItemWidget extends StatelessWidget {
  final ItemInOrder orderItem;

  const OrderHistoryItemWidget({
    super.key,
    required this.orderItem,
  });

  @override
  Widget build(BuildContext context) {
    return Card(
      margin: const EdgeInsets.symmetric(horizontal: 12.0, vertical: 4.0),
      child: Padding(
        padding: const EdgeInsets.all(12.0),
        child: Column(
          children: [
            Row(
              mainAxisAlignment: MainAxisAlignment.spaceBetween,
              children: [
                Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Text(
                      orderItem.equipment.itemName,
                      style: TextStyle(
                        fontWeight: FontWeight.w600,
                        fontSize: 15,
                      ),
                    ),
                    Text(
                      'Cijena/dan: ${orderItem.costPerUse}',
                    ),
                    Text(
                      'Kolicina: ${orderItem.quantity}',
                    ),
                    Text(
                      '${orderItem.startDate.formatLocal()} - ${orderItem.endDate.formatLocal()}',
                    ),
                  ],
                ),
                CachedNetworkImage(
                  height: 70,
                  width: 70,
                  imageUrl: orderItem.equipment.imageUrl,
                  errorWidget: (_, __, ___) => Icon(Icons.warning_rounded),
                ),
              ],
            ),
            Row(
              mainAxisAlignment: MainAxisAlignment.spaceBetween,
              children: [
                Text(
                  'placeholder',
                  style: TextStyle(
                    fontWeight: FontWeight.w600,
                  ),
                ),
                Text(
                  orderItem.price.toString(),
                  style: TextStyle(
                    fontWeight: FontWeight.w600,
                  ),
                ),
              ],
            )
          ],
        ),
      ),
    );
  }
}
