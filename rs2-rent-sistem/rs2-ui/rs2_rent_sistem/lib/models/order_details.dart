import 'package:freezed_annotation/freezed_annotation.dart';
import 'package:rs2_rent_sistem/models/equipment_list_item.dart';

part 'order_details.freezed.dart';
part 'order_details.g.dart';

@Freezed()
class OrderDetails with _$OrderDetails {
  const factory OrderDetails({
    required int id,
    required DateTime datePlaced,
    @Default(0.0) double totalPrice,
  }) = _OrderDetails;

  factory OrderDetails.fromJson(Map<String, dynamic> json) => _$OrderDetailsFromJson(json);
}
