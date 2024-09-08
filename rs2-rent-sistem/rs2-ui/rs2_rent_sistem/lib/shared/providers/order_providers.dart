import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/models/order_list_item.dart';
import 'package:rs2_rent_sistem/shared/api_services/dio_service.dart';
import 'package:rs2_rent_sistem/shared/api_services/order_service.dart';

final orderCreationProvider = FutureProvider<ApiResponse>((ref) async {
  final response = await OrderService().createOrder();
  return response;
});

final ordersListProvider = FutureProvider<List<OrderListItem>>((ref) async {
  final response = await OrderService().getOrdersForUser();

  if (response.isSuccess && response.data != null) {
    return response.data!;
  } else {
    throw Exception(response.error); // Throw an exception if there is an error
  }
});
