import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/pages/desktop_app_pages/tab_button.dart';
import 'package:rs2_rent_sistem/pages/desktop_app_pages/user_review_widget.dart';
import 'package:rs2_rent_sistem/shared/providers/equipment_providers.dart';
import 'package:rs2_rent_sistem/shared/providers/review_providers.dart';
import 'package:rs2_rent_sistem/shared/widgets/common_scaffold.dart';
import 'package:rs2_rent_sistem/shared/widgets/delete_equipment_button.dart';
import 'package:rs2_rent_sistem/shared/widgets/text_with_label.dart';

class EquipmentDetailsAdminPage extends ConsumerStatefulWidget {
  final int equipmentId;

  const EquipmentDetailsAdminPage(this.equipmentId, {super.key});

  @override
  ConsumerState<EquipmentDetailsAdminPage> createState() =>
      _EquipmentDetailsAdminPageState();
}

class _EquipmentDetailsAdminPageState
    extends ConsumerState<EquipmentDetailsAdminPage> {
  var currentTab = 0;

  @override
  Widget build(BuildContext context) {
    final equipmentDetails =
        ref.watch(equipmentDetailsForAdminProvider(widget.equipmentId));

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
                  children: [
                    DeleteEquipmentButton(widget.equipmentId),
                  ],
                ),
                TextWithLabel(
                  label: 'Naziv opreme',
                  text: details.itemName,
                ),
                TextWithLabel(
                  label: 'Proizvodjac',
                  text: details.manufacturer,
                ),
                TextWithLabel(
                  label: 'Kategorija',
                  text: details.equipmentCategory,
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
                const SizedBox(
                  height: 20,
                ),
                Row(
                  children: [
                    TabButton(
                      text: 'Reviews',
                      isSelected: currentTab == 0,
                      onTap: () {
                        setState(() {
                          currentTab = 0;
                        });
                      },
                    ),
                    const SizedBox(
                      width: 8,
                    ),
                    TabButton(
                      text: 'Prijavljena ostecenja',
                      isSelected: currentTab == 1,
                      onTap: () {
                        setState(() {
                          currentTab = 1;
                        });
                      },
                    ),
                  ],
                ),
                currentTab == 0
                    ? Column(
                        children: [
                          const Padding(
                            padding: EdgeInsets.all(12.0),
                            child: Row(
                              children: [
                                Expanded(
                                  flex: 2,
                                  child: Text(
                                    'Rating',
                                  ),
                                ),
                                Expanded(
                                    flex: 1,
                                    child: Text(
                                      'Datum kreiranja',
                                    )),
                                Expanded(
                                  flex: 4,
                                  child: Text(
                                    'Komentar',
                                  ),
                                ),
                                Expanded(
                                  flex: 1,
                                  child: Text(
                                    'Akcija',
                                  ),
                                ),
                              ],
                            ),
                          ),
                          ref
                              .watch(reviewsProvider((
                                equipmentId: widget.equipmentId,
                                userId: null
                              )))
                              .when(
                                data: (data) => Column(
                                  children: data
                                      .map((el) => UserReviewWidget(
                                            item: el,
                                            showEquipmentName: false,
                                          ))
                                      .toList(),
                                ),
                                error: (e, st) => Text('Reviews nisu ucitani'),
                                loading: () => Center(
                                  child: CircularProgressIndicator(),
                                ),
                              ),
                        ],
                      )
                    : Column(
                        children: [],
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
