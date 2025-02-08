import 'package:flutter/material.dart';

class CommonScaffold extends StatelessWidget {
  final String title;
  final Widget child;
  final int numberOfPopsOnBack;
  final bool showX;
  final Widget? action;

  const CommonScaffold({
    super.key,
    required this.title,
    required this.child,
    this.numberOfPopsOnBack = 1,
    this.showX = false,
    this.action,
  });

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
          backgroundColor: Colors.blueGrey,
          title: Text(title),
          leading: IconButton(
            onPressed: () {
              for (int i = 0; i < numberOfPopsOnBack; i++) {
                Navigator.of(context).pop();
              }
            },
            icon: const Icon(Icons.arrow_back),
          ),
          actions: [
            if (showX)
              IconButton(
                onPressed: () {
                  Navigator.of(context).pop();
                },
                icon: const Icon(Icons.close),
              ),
            if (action != null) action!,
          ]),
      body: SafeArea(
        child: child,
      ),
    );
  }
}
