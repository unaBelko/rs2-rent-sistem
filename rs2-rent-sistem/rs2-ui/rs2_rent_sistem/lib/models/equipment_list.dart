import 'package:freezed_annotation/freezed_annotation.dart';
import 'package:rs2_rent_sistem/models/equipment_list_item/equipment_list_item.dart';

part 'equipment_list.freezed.dart';
part 'equipment_list.g.dart';

@freezed
class EquipmentList with _$EquipmentList {
  factory EquipmentList({
    @Default([]) List<EquipmentListItem> result,
    required int count,
  }) = _EquipmentList;

  factory EquipmentList.fromJson(
    Map<String, dynamic> json,
  ) =>
      _$EquipmentListFromJson(
        json,
      );
}
