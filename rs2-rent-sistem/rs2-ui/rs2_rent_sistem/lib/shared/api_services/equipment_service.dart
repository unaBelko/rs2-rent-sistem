import 'package:rs2_rent_sistem/models/equipment_creation_model/equipment_creation_model.dart';
import 'package:rs2_rent_sistem/models/equipment_details_admin/equipment_details_admin.dart';
import 'package:rs2_rent_sistem/models/equipment_list.dart';
import 'package:rs2_rent_sistem/models/equipment_search_model/equipment_search_model.dart';
import 'package:rs2_rent_sistem/shared/api_services/dio_service.dart';
import 'package:rs2_rent_sistem/shared/constants.dart';
import 'package:rs2_rent_sistem/shared/utilities/extensions/string_extensions.dart';

class EquipmentService {
  var dioService = DioService();

  Future<ApiResponse<EquipmentList>> getEquipmentList(
      EquipmentSearchModel esm) async {
    final response = await dioService.get<EquipmentList>(
      Endpoints.equipment,
      fromJson: EquipmentList.fromJson,
      queryParameters: esm.toJson(),
    );
    return response;
  }

  Future<ApiResponse<EquipmentList>> getRecommendedEquipment(int id) async {
    final response = await dioService.get<EquipmentList>(
      Endpoints.getRecommendedEquipment.replaceString('{1}', id.toString()),
      fromJson: EquipmentList.fromJson,
    );
    return response;
  }

  Future<ApiResponse<EquipmentDetailsAdmin>> getEquipmentDetails(int id) async {
    final response = await dioService.get('${Endpoints.equipment}/$id',
        fromJson: EquipmentDetailsAdmin.fromJson);

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

  static Future<ApiResponse> addEquipment(
      {required EquipmentCreationModel ecm}) async {
    return DioService().post(
      Endpoints.equipment,
      data: ecm.toJson(),
    );
  }

  static Future<ApiResponse> editEquipment(
      {required EquipmentCreationModel ecm, required int itemId}) async {
    var endpoint = "${Endpoints.equipment}/$itemId";
    return DioService().put(
      endpoint,
      data: ecm.toJson(),
    );
  }
}
