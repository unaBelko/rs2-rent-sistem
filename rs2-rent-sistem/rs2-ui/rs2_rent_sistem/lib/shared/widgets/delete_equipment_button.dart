import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/shared/providers/equipment_providers.dart';
import 'package:rs2_rent_sistem/shared/widgets/confirmation_modal.dart';

class DeleteEquipmentButton extends ConsumerWidget {
  final int id;

  const DeleteEquipmentButton(this.id, {super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    return IconButton(
      onPressed: () {
        showDialog(
            context: context,
            builder: (context) => ConfirmationModal(
                  title: 'Brisanje opreme',
                  content: "Da li ste sigurni da zelite izbrisati opremu?",
                  buttonText: "Izbrisi",
                  onConfirm: () {
                    ref.read(deleteEquipmentItem(id).future).then((_) {
                      ref.invalidate(equipmentListProvider);
                      ScaffoldMessenger.of(context).showSnackBar(
                        SnackBar(
                          content: Text(
                            'Oprema je uspješno deaktivirana.',
                          ),
                        ),
                      );
                    }).catchError((error) {
                      ScaffoldMessenger.of(context).showSnackBar(
                        SnackBar(
                          content: Text('Greška: ${error.toString()}'),
                        ),
                      );
                    });
                  },
                  isDestructiveAction: true,
                ));
      },
      icon: const Icon(
        Icons.delete,
        color: Colors.red,
      ),
    );
  }
}
