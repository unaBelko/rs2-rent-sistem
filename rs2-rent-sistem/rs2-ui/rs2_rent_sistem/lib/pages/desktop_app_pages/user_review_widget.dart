import 'package:flutter/material.dart';
import 'package:flutter_rating_bar/flutter_rating_bar.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/models/review_for_admin.dart';
import 'package:rs2_rent_sistem/shared/providers/review_providers.dart';
import 'package:rs2_rent_sistem/shared/utilities/extensions/date_extensions.dart';
import 'package:rs2_rent_sistem/shared/widgets/confirmation_modal.dart';

class UserReviewWidget extends ConsumerWidget {
  final ReviewForAdmin item;
  final bool showEquipmentName;

  const UserReviewWidget({
    super.key,
    required this.item,
    this.showEquipmentName = true,
  });

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    return Card(
      child: Padding(
        padding: const EdgeInsets.symmetric(
          horizontal: 12.0,
          vertical: 10,
        ),
        child: Row(
          children: [
            Expanded(
              flex: 2,
              child: RatingBar.builder(
                initialRating: item.numberOfStars,
                minRating: 1,
                direction: Axis.horizontal,
                allowHalfRating: true,
                itemBuilder: (context, _) =>
                    const Icon(Icons.star, color: Colors.amber),
                onRatingUpdate: (rating) {},
                ignoreGestures: true,
              ),
            ),
            Expanded(
              flex: 1,
              child: Text(
                item.dateAdded!.formatLocal(),
              ),
            ),
            Expanded(
              flex: 4,
              child: Text(
                item.description,
                style: const TextStyle(
                  fontStyle: FontStyle.italic,
                ),
              ),
            ),
            if (showEquipmentName)
              Expanded(
                flex: 2,
                child: Text(
                  item.orderItem.equipment?.itemName ?? "",
                ),
              ),
            Expanded(
              flex: 1,
              child: Row(
                children: [
                  IconButton(
                    onPressed: () {
                      showDialog(
                          context: context,
                          builder: (context) => ConfirmationModal(
                                title: 'Uklanjanje review-a',
                                content:
                                    'Da li ste sigurni da zelite ukloniti ovaj review?',
                                buttonText: "Da",
                                onConfirm: () {
                                  ref
                                      .read(
                                          deleteReviewProvider(item.id).future)
                                      .then((_) {
                                    ref.invalidate(reviewsProvider);
                                    ScaffoldMessenger.of(context).showSnackBar(
                                      SnackBar(
                                        content: Text(
                                            'Review je uspjesno uklonjen.'),
                                      ),
                                    );
                                  }).catchError((error) {
                                    ScaffoldMessenger.of(context).showSnackBar(
                                      SnackBar(
                                        content:
                                            Text('Greška: ${error.toString()}'),
                                      ),
                                    );
                                  });
                                },
                                isDestructiveAction: true,
                              ));
                    },
                    icon: Icon(
                      Icons.dangerous,
                      color: Colors.red,
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
