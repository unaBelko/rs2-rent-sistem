import 'package:flutter/material.dart';

class ConfirmationModal extends StatelessWidget {
  final String title;
  final String content;
  final String buttonText;
  final Function onConfirm;
  final bool? isDestructiveAction;
  const ConfirmationModal({
    super.key,
    required this.title,
    required this.content,
    required this.buttonText,
    required this.onConfirm,
    this.isDestructiveAction = false,
  });

  @override
  Widget build(BuildContext context) {
    return AlertDialog(
      title: Text(title),
      content: Text(content),
      actions: <Widget>[
        TextButton(
          onPressed: () {
            Navigator.of(context).pop();
          },
          child: const Text('Otkazi'),
        ),
        TextButton(
          onPressed: () {
            onConfirm();
            Navigator.of(context).pop();
          },
          child: Text(
            buttonText,
            style: TextStyle(
              color: isDestructiveAction! ? Colors.red : Colors.green,
            ),
          ),
        ),
      ],
    );
  }
}
