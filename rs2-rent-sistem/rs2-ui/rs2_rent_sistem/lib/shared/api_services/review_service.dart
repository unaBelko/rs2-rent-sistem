import 'package:rs2_rent_sistem/models/review/review.dart';
import 'package:rs2_rent_sistem/shared/api_services/dio_service.dart';
import 'package:rs2_rent_sistem/shared/constants.dart';

class ReviewService {
  var dioService = DioService();

  Future<ApiResponse<List<Review>>> getReviews() async {
    var endpoint = Endpoints.review;

    final response = await dioService.get(
      endpoint,
      fromJson: (data) => (data['result'] as List)
          .map((item) => Review.fromJson(item))
          .toList(),
    );
    return response;
  }

  static Future<ApiResponse> addReview({
    required int orderItemID,
    required double numberOfStars,
    String? description,
  }) async {
    final data = {
      'description': description ?? '',
      'numberOfStars': numberOfStars,
      'orderItemID': orderItemID,
    };

    return DioService().post(
      Endpoints.review,
      data: data,
    );
  }
}
