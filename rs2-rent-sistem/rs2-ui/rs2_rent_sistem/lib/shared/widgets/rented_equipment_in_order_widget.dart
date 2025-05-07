import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:flutter_rating_bar/flutter_rating_bar.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/models/item_in_order/order_item.dart';
import 'package:rs2_rent_sistem/shared/providers/damage_providers.dart';
import 'package:rs2_rent_sistem/shared/providers/equipment_providers.dart';
import 'package:rs2_rent_sistem/shared/providers/order_item_providers.dart';
import 'package:rs2_rent_sistem/shared/providers/review_providers.dart';
import 'package:rs2_rent_sistem/shared/utilities/extensions/date_extensions.dart';

class RentedEquipmentInOrderWidget extends ConsumerStatefulWidget {
  final ItemInOrder orderItem;
  final bool showReview;
  final bool showDamage;

  const RentedEquipmentInOrderWidget({
    super.key,
    required this.orderItem,
    this.showReview = false,
    this.showDamage = false,
  });

  @override
  ConsumerState<RentedEquipmentInOrderWidget> createState() =>
      _RentedEquipmentInOrderWidgetState();
}

class _RentedEquipmentInOrderWidgetState
    extends ConsumerState<RentedEquipmentInOrderWidget> {
  double _rating = 0.0;

  void _showReviewOrDamageBottomSheet(BuildContext context, double rating,
      {bool isReview = true}) {
    TextEditingController textCtrl = TextEditingController();

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
                isReview
                    ? "Dodajte recenziju (${rating.toStringAsFixed(1)} ★)"
                    : "Opisite ostecenje opreme",
                style: const TextStyle(
                  fontSize: 18,
                  fontWeight: FontWeight.w600,
                ),
              ),
              const SizedBox(height: 12),
              TextField(
                controller: textCtrl,
                maxLines: 3,
                decoration: const InputDecoration(
                  labelText: "Unesite komentar",
                  border: OutlineInputBorder(),
                ),
              ),
              const SizedBox(height: 12),
              ElevatedButton(
                onPressed: () {
                  String comment = textCtrl.text.trim();
                  if (isReview) {
                    final params = {
                      'orderItemID': widget.orderItem.id,
                      'numberOfStars': rating,
                      'description': comment,
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
                            content:
                                Text("Greška pri slanju recenzije: $error")),
                      );
                    });
                  } else {
                    if (comment.isEmpty) {
                      Navigator.of(context).pop();
                      ScaffoldMessenger.of(context).showSnackBar(
                        const SnackBar(
                            content: Text(
                                "Slanje praznog opisa ostecenja nije moguce!")),
                      );
                    } else {
                      final params = {
                        'orderItemID': widget.orderItem.id,
                        'comment': comment,
                      };
                      ref.read(addDamageProvider(params).future).then((_) {
                        ref.invalidate(orderItemsProvider);
                        Navigator.of(context).pop();
                        ScaffoldMessenger.of(context).showSnackBar(
                          const SnackBar(
                              content: Text("Prijava ostecenja je poslana!")),
                        );
                      }).catchError((error) {
                        ScaffoldMessenger.of(context).showSnackBar(
                          SnackBar(
                              content: Text(
                                  "Greška pri slanju prijave ostecenja: $error")),
                        );
                      });
                    }
                  }
                },
                child: const Text("Pošalji"),
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
                Image.memory(
                  base64Decode(
                    widget.orderItem.equipment!.photo,
                  ),
                  height: 70,
                  width: 70,
                ),
              ],
            ),
            const SizedBox(height: 8),
            if (widget.showReview) ...[
              Row(
                children: [
                  RatingBar.builder(
                    initialRating: widget.orderItem.isReviewedByUser
                        ? widget.orderItem.equipment?.averageRating ?? 0
                        : _rating,
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
                        _showReviewOrDamageBottomSheet(context, rating);
                      }
                    },
                    ignoreGestures: widget.orderItem.isReviewedByUser,
                  ),
                ],
              ),
            ],
            if (widget.showDamage && !widget.orderItem.hasDamageReportedByUser)
              Row(
                children: [
                  ElevatedButton(
                    onPressed: () {
                      _showReviewOrDamageBottomSheet(context, _rating,
                          isReview: false);
                    },
                    child: Text(
                      'Prijava ostecenja',
                    ),
                  ),
                ],
              ),
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
