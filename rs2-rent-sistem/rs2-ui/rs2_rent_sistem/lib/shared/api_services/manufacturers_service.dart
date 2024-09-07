import 'package:rs2_rent_sistem/models/manufacturer.dart';
import 'package:rs2_rent_sistem/shared/api_services/dio_service.dart';
import 'package:rs2_rent_sistem/shared/constants.dart';

Future<ApiResponse<List<Manufacturer>>> getManufacturersList() async {
  return DioService().get<List<Manufacturer>>(
    Endpoints.manufacturer,
    fromJson: (data) => (data['manufacturers'] as List).map((item) => Manufacturer.fromJson(item)).toList(),
  );
}
