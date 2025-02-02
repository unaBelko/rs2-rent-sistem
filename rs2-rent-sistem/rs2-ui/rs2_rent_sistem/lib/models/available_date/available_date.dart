import 'package:freezed_annotation/freezed_annotation.dart';

part 'available_date.freezed.dart';
part 'available_date.g.dart';

@Freezed()
class AvailableDate with _$AvailableDate {
  const factory AvailableDate({
    required DateTime date,
    @Default(0) quantity,
  }) = _AvailableDate;

  factory AvailableDate.fromJson(Map<String, dynamic> json) =>
      _$AvailableDateFromJson(json);
}
