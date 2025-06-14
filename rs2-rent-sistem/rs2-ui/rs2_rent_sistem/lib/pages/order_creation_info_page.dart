import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/pages/paypal_payment_page.dart';
import 'package:rs2_rent_sistem/shared/providers/cart_providers.dart';
import 'package:rs2_rent_sistem/shared/providers/order_item_providers.dart';
import 'package:rs2_rent_sistem/shared/providers/order_providers.dart';
import 'package:rs2_rent_sistem/shared/widgets/common_scaffold.dart';

class OrderCreationInfoPage extends ConsumerWidget {
  final double amount;

  const OrderCreationInfoPage(this.amount, {super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    ref.invalidate(ordersListProvider);
    ref.invalidate(cartProvider);

    return PopScope(
      canPop: true,
      child: CommonScaffold(
        numberOfPopsOnBack: 2,
        onClose: () {
          ref.invalidate(orderItemsProvider);
          ref.invalidate(cartProvider);
        },
        title: 'Kreiranje rezervacije',
        child: ref.watch(orderCreationProvider).when(
              data: (_) => Center(
                child: Column(
                  mainAxisAlignment: MainAxisAlignment.center,
                  children: [
                    const SizedBox(height: 50),
                    Container(
                      width: 200.0,
                      height: 200.0,
                      decoration: BoxDecoration(
                        shape: BoxShape.circle,
                        border: Border.all(
                          color: Colors.green,
                          width: 6.0,
                        ),
                      ),
                      child: const Center(
                        child: Icon(
                          Icons.check,
                          color: Colors.green,
                          size: 100.0,
                        ),
                      ),
                    ),
                    const SizedBox(height: 50),
                    Padding(
                      padding: const EdgeInsets.symmetric(horizontal: 50.0),
                      child: Text(
                        'Vaša rezervacija je uspjela! Molimo vas da preuzmete opremu na dogovoreni datum! Plaćanje se obavlja uživo, ako ga ne izvršite u sljedećem koraku!',
                        textAlign: TextAlign.center,
                        style: Theme.of(context).textTheme.headlineSmall,
                      ),
                    ),
                    const SizedBox(height: 30),
                    ElevatedButton.icon(
                      onPressed: () async {
                        var res = await Navigator.of(context).push(
                          MaterialPageRoute(
                            builder: (context) =>
                                PaypalPaymentPage(amount: amount),
                          ),
                        );
                        if (res == true) {
                          ref.invalidate(orderItemsProvider);
                          ref.invalidate(cartProvider);
                          Navigator.of(context).pop();
                        }
                      },
                      icon: const Icon(Icons.payment),
                      label: const Text("Plati Online"),
                      style: ElevatedButton.styleFrom(
                        padding: const EdgeInsets.symmetric(
                            horizontal: 24, vertical: 12),
                      ),
                    ),
                  ],
                ),
              ),
              error: (err, st) => const Center(
                child: Text('Order could not be created!'),
              ),
              loading: () => const Center(
                child: CircularProgressIndicator(),
              ),
            ),
      ),
    );
  }
}
