import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/models/item_in_order/order_item.dart';
import 'package:rs2_rent_sistem/shared/api_services/order_items_service.dart';

final orderItemsProvider = FutureProvider<List<ItemInOrder>>((ref) async {
  final response = await OrderItemsService().getOrderItems();

  if (response.isSuccess && response.data != null) {
    return response.data!;
  } else {
    throw Exception(response.error); // Throw an exception if there is an error
  }
});
