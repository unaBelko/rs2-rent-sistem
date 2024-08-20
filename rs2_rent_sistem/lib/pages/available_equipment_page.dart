import 'dart:developer';

import 'package:flutter/material.dart';
import 'package:flutter_rating_bar/flutter_rating_bar.dart';
import 'package:rs2_rent_sistem/models/equipment_list_item.dart';
import 'package:rs2_rent_sistem/shared/constants.dart';
import 'package:cached_network_image/cached_network_image.dart';

class AvailableEquipmentPage extends StatelessWidget {
  const AvailableEquipmentPage({super.key});

  @override
  Widget build(BuildContext context) {
    return const Column(
      children: [
        EquipmentCard(
          EquipmentListItem(
            id: 'id',
            imageUrl: Constants.imageUrl,
            itemName: 'Lopta za odbojku',
            manufacturer: 'Adidas',
            rating: 3.5,
            numberOfReviews: 10,
            costPerDay: '10,00 KM',
            isInCart: false,
          ),
        ),
        EquipmentCard(
          EquipmentListItem(
            id: 'id',
            imageUrl: Constants.imageUrl,
            itemName: 'Lopta za odbojku',
            manufacturer: 'Adidas',
            rating: 3.5,
            numberOfReviews: 10,
            costPerDay: '10,00 KM',
            isInCart: false,
          ),
        ),
        EquipmentCard(
          EquipmentListItem(
            id: 'id',
            imageUrl: Constants.imageUrl,
            itemName: 'Lopta za odbojku',
            manufacturer: 'Adidas',
            rating: 3.5,
            numberOfReviews: 10,
            costPerDay: '10,00 KM',
            isInCart: false,
          ),
        ),
        EquipmentCard(
          EquipmentListItem(
            id: 'id',
            imageUrl: Constants.imageUrl,
            itemName: 'Lopta za odbojku',
            manufacturer: 'Adidas',
            rating: 3.5,
            numberOfReviews: 10,
            costPerDay: '10,00 KM',
            isInCart: true,
          ),
        ),
      ],
    );
  }
}

class EquipmentCard extends StatelessWidget {
  final EquipmentListItem equipmentListItem;

  const EquipmentCard(
    this.equipmentListItem, {
    super.key,
  });

  @override
  Widget build(BuildContext context) {
    return Stack(
      children: [
        Card(
          margin: const EdgeInsets.all(12),
          child: Row(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              ClipRRect(
                borderRadius: const BorderRadius.only(
                  topLeft: Radius.circular(12),
                  bottomLeft: Radius.circular(12),
                ),
                child: CachedNetworkImage(
                  imageUrl: equipmentListItem.imageUrl,
                  height: 100,
                  width: 100,
                ),
              ),
              Padding(
                padding: const EdgeInsets.symmetric(
                  horizontal: 12.0,
                  vertical: 8.0,
                ),
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Text(
                      equipmentListItem.itemName,
                      style: Theme.of(context).textTheme.headlineSmall?.copyWith(
                            fontWeight: FontWeight.w500,
                            fontStyle: FontStyle.italic,
                            fontSize: 18,
                          ),
                    ),
                    Text(
                      equipmentListItem.manufacturer,
                      style: Theme.of(context).textTheme.bodySmall?.copyWith(
                            color: Colors.grey,
                          ),
                    ),
                    Row(
                      children: [
                        RatingBar(
                          ignoreGestures: true,
                          itemSize: 20,
                          allowHalfRating: true,
                          initialRating: equipmentListItem.rating,
                          ratingWidget: RatingWidget(
                            full: const Icon(
                              Icons.star,
                              color: Colors.grey,
                            ),
                            empty: const Icon(
                              Icons.star_border_outlined,
                              color: Colors.grey,
                            ),
                            half: const Icon(
                              Icons.star_half,
                              color: Colors.grey,
                            ),
                          ),
                          onRatingUpdate: (_) {},
                        ),
                        const SizedBox(
                          width: 4,
                        ),
                        Text(
                          '(${equipmentListItem.numberOfReviews})',
                          style: Theme.of(context).textTheme.bodySmall?.copyWith(
                                color: Colors.grey,
                              ),
                        ),
                      ],
                    ),
                    Text(
                      equipmentListItem.costPerDay,
                      style: Theme.of(context).textTheme.bodyMedium?.copyWith(
                            fontStyle: FontStyle.italic,
                            fontWeight: FontWeight.w500,
                          ),
                    ),
                  ],
                ),
              ),
            ],
          ),
        ),
        Positioned(
          bottom: 0,
          right: 12,
          child: GestureDetector(
            onTap: () {
              log('pressed');
            },
            child: Container(
              decoration: BoxDecoration(
                  color: equipmentListItem.isInCart ? Colors.redAccent : Colors.grey,
                  borderRadius: BorderRadius.circular(30)),
              child: Padding(
                padding: const EdgeInsets.all(8.0),
                child: Icon(equipmentListItem.isInCart ? Icons.delete : Icons.add),
              ),
            ),
          ),
        ),
      ],
    );
  }
}
