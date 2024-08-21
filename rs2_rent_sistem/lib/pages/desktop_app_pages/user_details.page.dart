import 'dart:developer';

import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/models/review_for_admin.dart';
import 'package:rs2_rent_sistem/models/user_order_list_item.dart';
import 'package:rs2_rent_sistem/shared/widgets/common_scaffold.dart';
import 'package:rs2_rent_sistem/shared/widgets/confirmation_modal.dart';

class UserDetailsPage extends ConsumerStatefulWidget {
  const UserDetailsPage({super.key});

  @override
  ConsumerState<ConsumerStatefulWidget> createState() => _UserDetailsPageState();
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
          child: Column(
            children: [
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  const Text(
                    'userid123',
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
                                    content: "Da li ste sigurni da zelite deaktivirati ovog korisnika?",
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
              const Row(
                children: [
                  Text(
                    'Una Belko',
                    style: TextStyle(
                      fontWeight: FontWeight.w600,
                    ),
                  ),
                ],
              ),
              const Row(
                children: [
                  Text(
                    'ube@fty.com',
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
                  UserTabButton(
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
                  UserTabButton(
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
                        UserOrderListItemWidget(
                          item: UserOrderListItem(
                            id: '0',
                            dateOfCreation: DateTime.now().toString(),
                            price: 200,
                            numberOfItems: 10,
                            status: "placeno",
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
                                flex: 1,
                                child: Text(
                                  'id',
                                ),
                              ),
                              Expanded(
                                  flex: 2,
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
                            ],
                          ),
                        ),
                        UserReviewWidget(
                          item: ReviewForAdmin(
                            id: '1',
                            content: "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. ",
                            equipmentName: 'lopticaaa',
                            dateOfCreation: DateTime.now().toLocal(),
                          ),
                        ),
                        UserReviewWidget(
                          item: ReviewForAdmin(
                            id: '1',
                            content: "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. ",
                            equipmentName: 'lopticaaa',
                            dateOfCreation: DateTime.now().toLocal(),
                          ),
                        ),
                        UserReviewWidget(
                          item: ReviewForAdmin(
                            id: '1',
                            content: "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. ",
                            equipmentName: 'lopticaaa',
                            dateOfCreation: DateTime.now().toLocal(),
                          ),
                        ),
                      ],
                    ),
            ],
          ),
        ),
      ),
    );
  }
}

class UserTabButton extends StatelessWidget {
  final String text;
  final bool isSelected;
  final VoidCallback onTap;
  const UserTabButton({
    super.key,
    required this.text,
    required this.isSelected,
    required this.onTap,
  });

  @override
  Widget build(BuildContext context) {
    return GestureDetector(
      onTap: onTap,
      child: Container(
        padding: const EdgeInsets.symmetric(vertical: 10.0, horizontal: 20.0),
        decoration: BoxDecoration(
          color: isSelected ? Colors.blueGrey : Colors.white,
          borderRadius: BorderRadius.circular(30.0),
          border: Border.all(
            color: Colors.blueGrey,
          ),
        ),
        child: Text(
          text,
          style: TextStyle(
            color: isSelected ? Colors.white : Colors.blueGrey,
            fontWeight: FontWeight.bold,
          ),
        ),
      ),
    );
  }
}

class UserOrderListItemWidget extends StatelessWidget {
  final UserOrderListItem item;
  const UserOrderListItemWidget({super.key, required this.item});

  @override
  Widget build(BuildContext context) {
    return Card(
      child: Padding(
        padding: const EdgeInsets.symmetric(
          horizontal: 12.0,
          vertical: 10,
        ),
        child: Row(
          children: [
            Expanded(
              flex: 1,
              child: Text(
                item.id,
              ),
            ),
            Expanded(
                flex: 3,
                child: Text(
                  item.dateOfCreation,
                )),
            Expanded(
              flex: 1,
              child: Text(
                item.numberOfItems.toString(),
              ),
            ),
            Expanded(
              flex: 1,
              child: Text(
                item.price.toString(),
              ),
            ),
            Expanded(
              flex: 1,
              child: Text(
                item.status,
              ),
            ),
          ],
        ),
      ),
    );
  }
}

class UserReviewWidget extends StatelessWidget {
  final ReviewForAdmin item;
  const UserReviewWidget({
    super.key,
    required this.item,
  });

  @override
  Widget build(BuildContext context) {
    return Card(
      child: Padding(
        padding: const EdgeInsets.symmetric(
          horizontal: 12.0,
          vertical: 10,
        ),
        child: Row(
          children: [
            Expanded(
              flex: 1,
              child: Text(
                item.id,
              ),
            ),
            Expanded(
              flex: 2,
              child: Text(
                item.dateOfCreation.toString(),
              ),
            ),
            Expanded(
              flex: 4,
              child: Text(
                item.content,
                style: TextStyle(
                  fontStyle: FontStyle.italic,
                ),
              ),
            ),
            Expanded(
              flex: 2,
              child: Text(
                item.equipmentName ?? "",
              ),
            ),
          ],
        ),
      ),
    );
  }
}
