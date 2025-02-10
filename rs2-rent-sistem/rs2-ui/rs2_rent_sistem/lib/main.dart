import 'dart:developer';

import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/pages/home_page.dart';
import 'package:rs2_rent_sistem/shared/constants.dart';
import 'package:rs2_rent_sistem/shared/utilities/secure_storage_handler.dart';

Future<void> main() async {
  WidgetsFlutterBinding.ensureInitialized();
  await SecureStorageHandler.init();
  runApp(const ProviderScope(
    child: MyApp(),
  ));
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});
  @override
  Widget build(BuildContext context) {
    log("running with ${Constants.apiUrl}");
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      title: 'Flutter Demo',
      theme: ThemeData(
        colorScheme: ColorScheme.fromSeed(seedColor: Colors.deepPurple),
        useMaterial3: true,
      ),
      home: HomePage(),
    );
  }
}
