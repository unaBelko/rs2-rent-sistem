import 'package:flutter/material.dart';
import 'package:rs2_rent_sistem/models/equipment_list_item.dart' as EquipmentItemModel;
import 'package:rs2_rent_sistem/pages/desktop_app_pages/add_equipment_page.dart';
import 'package:rs2_rent_sistem/pages/desktop_app_pages/equipment_details_admin_page.dart';
import 'package:rs2_rent_sistem/shared/constants.dart';
import 'package:rs2_rent_sistem/shared/widgets/delete_equipment_button.dart';
import 'package:rs2_rent_sistem/shared/widgets/rent_system_button.dart';

class EquipmentPage extends StatelessWidget {
  const EquipmentPage({super.key});

  @override
  Widget build(BuildContext context) {
    return SingleChildScrollView(
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
                    Navigator.of(context).push(MaterialPageRoute(builder: (context) => const AddEquipmentPage()));
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
          const EquipmentListItem(
            item: EquipmentItemModel.EquipmentListItem(
              id: 1,
              imageUrl: Constants.imageUrl,
              itemName: "Loptaa",
              manufacturer: "Nikee",
              rating: 3.6,
              numberOfReviews: 19,
              costPerUse: 20.00,
            ),
          ),
          const EquipmentListItem(
            item: EquipmentItemModel.EquipmentListItem(
              id: 1,
              imageUrl: Constants.imageUrl,
              itemName: "Loptaa",
              manufacturer: "Nikee",
              rating: 3.6,
              numberOfReviews: 19,
              costPerUse: 20.00,
            ),
          ),
        ],
      ),
    );
  }
}

class EquipmentListItem extends StatelessWidget {
  final EquipmentItemModel.EquipmentListItem item;
  const EquipmentListItem({
    super.key,
    required this.item,
  });

  @override
  Widget build(BuildContext context) {
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
            const Expanded(
              flex: 1,
              child: Text(
                'temp 20',
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
                    onPressed: () {},
                    icon: Icon(
                      Icons.edit,
                      color: Colors.orange.shade300,
                    ),
                  ),
                  IconButton(
                    onPressed: () {
                      Navigator.of(context).push(
                        MaterialPageRoute(
                          builder: (context) => const EquipmentDetailsAdminPage(),
                        ),
                      );
                    },
                    icon: Icon(
                      Icons.info,
                      color: Colors.lightBlue.withOpacity(0.5),
                    ),
                  ),
                  const DeleteEquipmentButton(),
                ],
              ),
            ),
          ],
        ),
      ),
    );
  }
}
