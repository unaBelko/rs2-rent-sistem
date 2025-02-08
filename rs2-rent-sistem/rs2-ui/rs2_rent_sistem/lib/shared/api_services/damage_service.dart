import 'package:rs2_rent_sistem/models/damage/damage.dart';
import 'package:rs2_rent_sistem/shared/api_services/dio_service.dart';
import 'package:rs2_rent_sistem/shared/constants.dart';

class DamageService {
  var dioService = DioService();

  static Future<ApiResponse> reportDamage(
    int orderItemID,
    String comment,
  ) async {
    final data = {
      'comment': comment,
      'orderItemID': orderItemID,
    };
    return DioService().post(
      Endpoints.damage,
      data: data,
    );
  }

  Future<ApiResponse<List<Damage>>> getDamages({int? equipmentId}) async {
    var endpoint = Endpoints.damage;

    final Map<String, dynamic> queryParams = {};

    if (equipmentId != null) {
      queryParams['EquipmentID'] = equipmentId;
    }

    final response = await dioService.get(
      endpoint,
      queryParameters: queryParams.isNotEmpty ? queryParams : null,
      fromJson: (data) => (data['result'] as List)
          .map((item) => Damage.fromJson(item))
          .toList(),
    );

    return response;
  }
}
