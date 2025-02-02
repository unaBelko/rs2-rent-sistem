import 'package:cached_network_image/cached_network_image.dart';
import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:intl/intl.dart';
import 'package:rs2_rent_sistem/models/add_to_cart_model/add_to_cart_model.dart';
import 'package:rs2_rent_sistem/pages/recommended_equipment_widget.dart';
import 'package:rs2_rent_sistem/shared/constants.dart';
import 'package:rs2_rent_sistem/shared/providers/cart_providers.dart';
import 'package:rs2_rent_sistem/shared/providers/equipment_providers.dart';
import 'package:rs2_rent_sistem/shared/widgets/common_scaffold.dart';
import 'package:rs2_rent_sistem/shared/widgets/rent_system_button.dart';

class EquipmentDetailsPage extends ConsumerStatefulWidget {
  final String equipmentName;
  final int equipmentId;

  const EquipmentDetailsPage(this.equipmentId, this.equipmentName, {super.key});

  @override
  ConsumerState<EquipmentDetailsPage> createState() =>
      _EquipmentDetailsPageState();
}

class _EquipmentDetailsPageState extends ConsumerState<EquipmentDetailsPage> {
  final TextEditingController quantityTextController =
      TextEditingController(text: '1');
  DateTime? startDate;
  DateTime? endDate;
  List<DateTime> availableDates = [];

  @override
  void initState() {
    startDate = DateTime.now();
    endDate = DateTime.now();
    super.initState();
  }

  Future<void> _selectStartDate(BuildContext context) async {
    final selectedDate = await showDatePicker(
        context: context,
        initialDate: startDate,
        firstDate: DateTime.now(),
        lastDate: DateTime.now().add(const Duration(days: 90)),
        selectableDayPredicate: (date) {
          return availableDates.any((d) =>
              d.year == date.year &&
              d.month == date.month &&
              d.day == date.day);
        },
        builder: (context, child) {
          return Theme(
            data: Theme.of(context).copyWith(
              datePickerTheme: DatePickerThemeData(
                dayBackgroundColor:
                    WidgetStateProperty.resolveWith<Color>((states) {
                  if (states.contains(WidgetState.disabled)) {
                    return Colors.red;
                  } else {
                    return Colors.green;
                  }
                }),
              ),
            ),
            child: child!,
          );
        });
    if (selectedDate != null) {
      setState(() {
        startDate = selectedDate;
        if (endDate != null && selectedDate.isAfter(endDate!)) {
          endDate = null; // Reset end date if it's before the new start date
        }
      });
    }
  }

  Future<void> _selectEndDate(BuildContext context) async {
    final selectedDate = await showDatePicker(
      context: context,
      initialDate: endDate ?? (startDate ?? DateTime.now()),
      firstDate: startDate ?? DateTime.now(),
      lastDate: DateTime.now().add(const Duration(days: 365)),
      selectableDayPredicate: (date) {
        return availableDates.any((d) =>
            d.year == date.year && d.month == date.month && d.day == date.day);
      },
      builder: (context, child) {
        return Theme(
          data: Theme.of(context).copyWith(
            datePickerTheme: DatePickerThemeData(
              dayBackgroundColor:
                  WidgetStateProperty.resolveWith<Color>((states) {
                if (states.contains(WidgetState.disabled)) {
                  return Colors.red;
                } else {
                  return Colors.green;
                }
              }),
            ),
          ),
          child: child!,
        );
      },
    );
    if (selectedDate != null) {
      setState(() {
        endDate = selectedDate;
      });
    }
  }

  @override
  Widget build(BuildContext context) {
    return CommonScaffold(
      title: widget.equipmentName,
      child: Padding(
        padding: const EdgeInsets.symmetric(horizontal: 20.0, vertical: 12.0),
        child: Column(
          children: [
            ref
                .watch(equipmentDetailsForAdminProvider(widget.equipmentId))
                .when(
                  data: (data) {
                    setState(() {
                      availableDates =
                          data.availableDates.map((el) => el.date).toList();
                    });
                    return Expanded(
                      child: SingleChildScrollView(
                        child: Column(
                          children: [
                            SizedBox(
                              height: 200,
                              child: ClipRRect(
                                borderRadius: BorderRadius.circular(12),
                                child: CachedNetworkImage(
                                    imageUrl: Constants.imageUrl),
                              ),
                            ),
                            const SizedBox(height: 20),
                            const Row(
                              children: [
                                Expanded(child: Text('Kolicina')),
                                SizedBox(width: 20),
                                Expanded(child: Text('Ukupna cijena')),
                              ],
                            ),
                            Row(
                              children: [
                                Expanded(
                                  child: TextField(
                                    controller: quantityTextController,
                                    keyboardType: TextInputType.number,
                                    onChanged: (_) => setState(() {}),
                                  ),
                                ),
                                const SizedBox(width: 20),
                                Expanded(
                                  child: Text(_calculateTotalPrice(
                                    quantityTextController.text.trim(),
                                    data.costPerUse,
                                  )),
                                ),
                              ],
                            ),
                            const SizedBox(height: 20),
                            Container(
                              padding:
                                  const EdgeInsets.symmetric(vertical: 12.0),
                              decoration: BoxDecoration(
                                border: Border(
                                  top: BorderSide(
                                      color: Colors.blueGrey.withOpacity(0.3),
                                      width: 1),
                                  bottom: BorderSide(
                                      color: Colors.blueGrey.withOpacity(0.3),
                                      width: 1),
                                ),
                              ),
                              child: Row(
                                children: [
                                  Text(data.description),
                                ],
                              ),
                            ),
                            const SizedBox(height: 20),
                            Row(
                              children: [
                                const Text('Datum iznajmljivanja'),
                              ],
                            ),
                            const SizedBox(height: 10),
                            Row(
                              children: [
                                Expanded(
                                  child: Column(
                                    crossAxisAlignment:
                                        CrossAxisAlignment.start,
                                    children: [
                                      const Text('Početni datum'),
                                      SizedBox(
                                        width: double.infinity,
                                        child: ElevatedButton(
                                          onPressed: () =>
                                              _selectStartDate(context),
                                          child: Text(
                                            startDate != null
                                                ? DateFormat('dd.MM.yyyy')
                                                    .format(startDate!)
                                                : 'Odaberite datum',
                                          ),
                                        ),
                                      ),
                                    ],
                                  ),
                                ),
                                const SizedBox(width: 20),
                                Expanded(
                                  child: Column(
                                    crossAxisAlignment:
                                        CrossAxisAlignment.start,
                                    children: [
                                      const Text('Završni datum'),
                                      SizedBox(
                                        width: double.infinity,
                                        child: ElevatedButton(
                                          onPressed: startDate == null
                                              ? null
                                              : () => _selectEndDate(context),
                                          child: Text(
                                            endDate != null
                                                ? DateFormat('dd.MM.yyyy')
                                                    .format(endDate!)
                                                : 'Odaberite datum',
                                          ),
                                        ),
                                      ),
                                    ],
                                  ),
                                ),
                              ],
                            ),
                            const SizedBox(height: 20),
                            RecommendedEquipmentWidget(
                                equipmentId: widget.equipmentId),
                          ],
                        ),
                      ),
                    );
                  },
                  error: (e, st) =>
                      const Text('Detalji opreme se nisu mogli ucitati.'),
                  loading: () =>
                      const Center(child: CircularProgressIndicator()),
                ),
            SizedBox(
              width: MediaQuery.of(context).size.width,
              child: Padding(
                padding: const EdgeInsets.symmetric(
                    horizontal: 12.0, vertical: 12.0),
                child: RentSystemButton(
                  label: 'Dodaj u korpu',
                  onTap: () {
                    if (startDate == null || endDate == null) {
                      ScaffoldMessenger.of(context).showSnackBar(
                        const SnackBar(
                            content: Text(
                                'Molimo odaberite period iznajmljivanja.')),
                      );
                      return;
                    }

                    // Check if quantity is valid
                    final quantity =
                        int.tryParse(quantityTextController.text.trim());
                    if (quantity == null || quantity <= 0) {
                      ScaffoldMessenger.of(context).showSnackBar(
                        const SnackBar(
                            content: Text('Molimo unesite validnu količinu.')),
                      );
                      return;
                    }

                    // Create AddToCartModel and call the provider
                    final addToCartModel = AddToCartModel(
                      equipmentID: widget.equipmentId,
                      quantity: quantity,
                      startDate: startDate!,
                      endDate: endDate!,
                    );

                    ref
                        .read(addToCartProvider(addToCartModel).future)
                        .then((_) {
                      // Show success message
                      ref.invalidate(cartProvider);
                      ScaffoldMessenger.of(context).showSnackBar(
                        const SnackBar(
                            content:
                                Text('Proizvod je uspješno dodan u korpu.')),
                      );
                    }).catchError((error) {
                      // Show error message
                      ScaffoldMessenger.of(context).showSnackBar(
                        SnackBar(
                            content: Text(
                                'Greška pri dodavanju u korpu: ${error.toString()}')),
                      );
                    });
                  },
                ),
              ),
            ),
          ],
        ),
      ),
    );
  }

  String _calculateTotalPrice(String ctrlText, double costPerUse) {
    if (startDate == null || endDate == null) {
      return '0.00';
    }

    final int? quantity = int.tryParse(ctrlText);
    if (quantity == null || quantity <= 0) {
      return '0.00';
    }

    final int days = endDate!.difference(startDate!).inDays + 1;
    final double price = quantity * costPerUse * days;

    return price.toStringAsFixed(2);
  }
}
