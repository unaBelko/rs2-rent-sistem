import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/shared/widgets/common_scaffold.dart';
import 'package:rs2_rent_sistem/shared/widgets/delete_equipment_button.dart';
import 'package:rs2_rent_sistem/shared/widgets/text_with_label.dart';

class EquipmentDetailsAdminPage extends ConsumerWidget {
  const EquipmentDetailsAdminPage({super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    return const CommonScaffold(
      title: "Detalji opreme",
      child: SingleChildScrollView(
        child: Padding(
          padding: EdgeInsets.all(20.0),
          child: Column(
            children: [
              Row(
                mainAxisAlignment: MainAxisAlignment.end,
                children: [
                  DeleteEquipmentButton(),
                ],
              ),
              TextWithLabel(
                label: 'Naziv opreme',
                text: 'Lopta za odbojku',
              ),
              TextWithLabel(
                label: 'Proizvodjac',
                text: 'Adidas',
              ),
              TextWithLabel(
                label: 'Minimalna kolicina',
                text: '2',
              ),
              TextWithLabel(
                label: 'Maksimalna kolicina',
                text: '10',
              ),
              TextWithLabel(
                label: 'Cijena po upotrebi',
                text: '10.00',
              ),
              TextWithLabel(
                label: 'Stanje',
                text: '24',
              ),
              TextWithLabel(
                label: 'Opis',
                text: 'It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using Content here, content here, making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for lorem ipsum will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).',
              ),
            ],
          ),
        ),
      ),
    );
  }
}
