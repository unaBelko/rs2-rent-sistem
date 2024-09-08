import 'package:rs2_rent_sistem/models/cart.dart';
import 'package:rs2_rent_sistem/shared/api_services/dio_service.dart';
import 'package:rs2_rent_sistem/shared/constants.dart';

class CartService {
  var dioService = DioService();

  Future<ApiResponse<Cart>> getCart() async {
    final response = await dioService.get(Endpoints.getCart);

    if (response.isSuccess && response.response?.data != null) {
      // Deserialize the cart data from the response
      final cartData = Cart.fromJson(response.response?.data as Map<String, dynamic>);

      // Return the ApiResponse with the deserialized Cart object
      return ApiResponse<Cart>(
        response: response.response,
        httpStatus: response.httpStatus,
        httpMessage: response.httpMessage,
        data: cartData,
      );
    } else {
      return ApiResponse<Cart>(
        response: response.response,
        httpStatus: response.httpStatus,
        httpMessage: response.httpMessage,
        exception: response.exception,
      );
    }
  }
}
