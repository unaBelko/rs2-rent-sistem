import 'dart:developer';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/models/equipment_creation_model/equipment_creation_model.dart';
import 'package:rs2_rent_sistem/models/equipment_details_admin/equipment_details_admin.dart';
import 'package:rs2_rent_sistem/models/equipment_list_item/equipment_list_item.dart';
import 'package:rs2_rent_sistem/models/equipment_search_model/equipment_search_model.dart';
import 'package:rs2_rent_sistem/shared/api_services/equipment_service.dart';

final equipmentListProvider =
    FutureProvider<List<EquipmentListItem>>((ref) async {
  var search = ref.watch(equipmentFilterProvider);
  final response = await EquipmentService().getEquipmentList(search);

  if (response.isSuccess && response.data != null) {
    return response.data!.result;
  } else {
    throw Exception(response.error);
  }
});

final equipmentDetailsForAdminProvider =
    FutureProvider.family<EquipmentDetailsAdmin, int>((ref, id) async {
  final response = await EquipmentService().getEquipmentDetails(id);

  if (response.isSuccess && response.data != null) {
    return response.data!;
  } else {
    throw Exception(response.error);
  }
});

final recommendedEquipmentListProvider =
    FutureProvider.family<List<EquipmentListItem>, int>((ref, id) async {
  final response = await EquipmentService().getRecommendedEquipment(id);

  log('response data ${response.data}');
  if (response.isSuccess && response.data != null) {
    return response.data!.result;
  } else {
    throw Exception(response.error);
  }
});

final deleteEquipmentItem = FutureProvider.family<void, int>((ref, id) async {
  final response = await EquipmentService.deleteItem(id: id);

  if (!response.isSuccess) {
    throw Exception(response.error);
  }
});

final equipmentFilterProvider =
    StateProvider<EquipmentSearchModel>((ref) => EquipmentSearchModel(
          name: '',
          sortDescending: true,
        ));

final addEquipmentProvider =
    FutureProvider.autoDispose.family<void, EquipmentCreationModel>(
  (ref, ecm) async {
    final response = await EquipmentService.addEquipment(ecm: ecm);

    if (!response.isSuccess) {
      throw Exception(response.error);
    }
  },
);

final editEquipmentProvider = FutureProvider.autoDispose
    .family<void, ({int id, EquipmentCreationModel ecm})>(
  (ref, params) async {
    final response = await EquipmentService.editEquipment(
      ecm: params.ecm,
      itemId: params.id,
    );

    if (!response.isSuccess) {
      throw Exception(response.error);
    }
  },
);
