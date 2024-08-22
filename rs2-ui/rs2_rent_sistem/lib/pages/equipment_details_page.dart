import 'package:cached_network_image/cached_network_image.dart';
import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/models/equipment_details.dart';
import 'package:rs2_rent_sistem/shared/constants.dart';
import 'package:rs2_rent_sistem/shared/widgets/rent_system_button.dart';

class EquipmentDetailsPage extends ConsumerStatefulWidget {
  final String equipmentId;

  const EquipmentDetailsPage(this.equipmentId, {super.key});

  @override
  ConsumerState<EquipmentDetailsPage> createState() => _EquipmentDetailsPageState();
}

class _EquipmentDetailsPageState extends ConsumerState<EquipmentDetailsPage> {
  TextEditingController quantityTextController = TextEditingController();
  var equipmentDetails = const EquipmentDetails(
    id: '',
    itemName: 'Lopta za odbojku',
    manufacturer: 'Adidas',
    imageUrl: Constants.imageUrl,
    minQuantity: 1,
    maxQuantity: 10,
    availableDatesForRent: [],
    description: 'A good ball for playing volleybal with the boys. A good ball for playing volleybal with the boys.',
    costPerUse: 20.0,
    isInCart: false,
  );

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SafeArea(
        child: Column(
          children: [
            Expanded(
              child: SingleChildScrollView(
                child: Padding(
                  padding: const EdgeInsets.symmetric(
                    horizontal: 20.0,
                    vertical: 12.0,
                  ),
                  child: Column(
                    children: [
                      Text(
                        equipmentDetails.itemName,
                        style: Theme.of(context).textTheme.headlineSmall?.copyWith(
                              fontWeight: FontWeight.w500,
                              fontSize: 18,
                            ),
                      ),
                      Text(
                        equipmentDetails.manufacturer,
                        style: Theme.of(context).textTheme.bodySmall?.copyWith(
                              fontStyle: FontStyle.italic,
                              fontWeight: FontWeight.w500,
                            ),
                      ),
                      ClipRRect(
                        borderRadius: BorderRadius.circular(12),
                        child: CachedNetworkImage(imageUrl: equipmentDetails.imageUrl),
                      ),
                      const SizedBox(
                        height: 20,
                      ),
                      const Row(
                        children: [
                          Expanded(
                            child: Text(
                              'Kolicina',
                            ),
                          ),
                          SizedBox(
                            width: 20,
                          ),
                          Expanded(
                            child: Text(
                              'Ukupna cijena',
                            ),
                          ),
                        ],
                      ),
                      Row(
                        children: [
                          Expanded(
                            child: TextField(
                              controller: quantityTextController,
                            ),
                          ),
                          const SizedBox(
                            width: 20,
                          ),
                          Expanded(
                            child: Text(_calculateTotalPrice(
                              quantityTextController.text.trim(),
                              equipmentDetails.costPerUse,
                            )),
                          ),
                        ],
                      ),
                      Text(
                        'Datum iznajmljivanja',
                      ),
                      // TODO: date picker
                      Text(
                        equipmentDetails.description,
                      ),
                    ],
                  ),
                ),
              ),
            ),
            SizedBox(
              width: MediaQuery.of(context).size.width,
              child: Padding(
                padding: const EdgeInsets.symmetric(horizontal: 12.0, vertical: 12.0),
                child: RentSystemButton(
                  label: 'Rezervisi',
                  onTap: () {},
                ),
              ),
            ),
          ],
        ),
      ),
    );
  }

  String _calculateTotalPrice(String ctrlText, double costPerUse) {
    var price = 0.0;
    int? quantity = 0;
    quantity = int.tryParse(ctrlText);
    if (quantity != null) {
      price = quantity * costPerUse;
    }
    return price.toString();
  }
}
