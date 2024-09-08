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
      quantity: (json['quantity'] as num?)?.toInt() ?? 0,
      costPerUse: (json['costPerUse'] as num?)?.toDouble() ?? 0,
      equipment:
          EquipmentListItem.fromJson(json['equipment'] as Map<String, dynamic>),
    );

Map<String, dynamic> _$$OrderItemImplToJson(_$OrderItemImpl instance) =>
    <String, dynamic>{
      'id': instance.id,
      'startDate': instance.startDate.toIso8601String(),
      'endDate': instance.endDate.toIso8601String(),
      'quantity': instance.quantity,
      'costPerUse': instance.costPerUse,
      'equipment': instance.equipment,
    };
