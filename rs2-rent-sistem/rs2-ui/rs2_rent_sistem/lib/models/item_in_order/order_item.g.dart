// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'order_item.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$OrderItemImpl _$$OrderItemImplFromJson(Map<String, dynamic> json) =>
    _$OrderItemImpl(
      id: (json['id'] as num).toInt(),
      startDate: DateTime.parse(json['startDate'] as String),
      endDate: DateTime.parse(json['endDate'] as String),
      isReviewedByUser: json['isReviewedByUser'] as bool? ?? false,
      quantity: (json['quantity'] as num?)?.toInt() ?? 0,
      costPerUse: (json['costPerUse'] as num?)?.toDouble() ?? 0,
      price: (json['price'] as num?)?.toDouble() ?? 0,
      equipment: json['equipment'] == null
          ? null
          : EquipmentListItem.fromJson(
              json['equipment'] as Map<String, dynamic>),
    );

Map<String, dynamic> _$$OrderItemImplToJson(_$OrderItemImpl instance) =>
    <String, dynamic>{
      'id': instance.id,
      'startDate': instance.startDate.toIso8601String(),
      'endDate': instance.endDate.toIso8601String(),
      'isReviewedByUser': instance.isReviewedByUser,
      'quantity': instance.quantity,
      'costPerUse': instance.costPerUse,
      'price': instance.price,
      'equipment': instance.equipment,
    };
