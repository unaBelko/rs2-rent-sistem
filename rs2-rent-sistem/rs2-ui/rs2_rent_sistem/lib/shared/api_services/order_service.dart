import 'package:rs2_rent_sistem/models/order_list_item.dart';
import 'package:rs2_rent_sistem/shared/api_services/dio_service.dart';
import 'package:rs2_rent_sistem/shared/constants.dart';

class OrderService {
  var dioService = DioService();

  Future<ApiResponse> createOrder() async {
    final response = await dioService.get(Endpoints.getCart);

    if (response.isSuccess && response.response?.data != null) {
      return ApiResponse(
        response: response.response,
        httpStatus: response.httpStatus,
        httpMessage: response.httpMessage,
      );
    } else {
      return ApiResponse(
        response: response.response,
        httpStatus: response.httpStatus,
        httpMessage: response.httpMessage,
        exception: response.exception,
      );
    }
  }

  Future<ApiResponse<List<OrderListItem>>> getOrdersForUser() async {
    final response = await dioService.get(Endpoints.equipment);

    if (response.isSuccess && response.response?.data != null) {
      final resultData = response.response?.data['result'] as List<dynamic>;

      final ordersList = resultData.map((item) => OrderListItem.fromJson(item)).toList();

      return ApiResponse<List<OrderListItem>>(
        response: response.response,
        httpStatus: response.httpStatus,
        httpMessage: response.httpMessage,
        data: ordersList,
      );
    } else {
      return ApiResponse<List<OrderListItem>>(
        response: response.response,
        httpStatus: response.httpStatus,
        httpMessage: response.httpMessage,
        exception: response.exception,
      );
    }
  }
}
