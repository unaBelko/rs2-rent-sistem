import 'package:freezed_annotation/freezed_annotation.dart';

part 'equipment_list_item.freezed.dart';
part 'equipment_list_item.g.dart';

@Freezed()
class EquipmentListItem with _$EquipmentListItem {
  const factory EquipmentListItem({
    @Default('') String id,
    @Default('') String imageUrl,
    @Default('') String itemName,
    @Default('') String manufacturer,
    @Default(0.0) double rating,
    @Default(0) int numberOfReviews,
    @Default('') String costPerDay,
    @Default(false) bool isInCart,
  }) = _EquipmentListItem;

  factory EquipmentListItem.fromJson(Map<String, dynamic> json) => _$EquipmentListItemFromJson(json);
}
