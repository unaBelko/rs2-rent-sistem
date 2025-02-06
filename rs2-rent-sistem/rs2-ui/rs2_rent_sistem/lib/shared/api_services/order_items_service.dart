import 'dart:developer';

import 'package:rs2_rent_sistem/models/item_in_order/order_item.dart';
import 'package:rs2_rent_sistem/shared/api_services/dio_service.dart';
import 'package:rs2_rent_sistem/shared/constants.dart';

class OrderItemsService {
  var dioService = DioService();

  Future<ApiResponse<List<ItemInOrder>>> getOrderItems(
      int? orderId, bool? onlyActiveReservations) async {
    log("order id $orderId, only active $onlyActiveReservations");
    var endpoint =
        '${Endpoints.orderItems}?ReturnOnlyActiveReservations=${onlyActiveReservations ?? false}';
    if (orderId != null) {
      endpoint += '&OrderId=$orderId';
    }
    log('endpoint je $endpoint');
    final response = await dioService.get(
      endpoint,
      fromJson: (data) => (data['result'] as List)
          .map((item) => ItemInOrder.fromJson(item))
          .toList(),
    );
    return response;
  }
}
