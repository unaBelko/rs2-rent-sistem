import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/shared/providers/simple_state_providers.dart';

class BottomNavigationWidget extends ConsumerWidget {
  const BottomNavigationWidget({super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    var currentIndex = ref.watch(navigationIndexProvider);
    return BottomNavigationBar(
      currentIndex: currentIndex,
      onTap: (val) => ref.read(navigationIndexProvider.notifier).update((state) => val),
      items: const [
        BottomNavigationBarItem(
          icon: Icon(Icons.home),
          activeIcon: Icon(
            Icons.home,
            color: Colors.redAccent,
          ),
          label: 'Home',
        ),
        BottomNavigationBarItem(
          icon: Icon(Icons.shopping_bag),
          activeIcon: Icon(
            Icons.shopping_bag,
            color: Colors.redAccent,
          ),
          label: 'Equipment',
        ),
        BottomNavigationBarItem(
          icon: Icon(Icons.settings),
          activeIcon: Icon(
            Icons.settings,
            color: Colors.redAccent,
          ),
          label: 'Settings',
        ),
      ],
    );
  }
}
