import 'package:freezed_annotation/freezed_annotation.dart';
import 'package:rs2_rent_sistem/models/item_in_order/order_item.dart';

part 'review.freezed.dart';
part 'review.g.dart';

@Freezed()
class Review with _$Review {
  const factory Review({
    required int id,
    required ItemInOrder orderItem,
    @Default('') String description,
    DateTime? dateAdded,
    required double numberOfStars,
  }) = _Review;

  factory Review.fromJson(Map<String, dynamic> json) => _$ReviewFromJson(json);
}
