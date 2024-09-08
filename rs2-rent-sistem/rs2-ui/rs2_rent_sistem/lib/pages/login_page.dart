import 'dart:developer';
import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/pages/home_page.dart';
import 'package:rs2_rent_sistem/shared/api_services/user_service.dart';
import 'package:rs2_rent_sistem/shared/utilities/secure_storage_handler.dart';
import 'package:rs2_rent_sistem/shared/widgets/rent_system_button.dart';

class LoginPage extends ConsumerStatefulWidget {
  const LoginPage({super.key});

  @override
  ConsumerState<LoginPage> createState() => _LoginPageState();
}

class _LoginPageState extends ConsumerState<LoginPage> {
  final emailController = TextEditingController();
  final passwordController = TextEditingController();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SafeArea(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            const Text(
              'Prijava',
            ),
            const SizedBox(
              height: 30,
            ),
            Padding(
              padding: const EdgeInsets.symmetric(
                horizontal: 20.0,
                vertical: 8.0,
              ),
              child: TextField(
                controller: emailController,
                decoration: const InputDecoration(
                  border: OutlineInputBorder(),
                  hintText: 'email',
                ),
              ),
            ),
            Padding(
              padding: const EdgeInsets.symmetric(
                horizontal: 20.0,
                vertical: 8.0,
              ),
              child: TextField(
                obscureText: true,
                controller: passwordController,
                decoration: const InputDecoration(
                  border: OutlineInputBorder(),
                  hintText: 'password',
                ),
              ),
            ),
            const SizedBox(
              height: 50,
            ),
            Padding(
              padding: const EdgeInsets.symmetric(
                horizontal: 20.0,
              ),
              child: Row(
                children: [
                  Expanded(
                    child: RentSystemButton(
                      label: 'Prijava',
                      onTap: () async {
                        var loginRes = await UserService().logIn(
                          LoginData(
                            password: passwordController.text.trim(),
                            email: emailController.text.trim(),
                          ),
                        );
                        if (loginRes.isSuccess && loginRes.data != null) {
                          var token = loginRes.data!.token;
                          log('Token: $token');
                          await SecureStorageHandler().saveToken(token);
                          Navigator.of(context).push(
                            MaterialPageRoute(builder: (context) => HomePage()),
                          );
                        } else {
                          log('Login failed: ${loginRes.error}');
                        }
                      },
                    ),
                  ),
                ],
              ),
            ),
          ],
        ),
      ),
    );
  }
}
