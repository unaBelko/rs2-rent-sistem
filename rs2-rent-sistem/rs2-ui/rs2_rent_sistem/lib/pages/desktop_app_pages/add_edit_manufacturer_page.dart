import 'package:flutter/material.dart';
import 'package:rs2_rent_sistem/models/simple_dropdown_item/simple_dropdown_item.dart';
import 'package:rs2_rent_sistem/shared/widgets/common_scaffold.dart';
import 'package:rs2_rent_sistem/shared/widgets/generic_text_input_field.dart';
import 'package:rs2_rent_sistem/shared/widgets/rent_system_button.dart';

class AddOrEditManufacturerPage extends StatefulWidget {
  final SimpleDropdownItem? item;

  const AddOrEditManufacturerPage({super.key, this.item});

  @override
  State<AddOrEditManufacturerPage> createState() => _AddOrEditManufacturerPageState();
}

class _AddOrEditManufacturerPageState extends State<AddOrEditManufacturerPage> {
  final GlobalKey<FormState> _formKey = GlobalKey<FormState>();

  final TextEditingController _nameController = TextEditingController();
  final TextEditingController _descriptionController = TextEditingController();

  @override
  void initState() {
    super.initState();

    if (widget.item != null) {
      _nameController.text = widget.item?.name ?? '';
      _descriptionController.text = widget.item?.description ?? '';
    }
  }

  void _saveForm() {
    if (_formKey.currentState!.validate()) {
      _formKey.currentState!.save();
      Navigator.of(context).pop();
    }
  }

  @override
  Widget build(BuildContext context) {
    return CommonScaffold(
      title: widget.item == null ? 'Dodavanje proizvođača' : 'Uređivanje proizvođača',
      child: SingleChildScrollView(
        child: Padding(
          padding: const EdgeInsets.symmetric(horizontal: 20.0, vertical: 12.0),
          child: Form(
            key: _formKey,
            child: Column(
              children: [
                GenericTextInputField(
                  label: 'Naziv proizvođača',
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
