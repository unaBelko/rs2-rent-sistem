import 'package:flutter/material.dart';
import 'package:rs2_rent_sistem/models/admin_order_list_item/order_list_item.dart';
import 'package:rs2_rent_sistem/shared/utilities/extensions/date_extensions.dart';

class UserOrderListItemWidget extends StatelessWidget {
  final AdminOrderListItemModel item;

  const UserOrderListItemWidget({super.key, required this.item});

  @override
  Widget build(BuildContext context) {
    return Card(
      child: Padding(
        padding: const EdgeInsets.symmetric(
          horizontal: 12.0,
          vertical: 10,
        ),
        child: Row(
          children: [
            Expanded(
              flex: 1,
              child: Text(
                item.id.toString(),
              ),
            ),
            Expanded(
                flex: 3,
                child: Text(
                  item.datePlaced.formatLocal(),
                )),
            Expanded(
              flex: 1,
              child: Text(
                item.orderItems.length.toString(),
              ),
            ),
            Expanded(
              flex: 1,
              child: Text(
                item.totalPrice.toString(),
              ),
            ),
            Expanded(
              flex: 1,
              child: Text(
                item.status,
              ),
            ),
          ],
        ),
      ),
    );
  }
}