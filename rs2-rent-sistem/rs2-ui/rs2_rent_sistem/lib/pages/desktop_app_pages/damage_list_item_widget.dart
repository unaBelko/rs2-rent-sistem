import 'package:flutter/material.dart';
import 'package:rs2_rent_sistem/models/damage/damage.dart';
import 'package:rs2_rent_sistem/shared/utilities/extensions/date_extensions.dart';

class DamageListItemWidget extends StatelessWidget {
  final Damage damageItem;

  const DamageListItemWidget(this.damageItem, {super.key});

  @override
  Widget build(BuildContext context) {
    return Card(
      child: Padding(
        padding: EdgeInsets.all(12.0),
        child: Row(
          children: [
            Expanded(
                flex: 1,
                child: Text(
                  damageItem.dateAdded!.formatLocal(),
                )),
            Expanded(
              flex: 4,
              child: Text(
                damageItem.comment,
              ),
            ),
          ],
        ),
      ),
    );
  }
}
