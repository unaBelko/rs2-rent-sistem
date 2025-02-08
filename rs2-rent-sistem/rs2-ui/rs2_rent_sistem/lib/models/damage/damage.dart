import 'package:freezed_annotation/freezed_annotation.dart';
import 'package:rs2_rent_sistem/models/item_in_order/order_item.dart';

part 'damage.freezed.dart';
part 'damage.g.dart';

@Freezed()
class Damage with _$Damage {
  const factory Damage({
    required int id,
    required ItemInOrder orderItem,
    @Default('') String comment,
    DateTime? dateAdded,
  }) = _Damage;

  factory Damage.fromJson(Map<String, dynamic> json) => _$DamageFromJson(json);
}