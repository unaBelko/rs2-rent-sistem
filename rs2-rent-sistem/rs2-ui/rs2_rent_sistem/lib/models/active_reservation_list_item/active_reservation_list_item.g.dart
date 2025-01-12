// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'active_reservation_list_item.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$ActiveReservationListItemImpl _$$ActiveReservationListItemImplFromJson(
        Map<String, dynamic> json) =>
    _$ActiveReservationListItemImpl(
      id: json['id'] as String? ?? '',
      name: json['name'] as String? ?? '',
      size: json['size'] as String? ?? '',
      quantity: json['quantity'] as String? ?? '',
      formattedReservationDate:
          json['formattedReservationDate'] as String? ?? '',
      status: json['status'] as String? ?? '',
      formattedPrice: json['formattedPrice'] as String? ?? '',
      imageUrl: json['imageUrl'] as String? ?? '',
    );

Map<String, dynamic> _$$ActiveReservationListItemImplToJson(
        _$ActiveReservationListItemImpl instance) =>
    <String, dynamic>{
      'id': instance.id,
      'name': instance.name,
      'size': instance.size,
      'quantity': instance.quantity,
      'formattedReservationDate': instance.formattedReservationDate,
      'status': instance.status,
      'formattedPrice': instance.formattedPrice,
      'imageUrl': instance.imageUrl,
    };
