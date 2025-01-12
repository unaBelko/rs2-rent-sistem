import 'package:flutter/material.dart';

class GenericTextInputField extends StatelessWidget {
  final TextEditingController? controller;
  final String label;
  final String? Function(String?)? validator;
  final void Function(String?)? onSaved; // Added onSaved callback
  final TextInputType keyboardType;
  final bool obscureText;

  const GenericTextInputField({
    super.key,
    required this.label,
    this.controller,
    this.validator,
    this.onSaved, // Initialize onSaved
    this.keyboardType = TextInputType.text,
    this.obscureText = false,
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
      validator: validator,
      onSaved: onSaved,
      // Pass the onSaved callback to TextFormField
      autovalidateMode: AutovalidateMode.onUserInteraction,
      keyboardType: keyboardType,
      obscureText: obscureText,
    );
  }
}
