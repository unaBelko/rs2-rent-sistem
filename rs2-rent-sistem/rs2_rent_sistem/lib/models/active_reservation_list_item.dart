import 'package:freezed_annotation/freezed_annotation.dart';

part 'active_reservation_list_item.freezed.dart';
part 'active_reservation_list_item.g.dart';

@Freezed()
class ActiveReservationListItem with _$ActiveReservationListItem {
  const factory ActiveReservationListItem({
    @Default('') String id,
    @Default('') String name,
    @Default('') String size,
    @Default('') String quantity,
    @Default('') String formattedReservationDate,
    @Default('') String status,
    @Default('') String formattedPrice,
    @Default('') String imageUrl,
  }) = _ActiveReservationListItem;

  factory ActiveReservationListItem.fromJson(Map<String, dynamic> json) => _$ActiveReservationListItemFromJson(json);
}
