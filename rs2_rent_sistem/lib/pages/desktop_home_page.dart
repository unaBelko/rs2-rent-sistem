import 'dart:developer';

import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/pages/desktop_app_pages/equipment_page.dart';
import 'package:rs2_rent_sistem/pages/desktop_app_pages/orders_page.dart';
import 'package:rs2_rent_sistem/pages/desktop_app_pages/reports_page.dart';
import 'package:rs2_rent_sistem/pages/desktop_app_pages/users_page.dart';
import 'package:rs2_rent_sistem/shared/providers/simple_state_providers.dart';

class DesktopHomePage extends ConsumerWidget {
  const DesktopHomePage({super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    var currentIndex = ref.watch(desktopAppNavigationIndexProvider);

    return Scaffold(
      appBar: AppBar(
        title: const Text('Desktop App'),
        backgroundColor: Colors.blueGrey,
        leading: Builder(
          builder: (BuildContext context) {
            return IconButton(
              icon: const Icon(Icons.menu),
              onPressed: () {
                Scaffold.of(context).openDrawer();
              },
            );
          },
        ),
      ),
      drawer: Drawer(
        child: Container(
          color: Colors.blueGrey,
          child: Column(
            children: <Widget>[
              const DrawerHeader(
                decoration: BoxDecoration(
                  color: Colors.blueGrey,
                ),
                child: Text(
                  'Menu',
                  style: TextStyle(
                    color: Colors.white,
                    fontSize: 24,
                  ),
                ),
              ),
              Expanded(
                child: ListView(
                  children: <Widget>[
                    _buildDrawerItem(
                      icon: Icons.sports_tennis,
                      text: 'Oprema',
                      index: 0,
                      currentIndex: currentIndex,
                      onTap: (val) {
                        ref.read(desktopAppNavigationIndexProvider.notifier).state = val;
                        Navigator.of(context).pop();
                      },
                    ),
                    _buildDrawerItem(
                        icon: Icons.person,
                        text: 'Korisnici',
                        index: 1,
                        currentIndex: currentIndex,
                        onTap: (val) {
                          ref.read(desktopAppNavigationIndexProvider.notifier).state = val;
                          Navigator.of(context).pop();
                        }),
                    _buildDrawerItem(
                      icon: Icons.warning,
                      text: 'Zahtjevi',
                      index: 2,
                      currentIndex: currentIndex,
                      onTap: (val) {
                        ref.read(desktopAppNavigationIndexProvider.notifier).state = val;
                        Navigator.of(context).pop();
                      },
                    ),
                    _buildDrawerItem(
                        icon: Icons.list,
                        text: 'Izvjestaji',
                        index: 3,
                        currentIndex: currentIndex,
                        onTap: (val) {
                          ref.read(desktopAppNavigationIndexProvider.notifier).state = val;
                          Navigator.of(context).pop();
                        }),
                  ],
                ),
              ),
              const Divider(color: Colors.white),
              ListTile(
                leading: const Icon(Icons.logout, color: Colors.white),
                title: const Text('Log Out', style: TextStyle(color: Colors.white)),
                onTap: () {
                  Navigator.pop(context);
                },
              ),
              const SizedBox(height: 16),
            ],
          ),
        ),
      ),
      body: SafeArea(
        child: Scaffold(
          body: currentIndex == 0
              ? const EquipmentPage()
              : currentIndex == 1
                  ? const UsersPage()
                  : currentIndex == 2
                      ? const OrdersPage()
                      : const ReportsPage(),
        ),
      ),
    );
  }

  Widget _buildDrawerItem({
    required IconData icon,
    required String text,
    required int index,
    required int currentIndex,
    required ValueChanged<int> onTap,
  }) {
    log("current index $currentIndex");
    return ListTile(
      trailing: Icon(icon, color: currentIndex == index ? Colors.red : Colors.white),
      title: Text(
        text,
        style: TextStyle(color: currentIndex == index ? Colors.red : Colors.white),
      ),
      selected: currentIndex == index,
      selectedTileColor: Colors.white,
      onTap: () => onTap(index),
    );
  }
}
