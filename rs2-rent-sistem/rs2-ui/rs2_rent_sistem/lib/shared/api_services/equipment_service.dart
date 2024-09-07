import 'package:rs2_rent_sistem/models/equipment_list_item.dart';
import 'package:rs2_rent_sistem/shared/api_services/dio_service.dart';
import 'package:rs2_rent_sistem/shared/constants.dart';

class EquipmentService {
  var dioService = DioService();

  Future<ApiResponse<List<EquipmentListItem>>> getEquipmentList() async {
    final response = await dioService.get(Endpoints.equipment);

    if (response.isSuccess && response.response?.data != null) {
      // Extract the 'result' list from the response data
      final resultData = response.response?.data['result'] as List<dynamic>;

      // Deserialize the list of equipment items
      final equipmentList = resultData.map((item) => EquipmentListItem.fromJson(item)).toList();

      // Return the ApiResponse with the deserialized equipment list
      return ApiResponse<List<EquipmentListItem>>(
        response: response.response,
        httpStatus: response.httpStatus,
        httpMessage: response.httpMessage,
        data: equipmentList,
      );
    } else {
      return ApiResponse<List<EquipmentListItem>>(
        response: response.response,
        httpStatus: response.httpStatus,
        httpMessage: response.httpMessage,
        exception: response.exception,
      );
    }
  }
}
