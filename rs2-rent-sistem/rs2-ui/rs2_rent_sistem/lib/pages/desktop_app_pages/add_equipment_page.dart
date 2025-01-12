import 'dart:io';
import 'package:flutter/material.dart';
import 'package:form_builder_file_picker/form_builder_file_picker.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/models/equipment_details_admin/equipment_details_admin.dart';
import 'package:rs2_rent_sistem/models/manufacturer/manufacturer.dart';
import 'package:rs2_rent_sistem/shared/widgets/common_scaffold.dart';
import 'package:rs2_rent_sistem/shared/widgets/generic_text_input_field.dart';
import 'package:rs2_rent_sistem/shared/widgets/rent_system_button.dart';

class AddOrEditEquipmentPage extends ConsumerStatefulWidget {
  final EquipmentDetailsAdmin? equipmentDetails;

  const AddOrEditEquipmentPage({
    super.key,
    this.equipmentDetails,
  });

  @override
  ConsumerState<ConsumerStatefulWidget> createState() => _AddOrEditEquipmentPageState();
}

class _AddOrEditEquipmentPageState extends ConsumerState<AddOrEditEquipmentPage> {
  final GlobalKey<FormState> _formKey = GlobalKey<FormState>();

  final TextEditingController _nameController = TextEditingController();
  final TextEditingController _descriptionController = TextEditingController();
  final TextEditingController _minQuantityController = TextEditingController();
  final TextEditingController _maxQuantityController = TextEditingController();
  final TextEditingController _costPerUseController = TextEditingController();
  final TextEditingController _stockQuantityController = TextEditingController();

  Manufacturer manufacturer = Manufacturer(id: "0", name: 'man1', description: "");
  File? _selectedImage;

  @override
  void initState() {
    super.initState();

    if (widget.equipmentDetails != null) {
      _nameController.text = widget.equipmentDetails?.itemName ?? '';
      _descriptionController.text = widget.equipmentDetails?.description ?? '';
      _minQuantityController.text = widget.equipmentDetails?.minQuantity.toString() ?? '0';
      _maxQuantityController.text = widget.equipmentDetails?.maxQuantity.toString() ?? '0';
      _costPerUseController.text = widget.equipmentDetails?.costPerUse.toString() ?? '0.0';
      _stockQuantityController.text = widget.equipmentDetails?.stockQuantity.toString() ?? '1';
    }

    // if (widget.equipmentDetails != null) {
    //   manufacturer = widget.equipmentDetails!.manufacturer;
    // }
  }

  @override
  void dispose() {
    // Dispose of controllers to avoid memory leaks
    _nameController.dispose();
    _descriptionController.dispose();
    _minQuantityController.dispose();
    _maxQuantityController.dispose();
    _costPerUseController.dispose();
    _stockQuantityController.dispose();
    super.dispose();
  }

  void _saveForm() {
    if (_formKey.currentState!.validate()) {
      // Trigger the onSaved callbacks
      _formKey.currentState!.save();

      // Access the saved values
      print('Name: ${_nameController.text}');
      print('Description: ${_descriptionController.text}');
      print('Min Quantity: ${_minQuantityController.text}');
      print('Max Quantity: ${_maxQuantityController.text}');
      print('Manufacturer: ${manufacturer.name}');
      print('Cost per use: ${_costPerUseController.text}');
      print('Stock quantity: ${_stockQuantityController.text}');
      print('Selected Image: ${_selectedImage?.path}');

      Navigator.of(context).pop();
    }
  }

  @override
  Widget build(BuildContext context) {
    return CommonScaffold(
      title: widget.equipmentDetails == null ? 'Dodavanje opreme' : 'Uređivanje opreme',
      child: SingleChildScrollView(
        child: Padding(
          padding: const EdgeInsets.symmetric(horizontal: 20.0, vertical: 12.0),
          child: Form(
            key: _formKey,
            child: Column(
              children: [
                GenericTextInputField(
                  label: 'Naziv opreme',
                  keyboardType: TextInputType.text,
                  controller: _nameController,
                  validator: (value) {
                    if (value == null || value.isEmpty) {
                      return 'Unesite naziv';
                    }
                    return null;
                  },
                ),
                const SizedBox(height: 12),
                GenericTextInputField(
                  label: 'Opis',
                  keyboardType: TextInputType.text,
                  controller: _descriptionController,
                  validator: (value) {
                    if (value == null || value.isEmpty) {
                      return 'Unesite opis';
                    }
                    return null;
                  },
                ),
                const SizedBox(height: 12),
                Row(
                  children: [
                    Expanded(
                      child: GenericTextInputField(
                        label: 'Minimalna količina',
                        keyboardType: TextInputType.number,
                        controller: _minQuantityController,
                        validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Unesite količinu';
                          }
                          if (num.tryParse(value) == null) {
                            return 'Unesite validan broj';
                          }
                          return null;
                        },
                      ),
                    ),
                    const SizedBox(width: 20),
                    Expanded(
                      child: GenericTextInputField(
                        label: 'Maksimalna količina',
                        keyboardType: TextInputType.number,
                        controller: _maxQuantityController,
                        validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Unesite količinu';
                          }
                          if (num.tryParse(value) == null) {
                            return 'Unesite validan broj';
                          }
                          return null;
                        },
                      ),
                    ),
                  ],
                ),
                const SizedBox(height: 12),
                DropdownButtonFormField<Manufacturer>(
                  value: manufacturer,
                  decoration: InputDecoration(
                    labelText: 'Odabir proizvođača',
                    border: OutlineInputBorder(
                      borderRadius: BorderRadius.circular(8.0),
                      borderSide: const BorderSide(
                        color: Colors.blueGrey,
                      ),
                    ),
                  ),
                  items: const [
                    DropdownMenuItem(
                      value: Manufacturer(id: "0", name: 'man1', description: ""),
                      child: Text('man 1'),
                    ),
                    DropdownMenuItem(
                      value: Manufacturer(id: "1", name: 'man2', description: ""),
                      child: Text('man 2'),
                    ),
                  ],
                  onChanged: (value) {
                    setState(() {
                      manufacturer = value!;
                    });
                  },
                ),
                const SizedBox(height: 12),
                FormBuilderFilePicker(
                  name: 'image',
                  decoration: InputDecoration(
                    labelText: 'Slika opreme',
                    border: OutlineInputBorder(
                      borderRadius: BorderRadius.circular(8.0),
                    ),
                  ),
                  maxFiles: 1,
                  previewImages: true,
                  allowMultiple: false,
                  onSaved: (images) {
                    if (images != null && images.isNotEmpty) {
                      _selectedImage = File(images.first.path!);
                    }
                  },
                ),
                const SizedBox(height: 12),
                Row(
                  children: [
                    Expanded(
                      child: GenericTextInputField(
                        label: 'Količina na stanju',
                        keyboardType: TextInputType.number,
                        controller: _stockQuantityController,
                        validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Unesite količinu';
                          }
                          if (num.tryParse(value) == null) {
                            return 'Unesite validan broj';
                          }
                          return null;
                        },
                      ),
                    ),
                    const SizedBox(width: 20),
                    Expanded(
                      child: GenericTextInputField(
                        label: 'Cijena po upotrebi',
                        keyboardType: TextInputType.number,
                        controller: _costPerUseController,
                        validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Unesite cijenu';
                          }
                          if (num.tryParse(value) == null) {
                            return 'Unesite validan broj';
                          }
                          return null;
                        },
                      ),
                    ),
                  ],
                ),
                const SizedBox(height: 12),
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
                    const SizedBox(width: 20),
                    RentSystemButton(
                      label: 'Spremi',
                      backgroundColor: Colors.green.withOpacity(0.8),
                      onTap: _saveForm,
                    ),
                  ],
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }
}
