import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/models/equipment_list_item/equipment_list_item.dart'
    as EquipmentItemModel;
import 'package:rs2_rent_sistem/pages/desktop_app_pages/add_equipment_page.dart';
import 'package:rs2_rent_sistem/pages/desktop_app_pages/equipment_details_admin_page.dart';
import 'package:rs2_rent_sistem/shared/providers/equipment_providers.dart';
import 'package:rs2_rent_sistem/shared/widgets/delete_equipment_button.dart';
import 'package:rs2_rent_sistem/shared/widgets/rent_system_button.dart';

class EquipmentPage extends ConsumerWidget {
  const EquipmentPage({super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    return SingleChildScrollView(
      child: Padding(
        padding: const EdgeInsets.symmetric(horizontal: 8.0),
        child: Column(
          children: [
            Padding(
              padding: const EdgeInsets.symmetric(
                horizontal: 12.0,
                vertical: 8.0,
              ),
              child: Row(
                mainAxisAlignment: MainAxisAlignment.end,
                children: [
                  RentSystemButton(
                    label: 'Dodaj',
                    onTap: () {
                      Navigator.of(context).push(MaterialPageRoute(
                          builder: (context) =>
                              const AddOrEditEquipmentPage()));
                    },
                    icon: const Icon(
                      Icons.add,
                      color: Colors.white,
                    ),
                  ),
                ],
              ),
            ),
            const Padding(
              padding: EdgeInsets.symmetric(
                horizontal: 12.0,
                vertical: 8.0,
              ),
              child: Row(
                children: [
                  Expanded(
                    flex: 6,
                    child: Text(
                      'Naziv opreme',
                    ),
                  ),
                  Expanded(
                    flex: 1,
                    child: Text(
                      'Stanje (kol.)',
                    ),
                  ),
                  Expanded(
                    flex: 1,
                    child: Text(
                      'Cijena',
                    ),
                  ),
                  Expanded(
                    flex: 2,
                    child: Text(
                      'Akcije',
                    ),
                  ),
                ],
              ),
            ),
            const SizedBox(
              height: 12.0,
            ),
            ref.watch(equipmentListProvider).when(
                  data: (data) => Column(
                    children: data
                        .map((item) => EquipmentListItem(item: item))
                        .toList(),
                  ),
                  error: (err, st) => Text(err.toString()),
                  loading: () => Center(
                    child: CircularProgressIndicator(),
                  ),
                ),
          ],
        ),
      ),
    );
  }
}

class EquipmentListItem extends ConsumerWidget {
  final EquipmentItemModel.EquipmentListItem item;

  const EquipmentListItem({
    super.key,
    required this.item,
  });

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    return Card(
      child: Padding(
        padding: const EdgeInsets.symmetric(horizontal: 12.0),
        child: Row(
          children: [
            Expanded(
              flex: 6,
              child: Text(
                item.itemName,
              ),
            ),
            Expanded(
              flex: 1,
              child: Text(
                item.stockQuantity.toString(),
              ),
            ),
            Expanded(
              flex: 1,
              child: Text(
                item.costPerUse.toString(),
              ),
            ),
            Expanded(
              flex: 2,
              child: Row(
                children: [
                  IconButton(
                    onPressed: () {
                      ref
                          .read(
                              equipmentDetailsForAdminProvider(item.id).future)
                          .then((equipmentDetails) {
                        Navigator.of(context).push(
                          MaterialPageRoute(
                            builder: (context) => AddOrEditEquipmentPage(
                              equipment: equipmentDetails,
                            ),
                          ),
                        );
                      }).catchError((error) {
                        ScaffoldMessenger.of(context).showSnackBar(
                          SnackBar(
                              content:
                                  Text('Greška pri učitavanju opreme: $error')),
                        );
                      });
                    },
                    icon: Icon(
                      Icons.edit,
                      color: Colors.orange.shade300,
                    ),
                  ),
                  IconButton(
                    onPressed: () {
                      Navigator.of(context).push(
                        MaterialPageRoute(
                          builder: (context) =>
                              EquipmentDetailsAdminPage(item.id),
                        ),
                      );
                    },
                    icon: Icon(
                      Icons.info,
                      color: Colors.lightBlue.withOpacity(0.5),
                    ),
                  ),
                  DeleteEquipmentButton(item.id),
                ],
              ),
            ),
          ],
        ),
      ),
    );
  }
}
