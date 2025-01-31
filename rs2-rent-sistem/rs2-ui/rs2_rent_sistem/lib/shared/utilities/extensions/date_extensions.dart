import 'package:intl/intl.dart';

extension DateTimeExtensions on DateTime {
  String formatLocal() {
    return DateFormat('dd.MM.yyyy').format(toLocal());
  }
}
