import 'package:rs2_rent_sistem/models/simple_dropdown_item/simple_dropdown_item.dart';
import 'package:rs2_rent_sistem/shared/api_services/dio_service.dart';
import 'package:rs2_rent_sistem/shared/constants.dart';

class ManufacturersService {
  static Future<ApiResponse<List<SimpleDropdownItem>>> getManufacturersList() async {
    return DioService().get<List<SimpleDropdownItem>>(
      Endpoints.manufacturer,
      fromJson: (data) => (data['result'] as List).map((item) => SimpleDropdownItem.fromJson(item)).toList(),
    );
  }

  static Future<ApiResponse> updateManufacturer({
    required int id,
    required String name,
    required String description,
  }) async {
    final data = {
      'name': name,
      'description': description,
    };

    return DioService().put(
      '${Endpoints.manufacturer}/$id',
      data: data,
    );
  }

  static Future<ApiResponse> addManufacturer({
    required String name,
    required String description,
  }) async {
    final data = {
      'name': name,
      'description': description,
    };

    return DioService().post(
      Endpoints.manufacturer,
      data: data,
    );
  }

  static Future<ApiResponse> deleteManufacturer({
    required int id,
  }) async {
    return DioService().delete(
      '${Endpoints.manufacturer}/$id',
    );
  }
}
