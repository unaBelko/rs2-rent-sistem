import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/models/simple_dropdown_item/simple_dropdown_item.dart';
import 'package:rs2_rent_sistem/shared/api_services/equipment_category_service.dart';

final equipmentCategoryListProvider = FutureProvider<List<SimpleDropdownItem>>((ref) async {
  final response = await EquipmentCategoryService.getEquipmentCategoriesList();

  if (response.isSuccess && response.data != null) {
    return response.data!;
  } else {
    throw Exception(response.error); // Throw an exception if there is an error
  }
});
