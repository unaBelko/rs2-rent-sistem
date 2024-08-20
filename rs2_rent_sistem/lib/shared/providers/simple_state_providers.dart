import 'package:hooks_riverpod/hooks_riverpod.dart';

final navigationIndexProvider = StateProvider<int>((ref) {
  return 0;
});

final desktopAppNavigationIndexProvider = StateProvider<int>((ref) {
  return 0;
});
