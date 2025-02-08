import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/models/damage/damage.dart';
import 'package:rs2_rent_sistem/shared/api_services/damage_service.dart';

final addDamageProvider =
    FutureProvider.family<void, Map<String, dynamic>>((ref, params) async {
  final int orderItemID = params['orderItemID'] as int;
  final String comment = params['comment'] as String;

  final response = await DamageService.reportDamage(orderItemID, comment);

  if (!response.isSuccess) {
    throw Exception(response.error);
  }
});

final damagesProvider =
    FutureProvider.family<List<Damage>, ({int? equipmentId})>(
  (ref, params) async {
    final response = await DamageService().getDamages(
      equipmentId: params.equipmentId,
    );

    if (response.isSuccess && response.data != null) {
      return response.data!;
    } else {
      throw Exception(response.error); // Handle errors properly
    }
  },
);
