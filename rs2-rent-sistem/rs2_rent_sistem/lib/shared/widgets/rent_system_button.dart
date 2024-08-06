import 'package:flutter/material.dart';

class RentSystemButton extends StatelessWidget {
  final String label;
  final VoidCallback onTap;

  const RentSystemButton({
    super.key,
    required this.label,
    required this.onTap,
  });

  @override
  Widget build(BuildContext context) {
    return TextButton(
        style: TextButton.styleFrom(
          shape: RoundedRectangleBorder(
            borderRadius: BorderRadius.circular(50),
          ),
          backgroundColor: Colors.pinkAccent
        ),
        onPressed: () {
          onTap();
        },
        child: Padding(
          padding: const EdgeInsets.symmetric(
            vertical: 8,
          ),
          child: Text(
            label,
            textAlign: TextAlign.center,
          ),
        ));
  }
}
