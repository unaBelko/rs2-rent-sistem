import 'package:flutter/material.dart';

class RentSystemButton extends StatelessWidget {
  final String label;
  final VoidCallback onTap;
  final Color? backgroundColor;
  final Icon? icon;

  const RentSystemButton({
    super.key,
    required this.label,
    required this.onTap,
    this.backgroundColor = Colors.blueGrey,
    this.icon,
  });

  @override
  Widget build(BuildContext context) {
    return TextButton(
        style: TextButton.styleFrom(
            shape: RoundedRectangleBorder(
              borderRadius: BorderRadius.circular(50),
            ),
            backgroundColor: backgroundColor),
        onPressed: () {
          onTap();
        },
        child: Padding(
          padding: const EdgeInsets.symmetric(
            vertical: 8,
          ),
          child: Row(
            mainAxisAlignment: MainAxisAlignment.center,
            children: [
              Text(
                label,
                textAlign: TextAlign.center,
                style: const TextStyle(
                  color: Colors.white,
                ),
              ),
              if (icon != null)
                Padding(
                  padding: const EdgeInsets.only(left: 6),
                  child: icon!,
                ),
            ],
          ),
        ));
  }
}
