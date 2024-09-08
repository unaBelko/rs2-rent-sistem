import 'package:flutter/material.dart';

class CommonScaffold extends StatelessWidget {
  final String title;
  final Widget child;
  final int numberOfPopsOnBack;

  const CommonScaffold({
    super.key,
    required this.title,
    required this.child,
    this.numberOfPopsOnBack = 1,
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
      ),
      body: SafeArea(
        child: child,
      ),
    );
  }
}
