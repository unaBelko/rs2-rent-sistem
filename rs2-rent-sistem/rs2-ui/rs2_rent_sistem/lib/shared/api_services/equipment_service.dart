import 'package:rs2_rent_sistem/models/equipment_list_item.dart';
import 'package:rs2_rent_sistem/shared/api_services/dio_service.dart';
import 'package:rs2_rent_sistem/shared/constants.dart';

class EquipmentService {
  var dioService = DioService();

  Future<ApiResponse<List<EquipmentListItem>>> getEquipmentList() async {
    final response = await dioService.get(Endpoints.equipment);

    if (response.isSuccess && response.response?.data != null) {
      final resultData = response.response?.data['result'] as List<dynamic>;

      final equipmentList = resultData.map((item) => EquipmentListItem.fromJson(item)).toList();

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
