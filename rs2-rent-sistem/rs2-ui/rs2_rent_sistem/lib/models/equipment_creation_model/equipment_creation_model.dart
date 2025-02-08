import 'package:freezed_annotation/freezed_annotation.dart';

part 'equipment_creation_model.freezed.dart';
part 'equipment_creation_model.g.dart';

@freezed
class EquipmentCreationModel with _$EquipmentCreationModel {
  factory EquipmentCreationModel({
    required String itemName,
    required double costPerUse,
    required DateTime dateAdded,
    required int equipmentCategoryID,
    required int manufacturerID,
    @Default('') String photoBase64,
    @Default(1) int stockQuantity,
    @Default(1) int minQuantity,
    @Default(1) int maxQuantity,
    @Default('') String description,
  }) = _EquipmentCreationModel;

  factory EquipmentCreationModel.fromJson(Map<String, dynamic> json) =>
      _$EquipmentCreationModelFromJson(json);
}
