import 'package:freezed_annotation/freezed_annotation.dart';

part 'order_for_admin_list_item.freezed.dart';
part 'order_for_admin_list_item.g.dart';

@Freezed()
class OrderForAdminListItem with _$OrderForAdminListItem {
  const factory OrderForAdminListItem({
    @Default('') String id,
    @Default('') String userName,
    @Default('') String userSurname,
    required DateTime dateCreated,
    @Default(0) double price,
    @Default('') String status,
  }) = _OrderForAdminListItem;

  factory OrderForAdminListItem.fromJson(Map<String, dynamic> json) => _$OrderForAdminListItemFromJson(json);
}
