import 'package:rs2_rent_sistem/models/admin_order_list_item/order_list_item.dart';
import 'package:rs2_rent_sistem/shared/api_services/dio_service.dart';
import 'package:rs2_rent_sistem/shared/constants.dart';

class OrderService {
  var dioService = DioService();

  Future<ApiResponse> createOrder() async {
    return await dioService.post(Endpoints.createOrder, data: {});
  }

  Future<ApiResponse> updateOrderStatus(int id) async {
    return await dioService.put('${Endpoints.order}/$id/status', data: {});
  }

  Future<ApiResponse<List<AdminOrderListItemModel>>> getOrders(
      {int? userId}) async {
    var endpoint = Endpoints.order;
    if (userId != null) {
      endpoint += '?SearchForUserId=$userId';
    }
    final response = await dioService.get(
      endpoint,
      fromJson: (data) => (data['result'] as List)
          .map((item) => AdminOrderListItemModel.fromJson(item))
          .toList(),
    );
    return response;
  }
}
