// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'order_list_item.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$AdminOrderListItemModelImpl _$$AdminOrderListItemModelImplFromJson(
        Map<String, dynamic> json) =>
    _$AdminOrderListItemModelImpl(
      id: (json['id'] as num).toInt(),
      datePlaced: DateTime.parse(json['datePlaced'] as String),
      totalPrice: (json['totalPrice'] as num?)?.toDouble() ?? 0.0,
      status: json['status'] as String? ?? '',
      firstName: json['firstName'] as String? ?? '',
      lastName: json['lastName'] as String? ?? '',
      orderItems: (json['orderItems'] as List<dynamic>?)
              ?.map((e) => ItemInOrder.fromJson(e as Map<String, dynamic>))
              .toList() ??
          const [],
    );

Map<String, dynamic> _$$AdminOrderListItemModelImplToJson(
        _$AdminOrderListItemModelImpl instance) =>
    <String, dynamic>{
      'id': instance.id,
      'datePlaced': instance.datePlaced.toIso8601String(),
      'totalPrice': instance.totalPrice,
      'status': instance.status,
      'firstName': instance.firstName,
      'lastName': instance.lastName,
      'orderItems': instance.orderItems,
    };
