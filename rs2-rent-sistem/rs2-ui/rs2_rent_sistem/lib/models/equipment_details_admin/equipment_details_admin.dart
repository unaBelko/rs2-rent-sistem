import 'package:freezed_annotation/freezed_annotation.dart';
import 'package:rs2_rent_sistem/models/available_date/available_date.dart';

part 'equipment_details_admin.freezed.dart';
part 'equipment_details_admin.g.dart';

@Freezed()
class EquipmentDetailsAdmin with _$EquipmentDetailsAdmin {
  const factory EquipmentDetailsAdmin({
    required int id,
    @Default('') String itemName,
    @Default(0) int manufacturerID,
    @Default(0) int equipmentCategoryID,
    @Default('') String imageUrl,
    @Default(1) int minQuantity,
    @Default(1) int maxQuantity,
    @Default(1) int stockQuantity,
    @Default('') String description,
    @Default(0.0) double costPerUse,
    required DateTime dateAdded,
    @Default('') String photoBase64,
    @Default('') String manufacturer,
    @Default('') String equipmentCategory,
    @Default([]) List<AvailableDate> availableDates,
    @Default(false) bool isInCart,
  }) = _EquipmentDetailsAdmin;

  factory EquipmentDetailsAdmin.fromJson(Map<String, dynamic> json) => _$EquipmentDetailsAdminFromJson(json);
}
