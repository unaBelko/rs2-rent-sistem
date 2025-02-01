import 'package:rs2_rent_sistem/models/item_in_order/order_item.dart';
import 'package:rs2_rent_sistem/shared/api_services/dio_service.dart';
import 'package:rs2_rent_sistem/shared/constants.dart';

class OrderItemsService {
  var dioService = DioService();

  Future<ApiResponse<List<ItemInOrder>>> getOrderItems() async {
    final response = await dioService.get(
      Endpoints.orderItems,
      fromJson: (data) => (data['result'] as List)
          .map((item) => ItemInOrder.fromJson(item))
          .toList(),
    );
    return response;
  }
}
