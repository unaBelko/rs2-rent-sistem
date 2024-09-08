import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/shared/providers/order_providers.dart';
import 'package:rs2_rent_sistem/shared/widgets/common_scaffold.dart';

class OrderCreationInfoPage extends ConsumerWidget {
  const OrderCreationInfoPage({super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    return CommonScaffold(
      numberOfPopsOnBack: 2,
      title: 'Order creation',
      child: ref.watch(orderCreationProvider).when(
            data: (_) => Center(
              child: Column(
                children: [
                  const SizedBox(
                    height: 50,
                  ),
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
                  const SizedBox(
                    height: 50,
                  ),
                  Padding(
                    padding: const EdgeInsets.symmetric(horizontal: 50.0),
                    child: Text(
                      'Your reservation was successfull! Please pick it up on selected date!',
                      textAlign: TextAlign.center,
                      style: Theme.of(context).textTheme.headlineSmall,
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
    );
  }
}
