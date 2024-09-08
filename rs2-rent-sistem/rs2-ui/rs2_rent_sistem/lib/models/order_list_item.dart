import 'package:freezed_annotation/freezed_annotation.dart';

part 'order_list_item.freezed.dart';
part 'order_list_item.g.dart';

@Freezed()
class OrderListItem with _$OrderListItem {
  const factory OrderListItem({
    required int id,
    required DateTime datePlaced,
    @Default(0.0) double totalPrice,
  }) = _OrderListItem;

  factory OrderListItem.fromJson(Map<String, dynamic> json) => _$OrderListItemFromJson(json);
}
