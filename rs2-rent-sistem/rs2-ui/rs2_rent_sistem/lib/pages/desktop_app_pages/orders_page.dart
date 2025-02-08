import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/models/admin_order_list_item/order_list_item.dart';
import 'package:rs2_rent_sistem/shared/providers/order_providers.dart';
import 'package:rs2_rent_sistem/shared/utilities/extensions/date_extensions.dart';

class OrdersPage extends ConsumerWidget {
  const OrdersPage({super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    return SingleChildScrollView(
      child: Column(
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
                Expanded(
                  flex: 1,
                  child: Text('Akcija'),
                ),
              ],
            ),
          ),
          ref.watch(ordersListProvider(null)).when(
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
      ),
    );
  }
}

class AdminOrderItemWidget extends StatelessWidget {
  final AdminOrderListItemModel item;

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
              child: Text('${item.firstName} ${item.lastName}'),
            ),
            Expanded(
              flex: 2,
              child: Text(item.datePlaced.formatLocal()),
            ),
            Expanded(
              flex: 1,
              child: Text(item.totalPrice.toString()),
            ),
            Expanded(
              flex: 1,
              child: Text(item.status),
            ),
            Expanded(
              flex: 1,
              child: Consumer(
                builder: (context, ref, child) {
                  final updateStatus =
                      ref.watch(updateOrderStatusProvider(item.id));

                  return ElevatedButton(
                    onPressed: item.status == "returned"
                        ? null
                        : () {
                            ref
                                .read(updateOrderStatusProvider(item.id).future)
                                .then((_) {
                              ref.invalidate(ordersListProvider);
                              ScaffoldMessenger.of(context).showSnackBar(
                                const SnackBar(
                                    content: Text('Status uspješno ažuriran!')),
                              );
                              ref.invalidate(
                                  updateOrderStatusProvider); // Refresh state if needed
                            }).catchError((error) {
                              ScaffoldMessenger.of(context).showSnackBar(
                                SnackBar(content: Text('Greška: $error')),
                              );
                            });
                          },
                    child: updateStatus.isLoading
                        ? const CircularProgressIndicator()
                        : Wrap(
                            children: const [
                              Icon(Icons.arrow_right),
                              Text('Azuriraj status'),
                            ],
                          ),
                  );
                },
              ),
            ),
          ],
        ),
      ),
    );
  }
}
