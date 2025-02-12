import 'dart:developer';
import 'package:flutter/material.dart';
import 'package:flutter_paypal/flutter_paypal.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';

class PaypalPaymentPage extends ConsumerWidget {
  final double amount;

  const PaypalPaymentPage({super.key, required this.amount});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    return UsePaypal(
      sandboxMode: true,
      clientId:
          'AY2OUScscRr96J0OgR0P9z3m9MUIDcf9rL1yQiPDWZ7Km1qctQ3wkrtuNqBhTmx0YyGLK_Hn2HFPJegr',
      secretKey:
          'EEX3oSKJP7U4DLIEwRSwkXFWZ4OfYOby3wIVy3D-h4X8M12YdGShgElb2K7X-MF_K97PQtBOOcTWFx34',
      transactions: [
        {
          "amount": {
            "total": '$amount',
            "currency": "EUR",
            "details": {
              "subtotal": '$amount',
              "shipping": '0',
              "shipping_discount": 0
            }
          },
          "description": "Placanje rezervacije.",
          "item_list": {
            "items": [
              {
                "name": "Rezervacija",
                "quantity": 1,
                "price": '$amount',
                "currency": "EUR"
              }
            ],
            "shipping_address": {
              "recipient_name": "Jane Foster",
              "line1": "Travis County",
              "line2": "",
              "city": "Austin",
              "country_code": "US",
              "postal_code": "73301",
              "phone": "+00000000",
              "state": "Texas"
            },
          }
        }
      ],
      note: "Contact us for any questions on your order.",
      onSuccess: (Map<dynamic, dynamic> params) async {
        log('Uspjesno placanje: $params');
      },
      onError: (dynamic error) {
        log('Placanje nije uspjelo: $error');
      },
      onCancel: () {
        log('Placanje otkazano');
        if (context.mounted) {
          Navigator.pop(context, false);
        }
      },
      returnURL: 'https://samplesite.com/return',
      cancelURL: 'https://samplesite.com/return',
    );
  }
}
