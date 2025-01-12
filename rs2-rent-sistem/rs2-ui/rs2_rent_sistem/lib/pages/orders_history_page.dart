import 'package:cached_network_image/cached_network_image.dart';
import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/models/equipment_list_item/equipment_list_item.dart';
import 'package:rs2_rent_sistem/models/order_item.dart';
import 'package:rs2_rent_sistem/shared/constants.dart';
import 'package:rs2_rent_sistem/shared/widgets/common_scaffold.dart';

class OrdersHistoryPage extends ConsumerStatefulWidget {
  const OrdersHistoryPage({super.key});

  @override
  ConsumerState<OrdersHistoryPage> createState() => _OrdersHistoryPageState();
}

class _OrdersHistoryPageState extends ConsumerState<OrdersHistoryPage> {
  @override
  Widget build(BuildContext context) {
    return CommonScaffold(
      title: 'Orders history',
      child: SingleChildScrollView(
        child: Column(
          children: [
            OrderHistoryItemWidget(
              orderItem: OrderItem(
                id: 1,
                startDate: DateTime.now(),
                endDate: DateTime.now(),
                equipment: EquipmentListItem(
                  id: 1,
                  itemName: 'Lopta za odbojkuuu',
                  imageUrl: Constants.imageUrl,
                  costPerUse: 12.00,
                ),
              ),
            ),
          ],
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
      child: Padding(
        padding: const EdgeInsets.all(12.0),
        child: Row(
          mainAxisAlignment: MainAxisAlignment.spaceBetween,
          children: [
            Column(
              children: [
                Text(
                  orderItem.equipment.itemName,
                ),
                Text(
                  orderItem.equipment.itemName,
                ),
                Text(
                  orderItem.equipment.itemName,
                ),
              ],
            ),
            Column(
              children: [
                CachedNetworkImage(
                  height: 70,
                  width: 70,
                  imageUrl: orderItem.equipment.imageUrl,
                ),
              ],
            ),
          ],
        ),
      ),
    );
  }
}
