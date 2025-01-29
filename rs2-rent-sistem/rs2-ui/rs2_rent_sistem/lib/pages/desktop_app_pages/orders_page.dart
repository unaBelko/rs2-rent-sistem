import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/models/order_list_item.dart';
import 'package:rs2_rent_sistem/shared/providers/order_providers.dart';

class OrdersPage extends ConsumerWidget {
  const OrdersPage({super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    return Column(
      children: [
        Padding(
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
        ref.watch(ordersListProvider).when(
              data: (data) => SingleChildScrollView(
                child: Column(
                  children: data
                      .map((item) => AdminOrderItemWidget(item: item))
                      .toList(),
                ),
              ),
              error: (e, st) => Text('Narudzbe se trenutno ne mogu ucitati.'),
              loading: () => Center(
                child: CircularProgressIndicator(),
              ),
            ),
      ],
    );
  }
}

class AdminOrderItemWidget extends StatelessWidget {
  final OrderListItem item;

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
              child: Text(item.id.toString()),
            ),
            Expanded(
              flex: 1,
              child: Text(item.userNameSurname),
            ),
            Expanded(
              flex: 2,
              child: Text(item.datePlaced.toString()),
            ),
            Expanded(
              flex: 1,
              child: Text(item.totalPrice.toString()),
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
