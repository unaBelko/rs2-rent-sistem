import 'package:freezed_annotation/freezed_annotation.dart';

part 'equipment_details.freezed.dart';
part 'equipment_details.g.dart';

@Freezed()
class EquipmentDetails with _$EquipmentDetails {
  const factory EquipmentDetails({
    required int id,
    @Default('') String itemName,
    @Default('') String manufacturerID,
    @Default('') String equipmentCategoryID,
    @Default('') String imageUrl,
    @Default(1) int minQuantity,
    @Default(1) int maxQuantity,
    @Default('') String description,
    @Default(0.0) double costPerUse,
    @Default(0.0) double averageRating,
    @Default('') String manufacturer,
    @Default('') String equipmentCategory,
    @Default([]) List<DateTime> availableDatesForRent,
    @Default(false) bool isInCart,
  }) = _EquipmentDetails;

  factory EquipmentDetails.fromJson(Map<String, dynamic> json) => _$EquipmentDetailsFromJson(json);
}
