import 'package:cached_network_image/cached_network_image.dart';
import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/models/equipment_list_item/equipment_list_item.dart';
import 'package:rs2_rent_sistem/models/order_item.dart';
import 'package:rs2_rent_sistem/shared/constants.dart';
import 'package:rs2_rent_sistem/shared/providers/order_item_providers.dart';
import 'package:rs2_rent_sistem/shared/utilities/extensions/date_extensions.dart';
import 'package:rs2_rent_sistem/shared/widgets/common_scaffold.dart';

class OrdersHistoryPage extends ConsumerWidget {
  const OrdersHistoryPage({super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    return CommonScaffold(
      title: 'Orders history',
      child: SingleChildScrollView(
        child: ref.watch(orderItemsProvider).when(
              data: (data) {
                return Column(
                  children: data
                      .map((el) => OrderHistoryItemWidget(orderItem: el))
                      .toList(),
                );
              },
              error: (e, st) => Center(
                child: Text('Historija narudzbi nije ucitana.'),
              ),
              loading: () => Center(
                child: CircularProgressIndicator(),
              ),
            ),
      ),
    );
  }
}

class OrderHistoryItemWidget extends StatelessWidget {
  final OrderItem orderItem;

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
