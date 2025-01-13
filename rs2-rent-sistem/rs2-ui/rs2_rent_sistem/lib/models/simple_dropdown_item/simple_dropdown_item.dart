import 'package:freezed_annotation/freezed_annotation.dart';

part 'simple_dropdown_item.freezed.dart';
part 'simple_dropdown_item.g.dart';

@Freezed()
class SimpleDropdownItem with _$SimpleDropdownItem {
  const factory SimpleDropdownItem({
    required int id,
    @Default('') String name,
    @Default('') String description,
  }) = _SimpleDropdownItem;

  factory SimpleDropdownItem.fromJson(Map<String, dynamic> json) => _$SimpleDropdownItemFromJson(json);
}
