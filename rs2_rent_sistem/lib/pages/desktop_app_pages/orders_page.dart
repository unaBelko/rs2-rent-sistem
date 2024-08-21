import 'package:flutter/material.dart';
import 'package:rs2_rent_sistem/models/order_for_admin_list_item.dart';

class OrdersPage extends StatelessWidget {
  const OrdersPage({super.key});

  @override
  Widget build(BuildContext context) {
    return SingleChildScrollView(
      child: Column(
        children: [
          const Padding(
            padding: EdgeInsets.symmetric(
              horizontal: 20.0,
              vertical: 12.0,
            ),
            child: Row(
              children: [
                Expanded(
                  flex: 1,
                  child: Text('Id'),
                ),
                Expanded(
                  flex: 1,
                  child: Text('Korisnik'),
                ),
                Expanded(
                  flex: 2,
                  child: Text('Datum kreiranja'),
                ),
                Expanded(
                  flex: 1,
                  child: Text('Cijena'),
                ),
                Expanded(
                  flex: 1,
                  child: Text('Status'),
                ),
              ],
            ),
          ),
          AdminOrderItemWidget(
            item: OrderForAdminListItem(
              id: '1',
              dateCreated: DateTime.now().toLocal(),
              userName: 'Mujo',
              userSurname: 'Hadzic',
              price: 123.5,
              status: 'placeno',
            ),
          ),
          AdminOrderItemWidget(
            item: OrderForAdminListItem(
              id: '1',
              dateCreated: DateTime.now().toLocal(),
              userName: 'Mujo',
              userSurname: 'Hadzic',
              price: 123.5,
              status: 'placeno',
            ),
          ),
          AdminOrderItemWidget(
            item: OrderForAdminListItem(
              id: '1',
              dateCreated: DateTime.now().toLocal(),
              userName: 'Mujo',
              userSurname: 'Hadzic',
              price: 123.5,
              status: 'placeno',
            ),
          ),
          AdminOrderItemWidget(
            item: OrderForAdminListItem(
              id: '1',
              dateCreated: DateTime.now().toLocal(),
              userName: 'Mujo',
              userSurname: 'Hadzic',
              price: 123.5,
              status: 'placeno',
            ),
          ),
        ],
      ),
    );
  }
}

class AdminOrderItemWidget extends StatelessWidget {
  final OrderForAdminListItem item;
  const AdminOrderItemWidget({
    super.key,
    required this.item,
  });

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
              child: Text(item.id),
            ),
            Expanded(
              flex: 1,
              child: Text('${item.userName} ${item.userSurname}'),
            ),
            Expanded(
              flex: 2,
              child: Text(item.dateCreated.toString()),
            ),
            Expanded(
              flex: 1,
              child: Text(item.price.toString()),
            ),
            Expanded(
              flex: 1,
              child: Text(item.status),
            ),
          ],
        ),
      ),
    );
  }
}
