import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/models/simple_dropdown_item/simple_dropdown_item.dart';
import 'package:rs2_rent_sistem/shared/api_services/manufacturers_service.dart';

final manufacturersListProvider = FutureProvider<List<SimpleDropdownItem>>((ref) async {
  final response = await ManufacturersService.getManufacturersList();

  if (response.isSuccess && response.data != null) {
    return response.data!;
  } else {
    throw Exception(response.error); // Throw an exception if there is an error
  }
});

final updateManufacturerProvider = FutureProvider.family<void, Map<String, dynamic>>((ref, params) async {
  final int id = params['id'] as int;
  final String name = params['name'] as String;
  final String description = params['description'] as String;

  final response = await ManufacturersService.updateManufacturer(
    id: id,
    name: name,
    description: description,
  );

  if (!response.isSuccess) {
    throw Exception(response.error);
  }
});

final addManufacturerProvider = FutureProvider.family<void, Map<String, String>>((ref, params) async {
  final name = params['name']!;
  final description = params['description']!;

  final response = await ManufacturersService.addManufacturer(
    name: name,
    description: description,
  );

  if (!response.isSuccess) {
    throw Exception(response.error);
  }
});

final deleteManufacturerProvider = FutureProvider.family<void, int>((ref, id) async {
  final response = await ManufacturersService.deleteManufacturer(id: id);

  if (!response.isSuccess) {
    throw Exception(response.error);
  }
});
