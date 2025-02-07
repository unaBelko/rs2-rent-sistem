import 'package:cached_network_image/cached_network_image.dart';
import 'package:flutter/material.dart';
import 'package:flutter_rating_bar/flutter_rating_bar.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/models/item_in_order/order_item.dart';
import 'package:rs2_rent_sistem/shared/providers/equipment_providers.dart';
import 'package:rs2_rent_sistem/shared/providers/order_item_providers.dart';
import 'package:rs2_rent_sistem/shared/providers/review_providers.dart';
import 'package:rs2_rent_sistem/shared/utilities/extensions/date_extensions.dart';

class RentedEquipmentInOrderWidget extends ConsumerStatefulWidget {
  final ItemInOrder orderItem;
  final bool showReview;

  const RentedEquipmentInOrderWidget({
    super.key,
    required this.orderItem,
    this.showReview = false,
  });

  @override
  ConsumerState<RentedEquipmentInOrderWidget> createState() =>
      _RentedEquipmentInOrderWidgetState();
}

class _RentedEquipmentInOrderWidgetState
    extends ConsumerState<RentedEquipmentInOrderWidget> {
  double _rating = 0.0;

  void _showReviewBottomSheet(BuildContext context, double rating) {
    TextEditingController reviewController = TextEditingController();

    showModalBottomSheet(
      context: context,
      isScrollControlled: true,
      builder: (context) {
        return Padding(
          padding: EdgeInsets.only(
            left: 16,
            right: 16,
            top: 16,
            bottom: MediaQuery.of(context).viewInsets.bottom + 16,
          ),
          child: Column(
            mainAxisSize: MainAxisSize.min,
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              Text(
                "Dodajte recenziju (${rating.toStringAsFixed(1)} ★)",
                style: const TextStyle(
                  fontSize: 18,
                  fontWeight: FontWeight.w600,
                ),
              ),
              const SizedBox(height: 12),
              TextField(
                controller: reviewController,
                maxLines: 3,
                decoration: const InputDecoration(
                  labelText: "Unesite komentar",
                  border: OutlineInputBorder(),
                ),
              ),
              const SizedBox(height: 12),
              ElevatedButton(
                onPressed: () {
                  String review = reviewController.text.trim();
                  final params = {
                    'orderItemID': widget.orderItem.id,
                    'numberOfStars': rating,
                    'description': review,
                  };
                  ref.read(addReviewProvider(params).future).then((_) {
                    ref.invalidate(orderItemsProvider);
                    ref.invalidate(equipmentListProvider);
                    Navigator.of(context).pop();
                    ScaffoldMessenger.of(context).showSnackBar(
                      const SnackBar(content: Text("Recenzija je poslana!")),
                    );
                  }).catchError((error) {
                    ScaffoldMessenger.of(context).showSnackBar(
                      SnackBar(
                          content: Text("Greška pri slanju recenzije: $error")),
                    );
                  });
                },
                child: const Text("Pošalji recenziju"),
              ),
            ],
          ),
        );
      },
    );
  }

  @override
  Widget build(BuildContext context) {
    return Card(
      margin: const EdgeInsets.symmetric(horizontal: 12.0, vertical: 4.0),
      child: Padding(
        padding: const EdgeInsets.all(12.0),
        child: Column(
          children: [
            Row(
              mainAxisAlignment: MainAxisAlignment.spaceBetween,
              children: [
                Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Text(
                      widget.orderItem.equipment!.itemName,
                      style: const TextStyle(
                        fontWeight: FontWeight.w600,
                        fontSize: 15,
                      ),
                    ),
                    Text('Cijena/dan: ${widget.orderItem.costPerUse}'),
                    Text('Kolicina: ${widget.orderItem.quantity}'),
                    Text(
                      '${widget.orderItem.startDate.formatLocal()} - ${widget.orderItem.endDate.formatLocal()}',
                    ),
                  ],
                ),
                CachedNetworkImage(
                  height: 70,
                  width: 70,
                  imageUrl: widget.orderItem.equipment!.imageUrl,
                  errorWidget: (_, __, ___) =>
                      const Icon(Icons.warning_rounded),
                ),
              ],
            ),
            const SizedBox(height: 8),
            if (widget.showReview) ...[
              Row(
                children: [
                  RatingBar.builder(
                    initialRating:
                        widget.orderItem.isReviewedByUser ? 3 : _rating,
                    // initialRating: widget.orderItem.isReviewedByUser?widget.orderItem.equipment.averageRating:_rating,
                    minRating: 1,
                    direction: Axis.horizontal,
                    allowHalfRating: true,
                    itemCount: 5,
                    itemSize: 30,
                    itemBuilder: (context, _) =>
                        const Icon(Icons.star, color: Colors.amber),
                    onRatingUpdate: (rating) {
                      if (!widget.orderItem.isReviewedByUser) {
                        setState(() {
                          _rating = rating;
                        });
                        _showReviewBottomSheet(context, rating);
                      }
                    },
                    ignoreGestures: widget.orderItem.isReviewedByUser,
                  ),
                ],
              ),
            ],
            const SizedBox(height: 8),
            Row(
              mainAxisAlignment: MainAxisAlignment.spaceBetween,
              children: [
                const Text(
                  'Ukupno:',
                  style: TextStyle(
                    fontWeight: FontWeight.w600,
                  ),
                ),
                Text(
                  widget.orderItem.price.toString(),
                  style: const TextStyle(
                    fontWeight: FontWeight.w600,
                  ),
                ),
              ],
            ),
          ],
        ),
      ),
    );
  }
}
