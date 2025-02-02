import 'dart:developer';

import 'package:flutter/material.dart';
import 'package:flutter_paypal/flutter_paypal.dart';
import 'package:rs2_rent_sistem/shared/widgets/common_scaffold.dart';

class PaypalPaymentPage extends StatelessWidget {
  final double amount;

  const PaypalPaymentPage({super.key, required this.amount});

  @override
  Widget build(BuildContext context) {
    return CommonScaffold(
      title: 'Placanje',
      child: UsePaypal(
        sandboxMode: true,
        clientId:
            'AXSDXgrU-Y1SA2D66batXQ9Y0u6M2ICYF-ZUThLq2E7QpL3_L_n2QPyDyUx0kofBlHyVI4pdvqwrZJ7K',
        secretKey:
            'EGRa16KzlCDGqwkCbRTcu-Zj7HLsDF9iUGOuque9g2G2FHzsYt7C69oepVrKm9XZVKsGPJNVUDwKpPuM',
        transactions: const [
          {
            "amount": {
              "total": '10.12',
              "currency": "EUR",
              "details": {
                "subtotal": '10.12',
                "shipping": '0',
                "shipping_discount": 0
              }
            },
            "description": "Placanje rezervacije.",
            // "payment_options": {
            //   "allowed_payment_method":
            //       "INSTANT_FUNDING_SOURCE"
            // },
            "item_list": {
              "items": [
                {
                  "name": "A demo product",
                  "quantity": 1,
                  "price": '10.12',
                  "currency": "EUR"
                }
              ],

              // shipping address is not required though
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
        onSuccess: (Map params) async {
          print("onSuccess: $params");
          log('uspjelooo');
        },
        onError: (error) {
          print("onError: $error");
          log('hapeninggg');
          Navigator.of(context).pop();
        },
        onCancel: () {
          print('cancelled:');
        },
        returnURL: 'https://samplesite.com/return',
        cancelURL: 'https://samplesite.com/return',
      ),
    );
  }
}
