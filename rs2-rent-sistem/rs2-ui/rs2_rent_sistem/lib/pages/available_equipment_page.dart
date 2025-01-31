import 'dart:async';

import 'package:flutter/material.dart';
import 'package:flutter_rating_bar/flutter_rating_bar.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:intl/intl.dart';
import 'package:rs2_rent_sistem/models/equipment_list_item/equipment_list_item.dart';
import 'package:rs2_rent_sistem/pages/cart_page.dart';
import 'package:rs2_rent_sistem/pages/equipment_details_page.dart';
import 'package:rs2_rent_sistem/pages/equipment_filters_page.dart';
import 'package:rs2_rent_sistem/shared/constants.dart';
import 'package:cached_network_image/cached_network_image.dart';
import 'package:rs2_rent_sistem/shared/providers/equipment_providers.dart';
import 'package:rs2_rent_sistem/shared/providers/simple_list_management_providers.dart';
import 'package:rs2_rent_sistem/shared/utilities/enumerations.dart';

class AvailableEquipmentPage extends ConsumerStatefulWidget {
  const AvailableEquipmentPage({super.key});

  @override
  ConsumerState<AvailableEquipmentPage> createState() =>
      _AvailableEquipmentPageState();
}

class _AvailableEquipmentPageState
    extends ConsumerState<AvailableEquipmentPage> {
  final TextEditingController _searchController = TextEditingController();
  Timer? _debounce;

  @override
  void dispose() {
    _searchController.dispose();
    _debounce?.cancel();
    super.dispose();
  }

  void _onSearchChanged(String query) {
    if (_debounce?.isActive ?? false) _debounce!.cancel();
    _debounce = Timer(const Duration(seconds: 1), () {
      if (query.length >= 3 || query.isEmpty) {
        setState(() {
          ref.read(equipmentFilterProvider.notifier).state =
              ref.watch(equipmentFilterProvider).copyWith(name: query);
        });
      }
    });
  }

  @override
  Widget build(BuildContext context) {
    return Column(
      children: [
        Padding(
          padding: const EdgeInsets.all(16.0),
          child: TextField(
            controller: _searchController,
            onChanged: _onSearchChanged,
            decoration: InputDecoration(
              labelText: 'Pretraži opremu',
              hintText: 'Unesite naziv opreme',
              suffixIcon: const Icon(Icons.search),
              fillColor: Colors.grey.withOpacity(0.5),
              filled: true,
              border: OutlineInputBorder(
                  borderRadius: BorderRadius.circular(30),
                  borderSide: BorderSide(color: Colors.grey.withOpacity(0.5))),
            ),
          ),
        ),
        Padding(
          padding: const EdgeInsets.symmetric(horizontal: 16, vertical: 8),
          child: Row(
            children: [
              Expanded(
                child: GestureDetector(
                  onTap: () {
                    Navigator.of(context).push(MaterialPageRoute(
                        builder: (context) => EquipmentFiltersPage()));
                  },
                  child: Wrap(
                    children: [
                      Icon(
                        Icons.sort,
                      ),
                      Text('Filter'),
                    ],
                  ),
                ),
              ),
              Expanded(
                child: GestureDetector(
                  onTap: () {
                    var currentFilter = ref.watch(equipmentFilterProvider);
                    ref.read(equipmentFilterProvider.notifier).state =
                        currentFilter.copyWith(
                            sortDescending: !currentFilter.sortDescending);
                  },
                  child: Wrap(
                    children: [
                      Icon(
                        ref.watch(equipmentFilterProvider).sortDescending
                            ? Icons.arrow_downward
                            : Icons.arrow_upward,
                      ),
                      Text('Cijena'),
                    ],
                  ),
                ),
              ),
            ],
          ),
        ),
        Expanded(
          child: ref.watch(equipmentListProvider).when(
                data: (items) => Stack(
                  children: [
                    SingleChildScrollView(
                      child: items.isNotEmpty
                          ? Column(
                              children: items
                                  .map((item) => EquipmentCard(item))
                                  .toList(),
                            )
                          : Padding(
                              padding: const EdgeInsets.all(20),
                              child: Text(
                                  'Trenutno nema rezultata za ovu pretragu.'),
                            ),
                    ),
                    Positioned(
                      bottom: 20,
                      right: 20,
                      child: FloatingActionButton(
                        onPressed: () {
                          Navigator.of(context).push(MaterialPageRoute(
                              builder: (context) => const CartPage()));
                        },
                        child: const Icon(Icons.shopping_cart),
                      ),
                    ),
                  ],
                ),
                error: (err, st) => Center(child: Text('Error: $err')),
                loading: () => const Center(child: CircularProgressIndicator()),
              ),
        ),
      ],
    );
  }
}

class EquipmentCard extends StatelessWidget {
  final EquipmentListItem equipmentListItem;
  final bool isCartItem;
  final int? quantity;
  final DateTime? startDate;
  final DateTime? endDate;

  const EquipmentCard(
    this.equipmentListItem, {
    super.key,
    this.isCartItem = false,
    this.quantity,
    this.startDate,
    this.endDate,
  });

  @override
  Widget build(BuildContext context) {
    return GestureDetector(
      onTap: () {
        Navigator.of(context).push(MaterialPageRoute(
            builder: (ct) => EquipmentDetailsPage(
                equipmentListItem.id, equipmentListItem.itemName)));
      },
      child: Card(
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
                imageUrl: Constants.imageUrl,
                height: 100,
                width: 100,
              ),
            ),
            Padding(
              padding:
                  const EdgeInsets.symmetric(horizontal: 12.0, vertical: 8.0),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Text(
                    isCartItem
                        ? '${equipmentListItem.itemName} ($quantity)'
                        : equipmentListItem.itemName,
                    style: Theme.of(context).textTheme.headlineSmall?.copyWith(
                          fontWeight: FontWeight.w500,
                          fontStyle: FontStyle.italic,
                          fontSize: 18,
                        ),
                  ),
                  Text(
                    equipmentListItem.manufacturer,
                    style: Theme.of(context)
                        .textTheme
                        .bodySmall
                        ?.copyWith(color: Colors.grey),
                  ),
                  if (isCartItem)
                    Text(DateFormat('dd.MM.yyyy').format(startDate!.toLocal())),
                  if (isCartItem)
                    Text(DateFormat('dd.MM.yyyy').format(endDate!.toLocal())),
                  // Row(
                  //   children: [
                  //     RatingBar(
                  //       ignoreGestures: true,
                  //       itemSize: 20,
                  //       allowHalfRating: true,
                  //       initialRating: equipmentListItem.rating,
                  //       ratingWidget: RatingWidget(
                  //         full: const Icon(Icons.star, color: Colors.grey),
                  //         empty: const Icon(Icons.star_border_outlined, color: Colors.grey),
                  //         half: const Icon(Icons.star_half, color: Colors.grey),
                  //       ),
                  //       onRatingUpdate: (_) {},
                  //     ),
                  //     const SizedBox(width: 4),
                  //     Text(
                  //       '(${equipmentListItem.numberOfReviews})',
                  //       style: Theme.of(context).textTheme.bodySmall?.copyWith(color: Colors.grey),
                  //     ),
                  //   ],
                  // ),
                  Text(
                    equipmentListItem.costPerUse.toString(),
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
    );
  }
}
