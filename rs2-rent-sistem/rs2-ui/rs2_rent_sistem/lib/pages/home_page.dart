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
    var token = ref.watch(authTokenProvider);

    if (token == null || token.isEmpty) {
      return const LoginPage();
    }

    return _isDesktopPlatform() ? const DesktopHomePage() : _buildMobileHome(ref);
  }

  bool _isDesktopPlatform() {
    return Platform.isWindows || Platform.isLinux || Platform.isMacOS || Platform.isFuchsia;
  }

  Widget _buildMobileHome(WidgetRef ref) {
    var currentNavigationIndex = ref.watch(navigationIndexProvider);

    return Scaffold(
      appBar: AppBar(
        title: Text(_getTitle(currentNavigationIndex)),
        centerTitle: false,
      ),
      bottomNavigationBar: const BottomNavigationWidget(),
      body: SafeArea(
        child: _getBody(currentNavigationIndex),
      ),
    );
  }

  Widget _getBody(int index) {
    switch (index) {
      case 0:
        return const ActiveReservationsPage();
      case 1:
        return const AvailableEquipmentPage();
      case 2:
      default:
        return const SettingsPage();
    }
  }

  String _getTitle(int index) {
    switch (index) {
      case 0:
        return 'RENT APP';
      case 1:
        return 'Oprema';
      case 2:
      default:
        return 'Postavke';
    }
  }
}
