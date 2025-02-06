import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/shared/providers/order_item_providers.dart';
import 'package:rs2_rent_sistem/shared/widgets/common_scaffold.dart';
import 'package:rs2_rent_sistem/shared/widgets/rented_equipment_in_order_widget.dart';

class OrderDetailsPage extends ConsumerWidget {
  final String orderStatus;
  final int orderId;

  const OrderDetailsPage(this.orderStatus, this.orderId, {super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    return CommonScaffold(
        title: 'Detalji narudzbe',
        child: SingleChildScrollView(
          child: ref
              .watch(orderItemsProvider(
                  (orderId: orderId, onlyActiveReservation: false)))
              .when(
                data: (data) {
                  return Column(
                    children: [
                      ...data.map((el) => RentedEquipmentInOrderWidget(
                            orderItem: el,
                            showReview: orderStatus == "returned",
                          )),
                    ],
                  );
                },
                error: (e, st) => Center(
                  child: Text('Oprema iz ove narudzbe se ne moze ucitati.'),
                ),
                loading: () => Center(
                  child: CircularProgressIndicator(),
                ),
              ),
        ));
  }
}
