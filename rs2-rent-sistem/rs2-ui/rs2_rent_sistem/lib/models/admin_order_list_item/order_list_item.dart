import 'package:freezed_annotation/freezed_annotation.dart';

part 'order_list_item.freezed.dart';
part 'order_list_item.g.dart';

@Freezed()
class AdminOrderListItemModel with _$AdminOrderListItemModel {
  const factory AdminOrderListItemModel({
    required int id,
    required DateTime datePlaced,
    @Default(0.0) double totalPrice,
    @Default('') String status,
    @Default('') String userNameSurname,
  }) = _OrderListItem;

  factory AdminOrderListItemModel.fromJson(Map<String, dynamic> json) => _$AdminOrderListItemModelFromJson(json);
}
