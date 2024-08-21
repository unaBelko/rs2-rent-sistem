import 'package:freezed_annotation/freezed_annotation.dart';

part 'user_order_list_item.freezed.dart';
part 'user_order_list_item.g.dart';

@Freezed()
class UserOrderListItem with _$UserOrderListItem {
  const factory UserOrderListItem({
    @Default('') String id,
    @Default('') String dateOfCreation,
    @Default(0.0) double price,
    @Default(0) int numberOfItems,
    @Default('') String status,
  }) = _UserOrderListItem;

  factory UserOrderListItem.fromJson(Map<String, dynamic> json) => _$UserOrderListItemFromJson(json);
}
