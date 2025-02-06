import 'dart:developer';

import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/pages/desktop_app_pages/tab_button.dart';
import 'package:rs2_rent_sistem/pages/desktop_app_pages/user_order_list_item_widget.dart';
import 'package:rs2_rent_sistem/pages/desktop_app_pages/user_review_widget.dart';
import 'package:rs2_rent_sistem/shared/providers/order_providers.dart';
import 'package:rs2_rent_sistem/shared/providers/review_providers.dart';
import 'package:rs2_rent_sistem/shared/providers/user_providers.dart';
import 'package:rs2_rent_sistem/shared/widgets/common_scaffold.dart';
import 'package:rs2_rent_sistem/shared/widgets/confirmation_modal.dart';

class UserDetailsPage extends ConsumerStatefulWidget {
  final int userId;

  const UserDetailsPage(this.userId, {super.key});

  @override
  ConsumerState<ConsumerStatefulWidget> createState() =>
      _UserDetailsPageState();
}

class _UserDetailsPageState extends ConsumerState<UserDetailsPage> {
  var currentTab = 0;

  @override
  Widget build(BuildContext context) {
    return CommonScaffold(
      title: 'Detalji korisnika',
      child: Padding(
        padding: const EdgeInsets.symmetric(
          horizontal: 20.0,
          vertical: 12.0,
        ),
        child: SingleChildScrollView(
          child: ref.watch(userDetailsProvider(widget.userId)).when(
                data: (data) {
                  return Column(
                    children: [
                      Row(
                        mainAxisAlignment: MainAxisAlignment.spaceBetween,
                        children: [
                          Text(
                            data.id.toString(),
                            style: TextStyle(
                              fontWeight: FontWeight.w700,
                              fontSize: 16,
                            ),
                          ),
                          Wrap(
                            crossAxisAlignment: WrapCrossAlignment.center,
                            children: [
                              const Text('aktivan'),
                              IconButton(
                                onPressed: () {
                                  showDialog(
                                      context: context,
                                      builder: (context) => ConfirmationModal(
                                            title: 'Deaktivacija korisnika',
                                            content:
                                                "Da li ste sigurni da zelite deaktivirati ovog korisnika?",
                                            buttonText: "Deaktiviraj",
                                            onConfirm: () {
                                              log("deaktiviran");
                                            },
                                            isDestructiveAction: true,
                                          ));
                                },
                                icon: const Icon(
                                  Icons.dangerous,
                                  color: Colors.red,
                                ),
                              ),
                            ],
                          ),
                        ],
                      ),
                      const SizedBox(height: 20),
                      Row(
                        children: [
                          Text(
                            '${data.firstName} ${data.lastName}',
                            style: TextStyle(
                              fontWeight: FontWeight.w600,
                            ),
                          ),
                        ],
                      ),
                      Row(
                        children: [
                          Text(
                            data.email,
                            style: TextStyle(
                              color: Colors.blueGrey,
                              fontWeight: FontWeight.w500,
                            ),
                          ),
                        ],
                      ),
                      const SizedBox(
                        height: 20,
                      ),
                      Row(
                        children: [
                          TabButton(
                            text: 'Narudzbe',
                            isSelected: currentTab == 0,
                            onTap: () {
                              setState(() {
                                currentTab = 0;
                              });
                            },
                          ),
                          const SizedBox(
                            width: 8,
                          ),
                          TabButton(
                            text: 'Reviews',
                            isSelected: currentTab == 1,
                            onTap: () {
                              setState(() {
                                currentTab = 1;
                              });
                            },
                          ),
                        ],
                      ),
                      currentTab == 0
                          ? Column(
                              children: [
                                const Padding(
                                  padding: EdgeInsets.all(12.0),
                                  child: Row(
                                    children: [
                                      Expanded(
                                        flex: 1,
                                        child: Text(
                                          'id',
                                        ),
                                      ),
                                      Expanded(
                                          flex: 3,
                                          child: Text(
                                            'Datum kreiranja',
                                          )),
                                      Expanded(
                                        flex: 1,
                                        child: Text(
                                          'Broj stavki',
                                        ),
                                      ),
                                      Expanded(
                                        flex: 1,
                                        child: Text(
                                          'Cijena',
                                        ),
                                      ),
                                      Expanded(
                                        flex: 1,
                                        child: Text(
                                          'Status',
                                        ),
                                      ),
                                    ],
                                  ),
                                ),
                                ref
                                    .watch(ordersListProvider(widget.userId))
                                    .when(
                                      data: (data) => Column(
                                        children: data
                                            .map((el) =>
                                                UserOrderListItemWidget(
                                                    item: el))
                                            .toList(),
                                      ),
                                      error: (e, st) =>
                                          Text('Narudzbe nisu ucitane'),
                                      loading: () => Center(
                                        child: CircularProgressIndicator(),
                                      ),
                                    ),
                              ],
                            )
                          : Column(
                              children: [
                                const Padding(
                                  padding: EdgeInsets.all(12.0),
                                  child: Row(
                                    children: [
                                      Expanded(
                                        flex: 2,
                                        child: Text(
                                          'Rating',
                                        ),
                                      ),
                                      Expanded(
                                          flex: 1,
                                          child: Text(
                                            'Datum kreiranja',
                                          )),
                                      Expanded(
                                        flex: 4,
                                        child: Text(
                                          'Komentar',
                                        ),
                                      ),
                                      Expanded(
                                        flex: 2,
                                        child: Text(
                                          'Proizvod',
                                        ),
                                      ),
                                      Expanded(
                                        flex: 1,
                                        child: Text(
                                          'Akcija',
                                        ),
                                      ),
                                    ],
                                  ),
                                ),
                                ref
                                    .watch(reviewsProvider((
                                      equipmentId: null,
                                      userId: widget.userId
                                    )))
                                    .when(
                                      data: (data) => Column(
                                        children: data
                                            .map((el) =>
                                                UserReviewWidget(item: el))
                                            .toList(),
                                      ),
                                      error: (e, st) =>
                                          Text('Reviews nisu ucitani'),
                                      loading: () => Center(
                                        child: CircularProgressIndicator(),
                                      ),
                                    ),
                              ],
                            ),
                    ],
                  );
                },
                error: (e, st) => Center(
                  child: Text(e.toString()),
                ),
                loading: () => Center(
                  child: CircularProgressIndicator(),
                ),
              ),
        ),
      ),
    );
  }
}
