import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/models/simple_dropdown_item/simple_dropdown_item.dart';
import 'package:rs2_rent_sistem/shared/providers/equipment_providers.dart';
import 'package:rs2_rent_sistem/shared/providers/simple_list_management_providers.dart';
import 'package:rs2_rent_sistem/shared/utilities/enumerations.dart';
import 'package:rs2_rent_sistem/shared/widgets/common_scaffold.dart';

final selectedCategoryProvider =
    StateProvider<SimpleDropdownItem?>((ref) => null);
final selectedManufacturerProvider =
    StateProvider<SimpleDropdownItem?>((ref) => null);

class EquipmentFiltersPage extends ConsumerStatefulWidget {
  const EquipmentFiltersPage({super.key});

  @override
  ConsumerState<EquipmentFiltersPage> createState() =>
      _EquipmentFiltersPageState();
}

class _EquipmentFiltersPageState extends ConsumerState<EquipmentFiltersPage> {
  List<SimpleDropdownItem> categories = [];
  List<SimpleDropdownItem> manufacturers = [];

  SimpleDropdownItem? tempCat;
  SimpleDropdownItem? tempMan;

  @override
  void initState() {
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    setState(() {
      ref
          .watch(simpleListProvider(SimpleListType.equipmentCategory))
          .whenData((data) {
        categories = data;
      });
      ref
          .watch(simpleListProvider(SimpleListType.manufacturer))
          .whenData((data) {
        manufacturers = data;
      });
    });

    final selectedCategory = ref.watch(selectedCategoryProvider);
    final selectedManufacturer = ref.watch(selectedManufacturerProvider);

    return CommonScaffold(
      title: 'Filtriraj opremu',
      child: Padding(
        padding: const EdgeInsets.all(16),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            DropdownButtonFormField<SimpleDropdownItem>(
              value: selectedCategory,
              decoration: const InputDecoration(
                labelText: 'Kategorija opreme',
                border: OutlineInputBorder(),
              ),
              items: categories.map((category) {
                return DropdownMenuItem<SimpleDropdownItem>(
                  value: category,
                  child: Text(category.name),
                );
              }).toList(),
              onChanged: (value) {
                setState(() {
                  tempCat = value;
                });
              },
            ),
            const SizedBox(height: 16),

            // Equipment Manufacturer Dropdown
            DropdownButtonFormField<SimpleDropdownItem>(
              value: selectedManufacturer,
              decoration: const InputDecoration(
                labelText: 'Proizvođač opreme',
                border: OutlineInputBorder(),
              ),
              items: manufacturers.map((manufacturer) {
                return DropdownMenuItem<SimpleDropdownItem>(
                  value: manufacturer,
                  child: Text(manufacturer.name),
                );
              }).toList(),
              onChanged: (value) {
                setState(() {
                  tempMan = value;
                });
              },
            ),
            const SizedBox(height: 32),

            // Buttons
            Row(
              children: [
                Expanded(
                  child: ElevatedButton(
                    onPressed: () {
                      ref.read(selectedManufacturerProvider.notifier).state =
                          tempMan;
                      ref.read(selectedCategoryProvider.notifier).state =
                          tempCat;
                      if (ref.watch(selectedManufacturerProvider) != null) {
                        ref.read(equipmentFilterProvider.notifier).state =
                            ref.watch(equipmentFilterProvider).copyWith(
                                  manufacturerID: ref
                                      .watch(selectedManufacturerProvider)
                                      ?.id,
                                );
                      }
                      if (ref.watch(selectedCategoryProvider) != null) {
                        ref.read(equipmentFilterProvider.notifier).state =
                            ref.watch(equipmentFilterProvider).copyWith(
                                  equipmentCategoryID:
                                      ref.watch(selectedCategoryProvider)?.id,
                                );
                      }
                      Navigator.of(context).pop();
                    },
                    child: const Text("Primijeni filtere"),
                  ),
                ),
                const SizedBox(width: 16),
                Expanded(
                  child: OutlinedButton(
                    onPressed: () {
                      // Reset filters
                      ref.read(selectedCategoryProvider.notifier).state = null;
                      ref.read(selectedManufacturerProvider.notifier).state =
                          null;
                      ref.read(equipmentFilterProvider.notifier).state =
                          ref.watch(equipmentFilterProvider).copyWith(
                                equipmentCategoryID: null,
                                manufacturerID: null,
                              );
                      Navigator.of(context).pop();
                    },
                    child: const Text("Ocisti filtere"),
                  ),
                ),
              ],
            ),
          ],
        ),
      ),
    );
  }
}
