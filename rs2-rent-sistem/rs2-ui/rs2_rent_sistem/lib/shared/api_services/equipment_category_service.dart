import 'package:rs2_rent_sistem/models/simple_dropdown_item/simple_dropdown_item.dart';
import 'package:rs2_rent_sistem/shared/api_services/dio_service.dart';
import 'package:rs2_rent_sistem/shared/constants.dart';

class EquipmentCategoryService {
  static Future<ApiResponse<List<SimpleDropdownItem>>> getEquipmentCategoriesList() async {
    return DioService().get<List<SimpleDropdownItem>>(
      Endpoints.equipmentCategory,
      fromJson: (data) => (data['result'] as List).map((item) => SimpleDropdownItem.fromJson(item)).toList(),
    );
  }
}
