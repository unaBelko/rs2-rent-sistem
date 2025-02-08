import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/models/review/review.dart';
import 'package:rs2_rent_sistem/shared/api_services/review_service.dart';

final addReviewProvider =
    FutureProvider.family<void, Map<String, dynamic>>((ref, params) async {
  final int orderItemID = params['orderItemID'] as int;
  final double numberOfStars = params['numberOfStars'] as double;
  final String description = params['description'] as String;

  final response = await ReviewService.addReview(
    description: description,
    orderItemID: orderItemID,
    numberOfStars: numberOfStars,
  );

  if (!response.isSuccess) {
    throw Exception(response.error);
  }
});

final reviewsProvider = FutureProvider.family<List<Review>,
    ({int? equipmentId, int? userId})>(
  (ref, params) async {
    final response = await ReviewService().getReviews(
      equipmentId: params.equipmentId,
      userId: params.userId,
    );

    if (response.isSuccess && response.data != null) {
      return response.data!;
    } else {
      throw Exception(response.error); // Handle errors properly
    }
  },
);

final deleteReviewProvider =
    FutureProvider.family<void, int>((ref, reviewId) async {
  final response = await ReviewService.deleteReview(id: reviewId);

  if (!response.isSuccess) {
    throw Exception(response.error);
  }
});
