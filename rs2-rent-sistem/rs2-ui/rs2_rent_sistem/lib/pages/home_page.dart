import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/pages/active_reservations_page.dart';
import 'package:rs2_rent_sistem/pages/available_equipment_page.dart';
import 'package:rs2_rent_sistem/pages/desktop_home_page.dart';
import 'package:rs2_rent_sistem/pages/login_page.dart';
import 'package:rs2_rent_sistem/pages/settings_page.dart';
import 'package:rs2_rent_sistem/shared/providers/simple_state_providers.dart';
import 'package:rs2_rent_sistem/shared/providers/user_providers.dart';
import 'package:rs2_rent_sistem/shared/widgets/bottom_navigation.dart';
import 'dart:io' show Platform;

class HomePage extends ConsumerWidget {
  const HomePage({super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    var currentNavigationIndex = ref.watch(navigationIndexProvider);
    var token = ref.watch(authTokenProvider);

    // Check if the platform is desktop
    if (Platform.isWindows || Platform.isLinux || Platform.isMacOS) {
      if (token == null || token == '') {
        return LoginPage();
      } else {
        return const DesktopHomePage();
      }
    } else {
      // Platform is either Android or iOS
      if (token == null) {
        return const LoginPage();
      } else {
        return Scaffold(
          appBar: AppBar(
            title: Text(_getTitle(currentNavigationIndex)),
            centerTitle: false,
          ),
          bottomNavigationBar: const BottomNavigationWidget(),
          body: SafeArea(
            child: currentNavigationIndex == 0
                ? const ActiveReservationsPage()
                : currentNavigationIndex == 1
                    ? const AvailableEquipmentPage()
                    : const SettingsPage(),
          ),
        );
      }
    }
  }

  String _getTitle(int currentNavigationIndex) {
    var title = '';
    if (currentNavigationIndex == 0) {
      title = 'RENT APP';
    } else if (currentNavigationIndex == 1) {
      title = 'Oprema';
    } else {
      title = 'Postavke';
    }
    return title;
  }
}
