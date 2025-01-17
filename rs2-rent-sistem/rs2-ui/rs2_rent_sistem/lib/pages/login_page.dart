import 'dart:developer';
import 'dart:io';
import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/pages/registration_page.dart';
import 'package:rs2_rent_sistem/shared/api_services/user_service.dart';
import 'package:rs2_rent_sistem/shared/providers/user_providers.dart';
import 'package:rs2_rent_sistem/shared/utilities/secure_storage_handler.dart';
import 'package:rs2_rent_sistem/shared/widgets/generic_text_input_field.dart';
import 'package:rs2_rent_sistem/shared/widgets/rent_system_button.dart';

class LoginPage extends ConsumerStatefulWidget {
  const LoginPage({super.key});

  @override
  ConsumerState<LoginPage> createState() => _LoginPageState();
}

class _LoginPageState extends ConsumerState<LoginPage> {
  final GlobalKey<FormState> _formKey = GlobalKey<FormState>();
  final TextEditingController _emailController = TextEditingController();
  final TextEditingController _passwordController = TextEditingController();

  void _submitForm(BuildContext context) async {
    if (_formKey.currentState!.validate()) {
      var loginRes = await UserService().logIn(
        LoginData(
          email: _emailController.text.trim(),
          password: _passwordController.text.trim(),
        ),
      );

      if (loginRes.isSuccess && loginRes.data != null) {
        var token = loginRes.data!.token;
        log('Token: $token');
        if (Platform.isWindows || Platform.isMacOS || Platform.isLinux) {
          ref.read(authTokenProviderDesktop.notifier).state = token;
        } else {
          log("token prije ${ref.read(authTokenProvider)}");
          await SecureStorageHandler().saveToken(token);
          ref.read(authTokenProvider.notifier).state = token;
          log("token poslije ${ref.read(authTokenProvider)}");
          // await SecureStorageHandler().saveToken(token);
        }
      } else {
        log('Login failed: ${loginRes.error}');
        ScaffoldMessenger.of(context).showSnackBar(
          SnackBar(content: Text('Prijava nije uspjela: ${loginRes.error}')),
        );
      }
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        backgroundColor: Color(0xFF84C2E3),
      ),
      body: Container(
        decoration: const BoxDecoration(
          gradient: LinearGradient(
            begin: Alignment.topCenter,
            end: Alignment.bottomCenter,
            colors: [
              Color(0xFF84C2E3),
              Color(0xFFB6BABB),
            ],
          ),
        ),
        child: Center(
          child: LayoutBuilder(
            builder: (context, constraints) {
              final isDesktop = constraints.maxWidth > 600; // Consider >600px as desktop
              final formWidth = isDesktop ? constraints.maxWidth / 2 : double.infinity;

              return ConstrainedBox(
                constraints: BoxConstraints(maxWidth: formWidth),
                child: Padding(
                  padding: const EdgeInsets.symmetric(horizontal: 20.0),
                  child: Form(
                    key: _formKey,
                    child: Column(
                      mainAxisAlignment: MainAxisAlignment.center,
                      children: [
                        const Text(
                          'Prijava',
                          style: TextStyle(fontSize: 24, fontWeight: FontWeight.bold),
                        ),
                        const SizedBox(height: 30),
                        GenericTextInputField(
                          controller: _emailController,
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
                          label: 'Email',
                        ),
                        const SizedBox(height: 16),
                        GenericTextInputField(
                          controller: _passwordController,
                          obscureText: true,
                          label: 'Lozinka',
                          validator: (value) {
                            if (value == null || value.isEmpty) {
                              return 'Unesite lozinku';
                            }
                            return null;
                          },
                        ),
                        const SizedBox(height: 50),
                        RentSystemButton(
                          label: 'Prijava',
                          onTap: () => _submitForm(context),
                        ),
                        if (Platform.isIOS || Platform.isAndroid)
                          Padding(
                            padding: const EdgeInsets.symmetric(vertical: 12.0),
                            child: GestureDetector(
                              onTap: () {
                                Navigator.of(context).push(
                                  MaterialPageRoute(
                                    builder: (context) => RegistrationPage(),
                                  ),
                                );
                              },
                              child: Padding(
                                padding: const EdgeInsets.all(8.0),
                                child: Text(
                                  'Registracija',
                                  style: TextStyle(
                                    decoration: TextDecoration.underline,
                                  ),
                                ),
                              ),
                            ),
                          ),
                      ],
                    ),
                  ),
                ),
              );
            },
          ),
        ),
      ),
    );
  }
}
