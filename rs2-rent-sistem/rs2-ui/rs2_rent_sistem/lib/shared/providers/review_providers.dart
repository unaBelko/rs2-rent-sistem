import 'package:hooks_riverpod/hooks_riverpod.dart';
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
