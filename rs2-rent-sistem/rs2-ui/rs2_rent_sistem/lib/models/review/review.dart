import 'package:freezed_annotation/freezed_annotation.dart';

part 'review.freezed.dart';
part 'review.g.dart';

@Freezed()
class Review with _$Review {
  const factory Review({
    required int id,
    required DateTime dateAdded,
    required double numberOfStars,
    required int orderItemID,
    @Default('') String description,
  }) = _Review;

  factory Review.fromJson(Map<String, dynamic> json) => _$ReviewFromJson(json);
}
