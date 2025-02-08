import 'dart:convert';
import 'dart:io';
import 'package:flutter/material.dart';
import 'package:form_builder_file_picker/form_builder_file_picker.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/models/equipment_creation_model/equipment_creation_model.dart';
import 'package:rs2_rent_sistem/models/equipment_details_admin/equipment_details_admin.dart';
import 'package:rs2_rent_sistem/models/simple_dropdown_item/simple_dropdown_item.dart';
import 'package:rs2_rent_sistem/shared/providers/equipment_providers.dart';
import 'package:rs2_rent_sistem/shared/providers/simple_list_management_providers.dart';
import 'package:rs2_rent_sistem/shared/utilities/enumerations.dart';
import 'package:rs2_rent_sistem/shared/widgets/common_scaffold.dart';
import 'package:rs2_rent_sistem/shared/widgets/generic_text_input_field.dart';
import 'package:rs2_rent_sistem/shared/widgets/rent_system_button.dart';

class AddOrEditEquipmentPage extends ConsumerStatefulWidget {
  final EquipmentDetailsAdmin? equipment;

  const AddOrEditEquipmentPage({super.key, this.equipment});

  @override
  ConsumerState<AddOrEditEquipmentPage> createState() =>
      _AddOrEditEquipmentPageState();
}

class _AddOrEditEquipmentPageState
    extends ConsumerState<AddOrEditEquipmentPage> {
  final GlobalKey<FormState> _formKey = GlobalKey<FormState>();

  final TextEditingController _nameController = TextEditingController();
  final TextEditingController _descriptionController = TextEditingController();
  final TextEditingController _minQuantityController = TextEditingController();
  final TextEditingController _maxQuantityController = TextEditingController();
  final TextEditingController _costPerUseController = TextEditingController();
  final TextEditingController _stockQuantityController =
      TextEditingController();

  SimpleDropdownItem? selectedCategory;
  SimpleDropdownItem? selectedManufacturer;
  File? _selectedImage;
  String? _photoBase64;

  @override
  void initState() {
    super.initState();

    if (widget.equipment != null) {
      setState(() {
        _nameController.text = widget.equipment!.itemName;
        _descriptionController.text = widget.equipment!.description;
        _minQuantityController.text = widget.equipment!.minQuantity.toString();
        _maxQuantityController.text = widget.equipment!.maxQuantity.toString();
        _costPerUseController.text = widget.equipment!.costPerUse.toString();
        _stockQuantityController.text =
            widget.equipment!.stockQuantity.toString();
        // selectedCategory = SimpleDropdownItem(
        //   id: widget.equipment!.equipmentCategoryID,
        //   name: 'test',
        // );
        // selectedManufacturer = SimpleDropdownItem(
        //   id: widget.equipment!.manufacturerID,
        //   name: 'testt',
        // );
      });
    }
  }

  @override
  void dispose() {
    _nameController.dispose();
    _descriptionController.dispose();
    _minQuantityController.dispose();
    _maxQuantityController.dispose();
    _costPerUseController.dispose();
    _stockQuantityController.dispose();
    super.dispose();
  }

  Future<void> _convertImageToBase64(File image) async {
    List<int> imageBytes = await image.readAsBytes();
    setState(() {
      _photoBase64 = base64Encode(imageBytes);
    });
  }

  void _onImageSelected(List<PlatformFile>? files) {
    if (files != null && files.isNotEmpty) {
      setState(() {
        _selectedImage = File(files.first.path!);
      });

      _convertImageToBase64(_selectedImage!);
    }
  }

  void _saveForm() {
    if (_formKey.currentState!.validate()) {
      _formKey.currentState!.save();

      EquipmentCreationModel equipmentModel = EquipmentCreationModel(
        itemName: _nameController.text,
        costPerUse: double.parse(_costPerUseController.text),
        dateAdded: DateTime.now(),
        equipmentCategoryID: selectedCategory!.id,
        manufacturerID: selectedManufacturer!.id,
        photoBase64: _photoBase64 ?? "",
        stockQuantity: int.parse(_stockQuantityController.text),
        minQuantity: int.parse(_minQuantityController.text),
        maxQuantity: int.parse(_maxQuantityController.text),
        description: _descriptionController.text,
      );

      if (widget.equipment == null) {
        ref.read(addEquipmentProvider(equipmentModel).future).then((_) {
          ScaffoldMessenger.of(context).showSnackBar(
            const SnackBar(content: Text('Oprema uspješno dodana!')),
          );
          ref.invalidate(equipmentListProvider);
          Navigator.pop(context);
        }).catchError((error) {
          ref.invalidate(equipmentListProvider);
          ScaffoldMessenger.of(context).showSnackBar(
            SnackBar(content: Text('Greška prilikom dodavanja: $error')),
          );
        });
      } else {
        ref.read(editEquipmentProvider(equipmentModel).future).then((_) {
          ScaffoldMessenger.of(context).showSnackBar(
            const SnackBar(content: Text('Oprema uspješno ažurirana!')),
          );
          Navigator.pop(context);
        }).catchError((error) {
          ScaffoldMessenger.of(context).showSnackBar(
            SnackBar(content: Text('Greška prilikom ažuriranja: $error')),
          );
        });
      }
    }
  }

  @override
  Widget build(BuildContext context) {
    final categoryList =
        ref.watch(simpleListProvider(SimpleListType.equipmentCategory));
    final manufacturerList =
        ref.watch(simpleListProvider(SimpleListType.manufacturer));

    return CommonScaffold(
      showX: true,
      title:
          widget.equipment == null ? 'Dodavanje opreme' : 'Uređivanje opreme',
      child: SingleChildScrollView(
        padding: const EdgeInsets.symmetric(horizontal: 20.0, vertical: 12.0),
        child: Form(
          key: _formKey,
          child: Row(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              // First Column: Input Fields
              Expanded(
                flex: 3,
                child: Column(
                  children: [
                    GenericTextInputField(
                        label: 'Naziv opreme', controller: _nameController),
                    const SizedBox(
                      height: 12,
                    ),
                    GenericTextInputField(
                        label: 'Opis', controller: _descriptionController),
                    categoryList.when(
                      data: (categories) =>
                          DropdownButtonFormField<SimpleDropdownItem>(
                        value: selectedCategory,
                        decoration: const InputDecoration(
                            labelText: 'Odabir kategorije'),
                        items: categories.map((category) {
                          return DropdownMenuItem(
                              value: category, child: Text(category.name));
                        }).toList(),
                        onChanged: (value) =>
                            setState(() => selectedCategory = value),
                      ),
                      loading: () => const CircularProgressIndicator(),
                      error: (_, __) =>
                          const Text('Greška pri učitavanju kategorija'),
                    ),
                    manufacturerList.when(
                      data: (manufacturers) =>
                          DropdownButtonFormField<SimpleDropdownItem>(
                        value: selectedManufacturer,
                        decoration: const InputDecoration(
                            labelText: 'Odabir proizvođača'),
                        items: manufacturers.map((manufacturer) {
                          return DropdownMenuItem(
                              value: manufacturer,
                              child: Text(manufacturer.name));
                        }).toList(),
                        onChanged: (value) =>
                            setState(() => selectedManufacturer = value),
                      ),
                      loading: () => const CircularProgressIndicator(),
                      error: (_, __) =>
                          const Text('Greška pri učitavanju proizvođača'),
                    ),
                    const SizedBox(
                      height: 12,
                    ),
                    GenericTextInputField(
                      label: 'Količina na stanju',
                      controller: _stockQuantityController,
                      minLength: 1,
                    ),
                    const SizedBox(
                      height: 12,
                    ),
                    GenericTextInputField(
                      label: 'Minimalna količina',
                      controller: _minQuantityController,
                      minLength: 1,
                    ),
                    const SizedBox(
                      height: 12,
                    ),
                    GenericTextInputField(
                      label: 'Maksimalna količina',
                      controller: _maxQuantityController,
                      minLength: 1,
                    ),
                    const SizedBox(
                      height: 12,
                    ),
                    GenericTextInputField(
                      label: 'Cijena po upotrebi',
                      controller: _costPerUseController,
                      minLength: 1,
                    ),
                  ],
                ),
              ),
              const SizedBox(width: 20),
              // Second Column: Image Picker
              Expanded(
                flex: 2,
                child: Column(
                  children: [
                    const Text('Slika opreme',
                        style: TextStyle(fontWeight: FontWeight.bold)),
                    FormBuilderFilePicker(
                      name: 'image',
                      maxFiles: 1,
                      onChanged: _onImageSelected,
                    ),
                    const SizedBox(height: 20),
                    RentSystemButton(label: 'Spremi', onTap: _saveForm),
                  ],
                ),
              ),
            ],
          ),
        ),
      ),
    );
  }
}
