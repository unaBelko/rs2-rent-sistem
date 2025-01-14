import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/models/registration_data/registration_data.dart';
import 'package:rs2_rent_sistem/shared/providers/user_providers.dart';
import 'package:rs2_rent_sistem/shared/widgets/common_scaffold.dart';
import 'package:rs2_rent_sistem/shared/widgets/generic_text_input_field.dart';
import 'package:rs2_rent_sistem/shared/widgets/rent_system_button.dart';

class RegistrationPage extends ConsumerStatefulWidget {
  const RegistrationPage({super.key});

  @override
  ConsumerState<RegistrationPage> createState() => _RegistrationPageState();
}

class _RegistrationPageState extends ConsumerState<RegistrationPage> {
  final GlobalKey<FormState> _formKey = GlobalKey<FormState>();
  final TextEditingController _passwordController = TextEditingController();

  String? _firstName;
  String? _lastName;
  String? _email;
  String? _phone;
  String? _password;

  void _saveForm() {
    if (_formKey.currentState!.validate()) {
      _formKey.currentState!.save();

      final registrationData = RegistrationData(
        firstName: _firstName!,
        lastName: _lastName!,
        email: _email!,
        phone: _phone!,
        password: _password!,
        platformType: 'mobile',
      );
      ref.read(registrationProvider(registrationData).future).then((_) {
        Navigator.of(context).pop();
        ScaffoldMessenger.of(context).showSnackBar(
          SnackBar(content: Text('Registracija je uspjela!')),
        );
      }).catchError((error) {
        ScaffoldMessenger.of(context).showSnackBar(
          SnackBar(content: Text('Greška: ${error.toString()}')),
        );
      });
    }
  }

  @override
  Widget build(BuildContext context) {
    return CommonScaffold(
      title: 'Registracija',
      child: SafeArea(
        child: SingleChildScrollView(
          child: Padding(
            padding: const EdgeInsets.all(20.0),
            child: Form(
              key: _formKey,
              child: Column(
                children: [
                  GenericTextInputField(
                    label: 'Ime',
                    keyboardType: TextInputType.text,
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'Unesite ime';
                      }
                      return null;
                    },
                    onSaved: (value) => _firstName = value,
                  ),
                  const SizedBox(height: 12),
                  GenericTextInputField(
                    label: 'Prezime',
                    keyboardType: TextInputType.text,
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'Unesite prezime';
                      }
                      return null;
                    },
                    onSaved: (value) => _lastName = value,
                  ),
                  const SizedBox(height: 12),
                  GenericTextInputField(
                    label: 'Email',
                    keyboardType: TextInputType.emailAddress,
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'Unesite email';
                      }
                      final emailRegex = RegExp(r'^[^@]+@[^@]+\.[^@]+');
                      if (!emailRegex.hasMatch(value)) {
                        return 'Unesite validan email';
                      }
                      return null;
                    },
                    onSaved: (value) => _email = value,
                  ),
                  const SizedBox(height: 12),
                  GenericTextInputField(
                    label: 'Broj telefona',
                    keyboardType: TextInputType.phone,
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'Unesite broj telefona';
                      }
                      final phoneRegex =
                          RegExp(r'^\+?[0-9]{1,3}?[-.\s]?(\(?\d{1,4}?\)?[-.\s]?)?\d{1,9}([-.\s]?\d{1,4})*$');
                      if (!phoneRegex.hasMatch(value)) {
                        return 'Unesite validan broj telefona';
                      }
                      return null;
                    },
                    onSaved: (value) => _phone = value,
                  ),
                  const SizedBox(height: 12),
                  GenericTextInputField(
                    obscureText: true,
                    label: 'Lozinka',
                    keyboardType: TextInputType.text,
                    controller: _passwordController,
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'Unesite lozinku';
                      }
                      return null;
                    },
                    onSaved: (value) => _password = value,
                  ),
                  const SizedBox(height: 12),
                  GenericTextInputField(
                    label: 'Ponovljena lozinka',
                    keyboardType: TextInputType.text,
                    obscureText: true,
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'Unesite lozinku';
                      }
                      if (value != _passwordController.text) {
                        return 'Lozinke se ne podudaraju';
                      }
                      return null;
                    },
                  ),
                  const SizedBox(height: 30),
                  RentSystemButton(
                    label: 'Spremi',
                    onTap: _saveForm,
                  ),
                ],
              ),
            ),
          ),
        ),
      ),
    );
  }
}
