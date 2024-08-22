import 'dart:developer';

import 'package:flutter/material.dart';
import 'package:rs2_rent_sistem/shared/widgets/confirmation_modal.dart';

class DeleteEquipmentButton extends StatelessWidget {
  const DeleteEquipmentButton({super.key});

  @override
  Widget build(BuildContext context) {
    return IconButton(
      onPressed: () {
        showDialog(
            context: context,
            builder: (context) => ConfirmationModal(
                  title: 'Brisanje opreme',
                  content: "Da li ste sigurni da zelite izbrisati opremu?",
                  buttonText: "Izbrisi",
                  onConfirm: () {
                    log("izbrisano");
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
