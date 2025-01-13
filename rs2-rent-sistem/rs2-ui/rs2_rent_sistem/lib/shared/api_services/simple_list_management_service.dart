import 'package:rs2_rent_sistem/models/simple_dropdown_item/simple_dropdown_item.dart';
import 'package:rs2_rent_sistem/shared/api_services/dio_service.dart';
import 'package:rs2_rent_sistem/shared/constants.dart';
import 'package:rs2_rent_sistem/shared/utilities/enumerations.dart';

class SimpleListManagementService {
  static String _getEndpoint(SimpleListType type) {
    switch (type) {
      case SimpleListType.manufacturer:
        return Endpoints.manufacturer;
      case SimpleListType.equipmentCategory:
        return Endpoints.equipmentCategory;
    }
  }

  static Future<ApiResponse<List<SimpleDropdownItem>>> getList(SimpleListType type) async {
    final endpoint = _getEndpoint(type);
    return DioService().get<List<SimpleDropdownItem>>(
      endpoint,
      fromJson: (data) => (data['result'] as List).map((item) => SimpleDropdownItem.fromJson(item)).toList(),
    );
  }

  static Future<ApiResponse> updateItem({
    required SimpleListType type,
    required int id,
    required String name,
    required String description,
  }) async {
    final endpoint = _getEndpoint(type);
    final data = {
      'name': name,
      'description': description,
    };

    return DioService().put(
      '$endpoint/$id',
      data: data,
    );
  }

  static Future<ApiResponse> addItem({
    required SimpleListType type,
    required String name,
    required String description,
  }) async {
    final endpoint = _getEndpoint(type);
    final data = {
      'name': name,
      'description': description,
    };

    return DioService().post(
      endpoint,
      data: data,
    );
  }

  static Future<ApiResponse> deleteItem({
    required SimpleListType type,
    required int id,
  }) async {
    final endpoint = _getEndpoint(type);
    return DioService().delete(
      '$endpoint/$id',
    );
  }
}
