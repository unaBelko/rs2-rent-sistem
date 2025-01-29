import 'package:rs2_rent_sistem/models/equipment_details_admin/equipment_details_admin.dart';
import 'package:rs2_rent_sistem/models/equipment_list.dart';
import 'package:rs2_rent_sistem/shared/api_services/dio_service.dart';
import 'package:rs2_rent_sistem/shared/constants.dart';
import 'package:rs2_rent_sistem/shared/utilities/extensions/string_extensions.dart';

class EquipmentService {
  var dioService = DioService();

  Future<ApiResponse<EquipmentList>> getEquipmentList({String? name}) async {
    final queryParameters = <String, dynamic>{};

    if (name != null && name.isNotEmpty) {
      queryParameters['name'] = name;
    }

    final response = await dioService.get<EquipmentList>(
      Endpoints.equipment,
      fromJson: EquipmentList.fromJson,
      queryParameters: queryParameters,
    );
    return response;
  }

  Future<ApiResponse<EquipmentList>> getRecommendedEquipment(
      int id) async {
    final response = await dioService.get<EquipmentList>(
      Endpoints.getRecommendedEquipment.replaceString('{1}', id.toString()),
      fromJson:EquipmentList.fromJson,
    );
    return response;
  }

  Future<ApiResponse<EquipmentDetailsAdmin>> getEquipmentDetails(int id) async {
    final response = await dioService.get('${Endpoints.equipment}/$id', fromJson: EquipmentDetailsAdmin.fromJson);

    return response;
  }

  static Future<ApiResponse> deleteItem({
    required int id,
  }) async {
    final endpoint = Endpoints.equipment;
    return DioService().delete(
      '$endpoint/Delete/$id',
    );
  }
}
