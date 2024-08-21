import 'dart:developer';

import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/models/user.dart';
import 'package:rs2_rent_sistem/pages/desktop_app_pages/user_details.page.dart';
import 'package:rs2_rent_sistem/shared/widgets/confirmation_modal.dart';

class UsersPage extends ConsumerStatefulWidget {
  const UsersPage({super.key});

  @override
  ConsumerState<ConsumerStatefulWidget> createState() => _UsersPageState();
}

class _UsersPageState extends ConsumerState<UsersPage> {
  @override
  Widget build(BuildContext context) {
    return const SingleChildScrollView(
      child: Column(
        children: [
          Padding(
            padding: EdgeInsets.symmetric(horizontal: 20.0),
            child: Row(
              children: [
                Expanded(flex: 7, child: Text('Ime i prezime')),
                Expanded(flex: 2, child: Text('Email')),
                Expanded(flex: 1, child: Text('Narudzbe')),
                Expanded(flex: 1, child: Text('Reviews')),
                Expanded(flex: 1, child: Text('Akcije')),
              ],
            ),
          ),
          UserListItem(
            user: User(
              id: '1',
              name: 'Una',
              surname: 'Belko',
              email: 'ube@fty.com',
              numberOfOrders: 12,
              numberOfReviews: 21,
            ),
          ),
          UserListItem(
            user: User(
              id: '1',
              name: 'Una',
              surname: 'Belko',
              email: 'ube@fty.com',
              numberOfOrders: 12,
              numberOfReviews: 21,
            ),
          ),
          UserListItem(
            user: User(
              id: '1',
              name: 'Una',
              surname: 'Belko',
              email: 'ube@fty.com',
              numberOfOrders: 12,
              numberOfReviews: 21,
            ),
          )
        ],
      ),
    );
  }
}

class UserListItem extends StatelessWidget {
  final User user;
  const UserListItem({
    super.key,
    required this.user,
  });

  @override
  Widget build(BuildContext context) {
    return Card(
      child: Padding(
        padding: const EdgeInsets.symmetric(horizontal: 12, vertical: 8),
        child: Row(
          children: [
            Expanded(
              flex: 7,
              child: Wrap(
                crossAxisAlignment: WrapCrossAlignment.center,
                children: [
                  const Icon(Icons.person),
                  Text('${user.name} ${user.surname}'),
                ],
              ),
            ),
            Expanded(
              flex: 2,
              child: Text(user.email),
            ),
            Expanded(
              flex: 1,
              child: Text(
                user.numberOfOrders.toString(),
              ),
            ),
            Expanded(
              flex: 1,
              child: Text(
                user.numberOfReviews.toString(),
              ),
            ),
            Expanded(
              flex: 1,
              child: Wrap(
                children: [
                  IconButton(
                    onPressed: () {
                      Navigator.of(context).push(MaterialPageRoute(builder: (context) => const UserDetailsPage()));
                    },
                    icon: Icon(
                      Icons.info,
                      color: Colors.lightBlue.withOpacity(0.5),
                    ),
                  ),
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
            ),
          ],
        ),
      ),
    );
  }
}
