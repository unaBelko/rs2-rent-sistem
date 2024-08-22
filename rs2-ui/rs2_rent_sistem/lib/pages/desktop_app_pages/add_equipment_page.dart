import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/models/manufacturer.dart';
import 'package:rs2_rent_sistem/shared/widgets/common_scaffold.dart';
import 'package:rs2_rent_sistem/shared/widgets/generic_text_input_field.dart';
import 'package:rs2_rent_sistem/shared/widgets/rent_system_button.dart';

class AddEquipmentPage extends ConsumerStatefulWidget {
  const AddEquipmentPage({super.key});

  @override
  ConsumerState<ConsumerStatefulWidget> createState() => _AddEquipmentPageState();
}

class _AddEquipmentPageState extends ConsumerState<AddEquipmentPage> {
  final TextEditingController _nameCtrl = TextEditingController();
  final TextEditingController _descriptionCtrl = TextEditingController();
  final TextEditingController _minQuantityCtrl = TextEditingController();
  final TextEditingController _maxQuantityCtrl = TextEditingController();
  final double _pricePerDay = 0.0;
  Manufacturer manufacturer = Manufacturer(id: "0", name: 'man1', description: ""); //todo: set to first manufacturer

  @override
  Widget build(BuildContext context) {
    return CommonScaffold(
      title: 'Dodavanje opreme',
      child: SingleChildScrollView(
        child: Padding(
          padding: const EdgeInsets.symmetric(horizontal: 20.0, vertical: 12.0),
          child: Column(
            children: [
              GenericTextInputField(
                controller: _nameCtrl,
                label: 'Naziv opreme',
                keyboardType: TextInputType.text,
                validator: (value) {
                  if (value == null || value.isEmpty) {
                    return 'Unesite naziv';
                  }
                  return null;
                },
              ),
              const SizedBox(
                height: 12,
              ),
              GenericTextInputField(
                controller: _descriptionCtrl,
                label: 'Opis',
                keyboardType: TextInputType.text,
                validator: (value) {
                  if (value == null || value.isEmpty) {
                    return 'Unesite opis';
                  }
                  return null;
                },
              ),
              const SizedBox(
                height: 12,
              ),
              Row(
                children: [
                  Expanded(
                    child: GenericTextInputField(
                      controller: _minQuantityCtrl,
                      label: 'Minimalna kolicina',
                      keyboardType: TextInputType.number,
                      validator: (value) {
                        if (value == null || value.isEmpty) {
                          return 'Unesite kolicinu';
                        }
                        return null;
                      },
                    ),
                  ),
                  const SizedBox(
                    width: 20,
                  ),
                  Expanded(
                    child: GenericTextInputField(
                      controller: _maxQuantityCtrl,
                      label: 'Maksimalna kolicina',
                      keyboardType: TextInputType.number,
                      validator: (value) {
                        if (value == null || value.isEmpty) {
                          return 'Unesite kolicinu';
                        }
                        return null;
                      },
                    ),
                  ),
                ],
              ),
              const SizedBox(
                height: 12,
              ),
              DropdownButtonFormField<Manufacturer>(
                value: manufacturer,
                decoration: InputDecoration(
                  labelText: 'Select Manufacturer',
                  border: OutlineInputBorder(
                    borderRadius: BorderRadius.circular(8.0),
                    borderSide: const BorderSide(
                      color: Colors.blueGrey,
                    ),
                  ),
                  contentPadding: const EdgeInsets.symmetric(vertical: 16.0, horizontal: 12.0),
                ),
                items: const [
                  DropdownMenuItem(
                    value: Manufacturer(id: "0", name: 'man1', description: ""),
                    child: Text(
                      'man 1',
                    ),
                  ),
                  DropdownMenuItem(
                    value: Manufacturer(id: "1", name: 'man2', description: ""),
                    child: Text(
                      'man 2',
                    ),
                  ),
                ],
                onChanged: (value) {
                  setState(() {
                    manufacturer = value!;
                  });
                },
              ),
              const SizedBox(
                height: 12,
              ),
              Row(
                mainAxisAlignment: MainAxisAlignment.end,
                children: [
                  RentSystemButton(
                    label: 'Odustani',
                    onTap: () {
                      Navigator.of(context).pop();
                    },
                    backgroundColor: Colors.red.withOpacity(0.8),
                  ),
                  const SizedBox(
                    width: 20,
                  ),
                  RentSystemButton(
                    label: 'Spremi',
                    backgroundColor: Colors.green.withOpacity(0.8),
                    onTap: () {
                      Navigator.of(context).pop();
                    },
                  ),
                ],
              ),
            ],
          ),
        ),
      ),
    );
  }
}
