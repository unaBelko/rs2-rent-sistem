import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/models/equipment_details_admin/equipment_details_admin.dart';
import 'package:rs2_rent_sistem/models/equipment_list_item/equipment_list_item.dart';
import 'package:rs2_rent_sistem/shared/api_services/equipment_service.dart';

final equipmentListProvider = FutureProvider<List<EquipmentListItem>>((ref) async {
  final response = await EquipmentService().getEquipmentList();

  if (response.isSuccess && response.data != null) {
    return response.data!.result;
  } else {
    throw Exception(response.error);
  }
});

final equipmentDetailsProvider = FutureProvider.family<EquipmentDetailsAdmin, int>((ref, id) async {
  final response = await EquipmentService().getEquipmentDetails(id);

  if (response.isSuccess && response.data != null) {
    return response.data!;
  } else {
    throw Exception(response.error); // Throw an exception if there is an error
  }
});
