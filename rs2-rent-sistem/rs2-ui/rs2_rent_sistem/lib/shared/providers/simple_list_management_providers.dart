import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/models/simple_dropdown_item/simple_dropdown_item.dart';
import 'package:rs2_rent_sistem/shared/api_services/simple_list_management_service.dart';
import 'package:rs2_rent_sistem/shared/utilities/enumerations.dart';

final simpleListProvider = FutureProvider.family<List<SimpleDropdownItem>, SimpleListType>((ref, type) async {
  final response = await SimpleListManagementService.getList(type);

  if (response.isSuccess && response.data != null) {
    return response.data!;
  } else {
    throw Exception(response.error); // Throw an exception if there is an error
  }
});

final updateSimpleListItemProvider = FutureProvider.family<void, Map<String, dynamic>>((ref, params) async {
  final SimpleListType type = params['type'] as SimpleListType;
  final int id = params['id'] as int;
  final String name = params['name'] as String;
  final String description = params['description'] as String;

  final response = await SimpleListManagementService.updateItem(
    type: type,
    id: id,
    name: name,
    description: description,
  );

  if (!response.isSuccess) {
    throw Exception(response.error);
  }
});

final addSimpleListItemProvider =
    FutureProvider.family<void, Map<String, dynamic>>((ref, params) async {
  final SimpleListType type = params['type'] as SimpleListType;
  final String name = params['name'] as String;
  final String description = params['description'] as String;

  final response = await SimpleListManagementService.addItem(
    type: type,
    name: name,
    description: description,
  );

  if (!response.isSuccess) {
    throw Exception(response.error);
  }
});

final deleteSimpleListItemProvider =
    FutureProvider.family<void, Map<String, dynamic>>((ref, params) async {
  final SimpleListType type = params['type'] as SimpleListType;
  final int id = params['id'] as int;

  final response = await SimpleListManagementService.deleteItem(
    type: type,
    id: id,
  );

  if (!response.isSuccess) {
    throw Exception(response.error);
  }
});
