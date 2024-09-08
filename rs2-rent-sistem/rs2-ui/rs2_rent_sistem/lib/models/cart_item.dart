import 'package:freezed_annotation/freezed_annotation.dart';
import 'package:rs2_rent_sistem/models/equipment_list_item.dart';

part 'cart_item.freezed.dart';
part 'cart_item.g.dart';

@Freezed()
class CartItem with _$CartItem {
  const factory CartItem({
    required int id,
    required DateTime startDate,
    required DateTime endDate,
    required EquipmentListItem equipment,
    @Default(0) int quantity,
  }) = _CartItem;

  factory CartItem.fromJson(Map<String, dynamic> json) => _$CartItemFromJson(json);
}
