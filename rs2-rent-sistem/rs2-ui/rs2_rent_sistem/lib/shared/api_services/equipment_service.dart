import 'package:rs2_rent_sistem/models/equipment_details_admin/equipment_details_admin.dart';
import 'package:rs2_rent_sistem/models/equipment_list.dart';
import 'package:rs2_rent_sistem/shared/api_services/dio_service.dart';
import 'package:rs2_rent_sistem/shared/constants.dart';

class EquipmentService {
  var dioService = DioService();

  Future<ApiResponse<EquipmentList>> getEquipmentList() async {
    final response = await dioService.get<EquipmentList>(
      Endpoints.equipment,
      fromJson: EquipmentList.fromJson,
    );
    return response;
  }

  Future<ApiResponse<EquipmentDetailsAdmin>> getEquipmentDetails(int id) async {
    final response = await dioService.get('${Endpoints.equipment}/$id');

    if (response.isSuccess && response.response?.data != null) {
      final equipmentDetails = EquipmentDetailsAdmin.fromJson(response.response?.data);

      return ApiResponse<EquipmentDetailsAdmin>(
        response: response.response,
        httpStatus: response.httpStatus,
        httpMessage: response.httpMessage,
        data: equipmentDetails,
      );
    } else {
      return ApiResponse<EquipmentDetailsAdmin>(
        response: response.response,
        httpStatus: response.httpStatus,
        httpMessage: response.httpMessage,
        exception: response.exception,
      );
    }
  }
}
