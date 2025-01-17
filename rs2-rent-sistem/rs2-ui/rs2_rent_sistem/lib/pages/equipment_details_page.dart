import 'package:cached_network_image/cached_network_image.dart';
import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:intl/intl.dart';
import 'package:rs2_rent_sistem/shared/constants.dart';
import 'package:rs2_rent_sistem/shared/providers/equipment_providers.dart';
import 'package:rs2_rent_sistem/shared/widgets/rent_system_button.dart';

class EquipmentDetailsPage extends ConsumerStatefulWidget {
  final int equipmentId;

  const EquipmentDetailsPage(this.equipmentId, {super.key});

  @override
  ConsumerState<EquipmentDetailsPage> createState() => _EquipmentDetailsPageState();
}

class _EquipmentDetailsPageState extends ConsumerState<EquipmentDetailsPage> {
  final TextEditingController quantityTextController = TextEditingController(text: '1');
  DateTime? startDate;
  DateTime? endDate;

  Future<void> _selectStartDate(BuildContext context) async {
    final selectedDate = await showDatePicker(
      context: context,
      initialDate: startDate ?? DateTime.now(),
      firstDate: DateTime.now(),
      lastDate: DateTime.now().add(const Duration(days: 365)),
    );
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
    );
    if (selectedDate != null) {
      setState(() {
        endDate = selectedDate;
      });
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SafeArea(
        child: Padding(
          padding: const EdgeInsets.symmetric(horizontal: 20.0, vertical: 12.0),
          child: Column(
            children: [
              ref.watch(equipmentDetailsProvider(widget.equipmentId)).when(
                    data: (data) {
                      return Expanded(
                        child: SingleChildScrollView(
                          child: Column(
                            children: [
                              Text(
                                data.itemName,
                                style: Theme.of(context).textTheme.headlineSmall?.copyWith(
                                      fontWeight: FontWeight.w500,
                                      fontSize: 18,
                                    ),
                              ),
                              const SizedBox(height: 20),
                              ClipRRect(
                                borderRadius: BorderRadius.circular(12),
                                child: CachedNetworkImage(imageUrl: Constants.imageUrl),
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
                              const Text('Datum iznajmljivanja'),
                              const SizedBox(height: 10),
                              Row(
                                children: [
                                  Expanded(
                                    child: Column(
                                      crossAxisAlignment: CrossAxisAlignment.start,
                                      children: [
                                        const Text('Početni datum'),
                                        SizedBox(
                                          width: double.infinity,
                                          child: ElevatedButton(
                                            onPressed: () => _selectStartDate(context),
                                            child: Text(
                                              startDate != null
                                                  ? DateFormat('dd.MM.yyyy').format(startDate!)
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
                                      crossAxisAlignment: CrossAxisAlignment.start,
                                      children: [
                                        const Text('Završni datum'),
                                        SizedBox(
                                          width: double.infinity,
                                          child: ElevatedButton(
                                            onPressed: startDate == null ? null : () => _selectEndDate(context),
                                            child: Text(
                                              endDate != null
                                                  ? DateFormat('dd.MM.yyyy').format(endDate!)
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
                              Text(data.description),
                            ],
                          ),
                        ),
                      );
                    },
                    error: (e, st) => const Text('Detalji opreme se nisu mogli ucitati.'),
                    loading: () => const Center(child: CircularProgressIndicator()),
                  ),
              SizedBox(
                width: MediaQuery.of(context).size.width,
                child: Padding(
                  padding: const EdgeInsets.symmetric(horizontal: 12.0, vertical: 12.0),
                  child: RentSystemButton(
                    label: 'Rezervisi',
                    onTap: () {
                      if (startDate == null || endDate == null) {
                        ScaffoldMessenger.of(context).showSnackBar(
                          const SnackBar(content: Text('Molimo odaberite period iznajmljivanja.')),
                        );
                        return;
                      }

                      // Perform reservation logic here
                    },
                  ),
                ),
              ),
            ],
          ),
        ),
      ),
    );
  }

  String _calculateTotalPrice(String ctrlText, double costPerUse) {
    var price = 0.0;
    final quantity = int.tryParse(ctrlText);
    if (quantity != null) {
      price = quantity * costPerUse;
    }
    return price.toStringAsFixed(2);
  }
}
