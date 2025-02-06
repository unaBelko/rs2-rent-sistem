import 'package:freezed_annotation/freezed_annotation.dart';
import 'package:rs2_rent_sistem/models/item_in_order/order_item.dart';

part 'review_for_admin.freezed.dart';
part 'review_for_admin.g.dart';

@Freezed()
class ReviewForAdmin with _$ReviewForAdmin {
  const factory ReviewForAdmin({
    required int id,
    required ItemInOrder orderItem,
    @Default('') String description,
    DateTime? dateAdded,
    required double numberOfStars,
  }) = _ReviewForAdmin;

  factory ReviewForAdmin.fromJson(Map<String, dynamic> json) => _$ReviewForAdminFromJson(json);
}
