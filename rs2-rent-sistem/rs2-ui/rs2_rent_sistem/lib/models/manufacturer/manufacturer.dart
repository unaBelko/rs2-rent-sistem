import 'package:freezed_annotation/freezed_annotation.dart';

part 'manufacturer.freezed.dart';
part 'manufacturer.g.dart';

@Freezed()
class Manufacturer with _$Manufacturer {
  const factory Manufacturer({
    @Default('') String id,
    @Default('') String name,
    @Default('') String description,
  }) = _Manufacturer;
  factory Manufacturer.fromJson(Map<String, dynamic> json) => _$ManufacturerFromJson(json);
}
