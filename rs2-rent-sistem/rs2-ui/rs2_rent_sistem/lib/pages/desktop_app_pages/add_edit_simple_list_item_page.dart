import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/models/simple_dropdown_item/simple_dropdown_item.dart';
import 'package:rs2_rent_sistem/shared/providers/simple_list_management_providers.dart';
import 'package:rs2_rent_sistem/shared/utilities/enumerations.dart';
import 'package:rs2_rent_sistem/shared/widgets/common_scaffold.dart';
import 'package:rs2_rent_sistem/shared/widgets/generic_text_input_field.dart';
import 'package:rs2_rent_sistem/shared/widgets/rent_system_button.dart';

class AddOrEditSimpleListItemPage extends ConsumerStatefulWidget {
  final SimpleListType type;
  final SimpleDropdownItem? item;

  const AddOrEditSimpleListItemPage({
    super.key,
    this.item,
    required this.type,
  });

  @override
  ConsumerState<AddOrEditSimpleListItemPage> createState() =>
      _AddOrEditSimpleListItemPageState();
}

class _AddOrEditSimpleListItemPageState
    extends ConsumerState<AddOrEditSimpleListItemPage> {
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
      final id = widget.item?.id;
      final name = _nameController.text;
      final description = _descriptionController.text;

      if (id != null) {
        // Update Item
        ref
            .read(updateSimpleListItemProvider({
          'type': widget.type,
          'id': id,
          'name': name,
          'description': description,
        }).future)
            .then((_) {
          ref.invalidate(simpleListProvider(widget.type));
          Navigator.of(context).pop();
          ScaffoldMessenger.of(context).showSnackBar(
            SnackBar(
                content: Text(
                    '${_getTypeLabel(widget.type)} je uspješno ažuriran.')),
          );
        }).catchError((error) {
          ScaffoldMessenger.of(context).showSnackBar(
            SnackBar(content: Text('Greška: ${error.toString()}')),
          );
        });
      } else {
        // Add Item
        ref
            .read(addSimpleListItemProvider({
          'type': widget.type,
          'name': name,
          'description': description,
        }).future)
            .then((_) {
          ref.invalidate(simpleListProvider(widget.type));
          Navigator.of(context).pop();
          ScaffoldMessenger.of(context).showSnackBar(
            SnackBar(
                content:
                    Text('${_getTypeLabel(widget.type)} je uspješno dodan.')),
          );
        }).catchError((error) {
          ScaffoldMessenger.of(context).showSnackBar(
            SnackBar(content: Text('Greška: ${error.toString()}')),
          );
        });
      }
    }
  }

  String _getTypeLabel(SimpleListType type) {
    switch (type) {
      case SimpleListType.manufacturer:
        return 'Proizvođač';
      case SimpleListType.equipmentCategory:
        return 'Kategorija opreme';
      default:
        return 'Stavka';
    }
  }

  @override
  Widget build(BuildContext context) {
    return CommonScaffold(
      title: widget.item == null
          ? 'Dodavanje ${_getTypeLabel(widget.type).toLowerCase()}'
          : 'Uređivanje ${_getTypeLabel(widget.type).toLowerCase()}',
      child: SingleChildScrollView(
        child: Padding(
          padding: const EdgeInsets.symmetric(horizontal: 20.0, vertical: 12.0),
          child: Form(
            key: _formKey,
            child: Column(
              children: [
                GenericTextInputField(
                  label: 'Naziv ${_getTypeLabel(widget.type).toLowerCase()}',
                  keyboardType: TextInputType.text,
                  controller: _nameController,
                  validator: (value) {
                    if (value == null || value.isEmpty) {
                      return 'Unesite naziv ${_getTypeLabel(widget.type).toLowerCase()}';
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
