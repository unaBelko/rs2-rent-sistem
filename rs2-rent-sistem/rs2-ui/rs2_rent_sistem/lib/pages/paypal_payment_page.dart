import 'dart:convert';
import 'dart:developer';

import 'package:flutter/material.dart';
import 'package:flutter_inappwebview/flutter_inappwebview.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:http/http.dart' as http;

class PaypalPaymentPage extends ConsumerStatefulWidget {
  final double amount;

  const PaypalPaymentPage({super.key, required this.amount});

  @override
  ConsumerState<PaypalPaymentPage> createState() => _PaypalPaymentPageState();
}

class _PaypalPaymentPageState extends ConsumerState<PaypalPaymentPage> {
  bool isLoading = true;
  String? approvalUrl;
  InAppWebViewController? webViewController;

  final String clientId =
      'AY2OUScscRr96J0OgR0P9z3m9MUIDcf9rL1yQiPDWZ7Km1qctQ3wkrtuNqBhTmx0YyGLK_Hn2HFPJegr';
  final String clientSecret =
      'EEX3oSKJP7U4DLIEwRSwkXFWZ4OfYOby3wIVy3D-h4X8M12YdGShgElb2K7X-MF_K97PQtBOOcTWFx34';
  final String _paypalBaseUrl = 'https://api.sandbox.paypal.com';

  @override
  void initState() {
    super.initState();
    _startPaymentProcess();
  }

  Future<void> _startPaymentProcess() async {
    try {
      final accessToken = await _getAccessToken();
      approvalUrl = await _createOrder(accessToken, widget.amount);
      setState(() => isLoading = false);
    } catch (e) {
      log("Error during PayPal payment process: $e");
    }
  }

  Future<String> _getAccessToken() async {
    final response = await http.post(
      Uri.parse('$_paypalBaseUrl/v1/oauth2/token'),
      headers: {
        'Authorization':
            'Basic ${base64Encode(utf8.encode('$clientId:$clientSecret'))}',
        'Content-Type': 'application/x-www-form-urlencoded',
      },
      body: 'grant_type=client_credentials',
    );

    if (response.statusCode == 200) {
      final data = jsonDecode(response.body);
      return data['access_token'];
    } else {
      throw Exception('Failed to obtain PayPal access token');
    }
  }

  Future<String> _createOrder(String accessToken, double total) async {
    final response = await http.post(
      Uri.parse('$_paypalBaseUrl/v2/checkout/orders'),
      headers: {
        'Content-Type': 'application/json',
        'Authorization': 'Bearer $accessToken',
      },
      body: jsonEncode({
        'intent': 'CAPTURE',
        'purchase_units': [
          {
            'amount': {
              'currency_code': 'EUR',
              'value': widget.amount.toStringAsFixed(2),
            },
          },
        ],
        'application_context': {
          'return_url': 'https://samplesite.com/return',
          'cancel_url': 'https://samplesite.com/return',
        }
      }),
    );

    if (response.statusCode == 201) {
      final data = jsonDecode(response.body);
      return data['links']
          .firstWhere((link) => link['rel'] == 'approve')['href'];
    } else {
      throw Exception('Failed to create PayPal order');
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: const Text("PayPal Payment")),
      body: isLoading
          ? const Center(child: CircularProgressIndicator())
          : InAppWebView(
              initialUrlRequest: URLRequest(url: WebUri(approvalUrl!)),
              initialOptions: InAppWebViewGroupOptions(
                crossPlatform: InAppWebViewOptions(
                  javaScriptEnabled: true,
                ),
              ),
              onWebViewCreated: (controller) => webViewController = controller,
              onLoadStop: (controller, url) {
                if (url == null) return;

                if (url.toString().contains('samplesite')) {
                  log('✅ Payment completed at: $url');
                  if (context.mounted) {
                    Navigator.of(context).pop(true);
                  }
                }
              },
              onLoadError: (controller, url, code, message) {
                log('❌ WebView load error: $message');
                if (context.mounted) Navigator.pop(context, false);
              },
            ),
    );
  }
}
