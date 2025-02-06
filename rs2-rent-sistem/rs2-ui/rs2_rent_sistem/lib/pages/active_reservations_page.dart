import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/shared/providers/order_item_providers.dart';
import 'package:rs2_rent_sistem/shared/widgets/rented_equipment_in_order_widget.dart';

class ActiveReservationsPage extends ConsumerWidget {
  const ActiveReservationsPage({super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    return SingleChildScrollView(
      child: ref
          .watch(
              orderItemsProvider((orderId: null, onlyActiveReservation: true)))
          .when(
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
                  ...data
                      .map((el) => RentedEquipmentInOrderWidget(orderItem: el)),
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
