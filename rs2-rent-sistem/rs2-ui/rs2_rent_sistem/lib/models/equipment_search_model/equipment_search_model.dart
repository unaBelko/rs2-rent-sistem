import 'package:freezed_annotation/freezed_annotation.dart';

part 'equipment_search_model.freezed.dart';
part 'equipment_search_model.g.dart';

@Freezed()
class EquipmentSearchModel with _$EquipmentSearchModel {
  const factory EquipmentSearchModel({
    @Default('') String name,
    int? manufacturerID,
    int? equipmentCategoryID,
    @Default(true) bool sortDescending
    // @Default(false) bool isInCart,
  }) = _EquipmentSearchModel;

  factory EquipmentSearchModel.fromJson(Map<String, dynamic> json) => _$EquipmentSearchModelFromJson(json);
}
