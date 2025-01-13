import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/shared/providers/equipment_providers.dart';
import 'package:rs2_rent_sistem/shared/widgets/common_scaffold.dart';
import 'package:rs2_rent_sistem/shared/widgets/delete_equipment_button.dart';
import 'package:rs2_rent_sistem/shared/widgets/text_with_label.dart';

class EquipmentDetailsAdminPage extends ConsumerWidget {
  final int equipmentId;

  const EquipmentDetailsAdminPage(this.equipmentId, {super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    final equipmentDetails = ref.watch(equipmentDetailsProvider(equipmentId));

    return CommonScaffold(
      title: "Detalji opreme",
      child: equipmentDetails.when(
        data: (details) => SingleChildScrollView(
          child: Padding(
            padding: const EdgeInsets.all(20.0),
            child: Column(
              children: [
                Row(
                  mainAxisAlignment: MainAxisAlignment.end,
                  children: const [
                    DeleteEquipmentButton(),
                  ],
                ),
                TextWithLabel(
                  label: 'Naziv opreme',
                  text: details.itemName,
                ),
                TextWithLabel(
                  label: 'Proizvodjac',
                  text: details.manufacturerID.toString(),
                ),
                TextWithLabel(
                  label: 'Minimalna kolicina',
                  text: details.minQuantity.toString(),
                ),
                TextWithLabel(
                  label: 'Maksimalna kolicina',
                  text: details.maxQuantity.toString(),
                ),
                TextWithLabel(
                  label: 'Cijena po upotrebi',
                  text: details.costPerUse.toStringAsFixed(2),
                ),
                TextWithLabel(
                  label: 'Stanje',
                  text: details.stockQuantity.toString(),
                ),
                TextWithLabel(
                  label: 'Opis',
                  text: details.description,
                ),
              ],
            ),
          ),
        ),
        error: (error, stackTrace) => Center(
          child: Text('Greška: $error'),
        ),
        loading: () => const Center(
          child: CircularProgressIndicator(),
        ),
      ),
    );
  }
}
