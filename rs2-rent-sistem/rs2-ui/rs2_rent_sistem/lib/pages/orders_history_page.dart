import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/models/admin_order_list_item/order_list_item.dart';
import 'package:rs2_rent_sistem/shared/providers/order_providers.dart';
import 'package:rs2_rent_sistem/shared/utilities/extensions/date_extensions.dart';
import 'package:rs2_rent_sistem/shared/widgets/common_scaffold.dart';

class OrdersHistoryPage extends ConsumerWidget {
  const OrdersHistoryPage({super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    return CommonScaffold(
      title: 'Historija narudzbi',
      child: ref.watch(ordersListProvider(null)).when(
            data: (items) => Stack(
              children: [
                SingleChildScrollView(
                  child: Column(
                    children: items
                        .map(
                          (item) => OrderMobileCard(orderListItem: item),
                        )
                        .toList(),
                  ),
                ),
              ],
            ),
            error: (err, st) => Text('Narudzbe nisu ucitane.'),
            loading: () => const Center(
              child: CircularProgressIndicator(),
            ),
          ),
    );
  }
}

class OrderMobileCard extends StatelessWidget {
  final AdminOrderListItemModel orderListItem;

  const OrderMobileCard({super.key, required this.orderListItem});

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
                  'Narudzba #${orderListItem.id}',
                  style: Theme.of(context).textTheme.headlineSmall?.copyWith(
                        fontWeight: FontWeight.w500,
                        fontStyle: FontStyle.italic,
                        fontSize: 18,
                      ),
                ),
                Text(
                    'Datum kreiranja: ${orderListItem.datePlaced.formatLocal()}'),
                Text(
                  'Ukupna cijena: ${orderListItem.totalPrice}',
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
