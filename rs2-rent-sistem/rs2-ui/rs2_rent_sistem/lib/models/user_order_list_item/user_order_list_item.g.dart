// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'user_order_list_item.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$UserOrderListItemImpl _$$UserOrderListItemImplFromJson(
        Map<String, dynamic> json) =>
    _$UserOrderListItemImpl(
      id: json['id'] as String? ?? '',
      dateOfCreation: json['dateOfCreation'] as String? ?? '',
      price: (json['price'] as num?)?.toDouble() ?? 0.0,
      numberOfItems: (json['numberOfItems'] as num?)?.toInt() ?? 0,
      status: json['status'] as String? ?? '',
    );

Map<String, dynamic> _$$UserOrderListItemImplToJson(
        _$UserOrderListItemImpl instance) =>
    <String, dynamic>{
      'id': instance.id,
      'dateOfCreation': instance.dateOfCreation,
      'price': instance.price,
      'numberOfItems': instance.numberOfItems,
      'status': instance.status,
    };
