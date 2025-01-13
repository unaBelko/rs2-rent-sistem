import 'dart:developer';

import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/models/simple_dropdown_item/simple_dropdown_item.dart';
import 'package:rs2_rent_sistem/pages/desktop_app_pages/add_edit_manufacturer_page.dart';
import 'package:rs2_rent_sistem/shared/providers/equipment_categories_providers.dart';
import 'package:rs2_rent_sistem/shared/providers/manufacturers_providers.dart';
import 'package:rs2_rent_sistem/shared/utilities/enumerations.dart';
import 'package:rs2_rent_sistem/shared/widgets/confirmation_modal.dart';
import 'package:rs2_rent_sistem/shared/widgets/rent_system_button.dart';

class SimpleListManagementPage extends ConsumerStatefulWidget {
  final SimpleListType listType;

  const SimpleListManagementPage(this.listType, {super.key});

  @override
  ConsumerState<SimpleListManagementPage> createState() => _SimpleListManagementPageState();
}

class _SimpleListManagementPageState extends ConsumerState<SimpleListManagementPage> {
  @override
  Widget build(BuildContext context) {
    return SingleChildScrollView(
      child: Column(
        children: [
          Padding(
            padding: const EdgeInsets.all(8.0),
            child: Row(
              mainAxisAlignment: MainAxisAlignment.end,
              children: [
                RentSystemButton(
                  label: 'Dodaj',
                  onTap: () {
                    Navigator.of(context).push(
                      MaterialPageRoute(
                        builder: (context) => const AddOrEditManufacturerPage(),
                      ),
                    );
                  },
                  icon: const Icon(
                    Icons.add,
                    color: Colors.white,
                  ),
                ),
              ],
            ),
          ),
          Padding(
            padding: const EdgeInsets.symmetric(
              horizontal: 20.0,
              vertical: 8.0,
            ),
            child: Row(
              children: [
                Expanded(
                  flex: 1,
                  child: Text(
                    'ID',
                  ),
                ),
                Expanded(
                  flex: 2,
                  child: Text('Naziv'),
                ),
                Expanded(
                  flex: 5,
                  child: Text('Opis'),
                ),
                Expanded(
                  flex: 2,
                  child: Text('Akcije'),
                ),
              ],
            ),
          ),
          if (widget.listType == SimpleListType.manufacturer)
            ref.watch(manufacturersListProvider).when(
                  data: (items) => Column(
                    children: items.map((item) => ManufacturerListItem(item: item)).toList(),
                  ),
                  error: (err, st) => Text('Error: $err'),
                  loading: () => const Center(
                    child: CircularProgressIndicator(),
                  ),
                ),
          if (widget.listType == SimpleListType.equipmentCategory)
            ref.watch(equipmentCategoryListProvider).when(
                  data: (items) => Column(
                    children: items.map((item) => ManufacturerListItem(item: item)).toList(),
                  ),
                  error: (err, st) => Text('Error: $err'),
                  loading: () => const Center(
                    child: CircularProgressIndicator(),
                  ),
                ),
        ],
      ),
    );
  }
}

class ManufacturerListItem extends StatelessWidget {
  final SimpleDropdownItem item;

  const ManufacturerListItem({super.key, required this.item});

  @override
  Widget build(BuildContext context) {
    return Card(
      child: Padding(
        padding: const EdgeInsets.symmetric(horizontal: 20.0, vertical: 8.0),
        child: Row(
          children: [
            Expanded(
              flex: 1,
              child: Text(
                item.id.toString(),
              ),
            ),
            Expanded(
              flex: 2,
              child: Text(item.name),
            ),
            Expanded(
              flex: 5,
              child: Text(item.description),
            ),
            Expanded(
              flex: 2,
              child: Row(
                children: [
                  IconButton(
                    onPressed: () {
                      showDialog(
                          context: context,
                          builder: (context) => ConfirmationModal(
                                title: 'Deaktivacija proizvođača',
                                content:
                                    "Da li ste sigurni da zelite deaktivirati ovog proizvođača? Brisanjem ćete ukloniti ovog proizvođača kao opciju kod kreiranja novog proizvoda.",
                                buttonText: "Deaktiviraj",
                                onConfirm: () {
                                  log("izbrisan");
                                },
                                isDestructiveAction: true,
                              ));
                    },
                    icon: const Icon(
                      Icons.dangerous,
                      color: Colors.red,
                    ),
                  ),
                  IconButton(
                    onPressed: () {
                      Navigator.of(context).push(
                        MaterialPageRoute(
                          builder: (context) => AddOrEditManufacturerPage(item: item),
                        ),
                      );
                    },
                    icon: Icon(
                      Icons.edit,
                    ),
                  ),
                ],
              ),
            ),
          ],
        ),
      ),
    );
  }
}
