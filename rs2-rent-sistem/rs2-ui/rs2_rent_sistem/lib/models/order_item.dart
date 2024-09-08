import 'package:freezed_annotation/freezed_annotation.dart';
import 'package:rs2_rent_sistem/models/equipment_list_item.dart';

part 'order_item.freezed.dart';
part 'order_item.g.dart';

@Freezed()
class OrderItem with _$OrderItem {
  const factory OrderItem({
    required int id,
    required DateTime startDate,
    required DateTime endDate,
    @Default(0) int quantity,
    @Default(0) double costPerUse,
    required EquipmentListItem equipment,
  }) = _OrderItem;

  factory OrderItem.fromJson(Map<String, dynamic> json) => _$OrderItemFromJson(json);
}
