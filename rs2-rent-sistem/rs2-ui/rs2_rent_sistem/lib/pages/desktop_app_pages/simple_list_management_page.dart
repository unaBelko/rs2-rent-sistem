import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:rs2_rent_sistem/models/simple_dropdown_item/simple_dropdown_item.dart';
import 'package:rs2_rent_sistem/pages/desktop_app_pages/add_edit_simple_list_item_page.dart';
import 'package:rs2_rent_sistem/shared/providers/simple_list_management_providers.dart';
import 'package:rs2_rent_sistem/shared/utilities/enumerations.dart';
import 'package:rs2_rent_sistem/shared/widgets/confirmation_modal.dart';
import 'package:rs2_rent_sistem/shared/widgets/rent_system_button.dart';

class SimpleListManagementPage extends ConsumerStatefulWidget {
  final SimpleListType listType;

  const SimpleListManagementPage(this.listType, {super.key});

  @override
  ConsumerState<SimpleListManagementPage> createState() => _SimpleListManagementPageState();
}

class _SimpleListManagementPageState extends ConsumerState<SimpleListManagementPage> {
  @override
  Widget build(BuildContext context) {
    return SingleChildScrollView(
      child: Column(
        children: [
          Padding(
            padding: const EdgeInsets.all(8.0),
            child: Row(
              mainAxisAlignment: MainAxisAlignment.end,
              children: [
                RentSystemButton(
                  label: 'Dodaj',
                  onTap: () {
                    Navigator.of(context).push(
                      MaterialPageRoute(
                        builder: (context) => AddOrEditSimpleListItemPage(
                          type: widget.listType,
                        ),
                      ),
                    );
                  },
                  icon: const Icon(
                    Icons.add,
                    color: Colors.white,
                  ),
                ),
              ],
            ),
          ),
          Padding(
            padding: const EdgeInsets.symmetric(
              horizontal: 20.0,
              vertical: 8.0,
            ),
            child: Row(
              children: [
                Expanded(
                  flex: 1,
                  child: Text(
                    'ID',
                  ),
                ),
                Expanded(
                  flex: 2,
                  child: Text('Naziv'),
                ),
                Expanded(
                  flex: 5,
                  child: Text('Opis'),
                ),
                Expanded(
                  flex: 2,
                  child: Text('Akcije'),
                ),
              ],
            ),
          ),
          Padding(
            padding: const EdgeInsets.symmetric(horizontal: 12.0, vertical: 20.0),
            child: ref.watch(simpleListProvider(widget.listType)).when(
                  data: (items) => Column(
                    children: items
                        .map((item) => SimpleListItem(
                              item: item,
                              type: widget.listType,
                            ))
                        .toList(),
                  ),
                  error: (err, st) => Text('Error: $err'),
                  loading: () => const Center(
                    child: CircularProgressIndicator(),
                  ),
                ),
          ),
        ],
      ),
    );
  }
}

class SimpleListItem extends ConsumerWidget {
  final SimpleDropdownItem item;
  final SimpleListType type;

  const SimpleListItem({super.key, required this.item, required this.type});

  @override
  Widget build(BuildContext context, WidgetRef ref) {
    return Card(
      child: Padding(
        padding: const EdgeInsets.symmetric(horizontal: 20.0, vertical: 8.0),
        child: Row(
          children: [
            Expanded(
              flex: 1,
              child: Text(
                item.id.toString(),
              ),
            ),
            Expanded(
              flex: 2,
              child: Text(item.name),
            ),
            Expanded(
              flex: 5,
              child: Text(item.description),
            ),
            Expanded(
              flex: 2,
              child: Row(
                children: [
                  IconButton(
                    onPressed: () {
                      showDialog(
                          context: context,
                          builder: (context) => ConfirmationModal(
                                title: type == SimpleListType.manufacturer
                                    ? 'Deaktivacija proizvođača'
                                    : 'Deaktivacija kategorije',
                                content: type == SimpleListType.manufacturer
                                    ? "Da li ste sigurni da zelite deaktivirati ovog proizvođača? Brisanjem ćete ukloniti ovog proizvođača kao opciju kod kreiranja novog proizvoda."
                                    : "Da li ste sigurni da zelite deaktivirati ovu kategoriju?",
                                buttonText: "Deaktiviraj",
                                onConfirm: () {
                                  ref.read(deleteSimpleListItemProvider({'type': type, 'id': item.id}).future)
                                      .then((_) {
                                    ref.invalidate(simpleListProvider(type));
                                    ScaffoldMessenger.of(context).showSnackBar(
                                      SnackBar(
                                        content: Text(
                                          type == SimpleListType.manufacturer
                                              ? 'Proizvođač je uspješno deaktiviran.'
                                              : 'Kategorija je uspješno deaktivirana.',
                                        ),
                                      ),
                                    );
                                  }).catchError((error) {
                                    ScaffoldMessenger.of(context).showSnackBar(
                                      SnackBar(
                                        content: Text('Greška: ${error.toString()}'),
                                      ),
                                    );
                                  });
                                },
                                isDestructiveAction: true,
                              ));
                    },
                    icon: const Icon(
                      Icons.dangerous,
                      color: Colors.red,
                    ),
                  ),
                  IconButton(
                    onPressed: () {
                      Navigator.of(context).push(
                        MaterialPageRoute(
                          builder: (context) => AddOrEditSimpleListItemPage(item: item, type: type),
                        ),
                      );
                    },
                    icon: const Icon(
                      Icons.edit,
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
