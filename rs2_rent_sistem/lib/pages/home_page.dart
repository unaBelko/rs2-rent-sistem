import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/pages/active_reservations_page.dart';
import 'package:rs2_rent_sistem/pages/available_equipment_page.dart';
import 'package:rs2_rent_sistem/pages/settings_page.dart';
import 'package:rs2_rent_sistem/shared/providers/simple_state_providers.dart';
import 'package:rs2_rent_sistem/shared/widgets/bottom_navigation.dart';

class HomePage extends ConsumerWidget {
  const HomePage({super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    var currentNavigationIndex = ref.watch(navigationIndexProvider);
    return Scaffold(
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
