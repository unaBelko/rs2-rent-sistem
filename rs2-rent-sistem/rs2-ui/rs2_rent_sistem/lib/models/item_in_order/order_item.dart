import 'package:freezed_annotation/freezed_annotation.dart';
import 'package:rs2_rent_sistem/models/equipment_list_item/equipment_list_item.dart';

part 'order_item.freezed.dart';
part 'order_item.g.dart';

@Freezed()
class ItemInOrder with _$ItemInOrder {
  const factory ItemInOrder({
    required int id,
    required DateTime startDate,
    required DateTime endDate,
    @Default(0) int quantity,
    @Default(0) double costPerUse,
    @Default(0) double price,
    required EquipmentListItem equipment,
  }) = _OrderItem;

  factory ItemInOrder.fromJson(Map<String, dynamic> json) => _$ItemInOrderFromJson(json);
}
