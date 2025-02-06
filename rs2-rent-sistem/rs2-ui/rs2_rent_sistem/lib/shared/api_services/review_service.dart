import 'package:rs2_rent_sistem/models/review_for_admin.dart';
import 'package:rs2_rent_sistem/shared/api_services/dio_service.dart';
import 'package:rs2_rent_sistem/shared/constants.dart';

class ReviewService {
  var dioService = DioService();

  Future<ApiResponse<List<ReviewForAdmin>>> getReviews(
      {int? equipmentId, int? userId}) async {
    var endpoint = Endpoints.review;

    final Map<String, dynamic> queryParams = {};

    if (equipmentId != null) {
      queryParams['searchForEquipmentId'] = equipmentId;
    }
    if (userId != null) {
      queryParams['searchForUserId'] = userId;
    }

    final response = await dioService.get(
      endpoint,
      queryParameters: queryParams.isNotEmpty ? queryParams : null,
      fromJson: (data) => (data['result'] as List)
          .map((item) => ReviewForAdmin.fromJson(item))
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

  static Future<ApiResponse> deleteReview({
    required int id,
  }) async {
    return DioService().delete(
      '${Endpoints.review}?id=$id',
    );
  }
}
