import 'package:flutter/material.dart';

class GenericTextInputField extends StatelessWidget {
  final TextEditingController? controller;
  final String label;
  final String? Function(String?)? validator;
  final void Function(String?)? onSaved;
  final TextInputType keyboardType;
  final bool obscureText;
  final int? minLength;

  const GenericTextInputField({
    super.key,
    required this.label,
    this.controller,
    this.validator,
    this.onSaved,
    this.keyboardType = TextInputType.text,
    this.obscureText = false,
    this.minLength = 3,
  });

  @override
  Widget build(BuildContext context) {
    return TextFormField(
      controller: controller,
      decoration: InputDecoration(
        labelText: label,
        border: OutlineInputBorder(
          borderRadius: BorderRadius.circular(8.0),
          borderSide: const BorderSide(
            color: Colors.blueGrey,
          ),
        ),
        contentPadding: const EdgeInsets.symmetric(vertical: 16.0, horizontal: 12.0),
      ),
      validator: (value) {
        if (minLength != null && (value == null || value.length < minLength!)) {
          return 'Unesite najmanje $minLength karaktera';
        }
        if (validator != null) {
          return validator!(value);
        }
        return null;
      },
      onSaved: onSaved,
      autovalidateMode: AutovalidateMode.onUserInteraction,
      keyboardType: keyboardType,
      obscureText: obscureText,
    );
  }
}
