// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'equipment_list_item.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$EquipmentListItemImpl _$$EquipmentListItemImplFromJson(
        Map<String, dynamic> json) =>
    _$EquipmentListItemImpl(
      id: (json['id'] as num).toInt(),
      itemName: json['itemName'] as String? ?? '',
      imageUrl: json['imageUrl'] as String? ?? '',
      costPerUse: (json['costPerUse'] as num?)?.toDouble() ?? 0.0,
      manufacturer: json['manufacturer'] as String? ?? '',
      stockQuantity: (json['stockQuantity'] as num?)?.toInt() ?? 0,
    );

Map<String, dynamic> _$$EquipmentListItemImplToJson(
        _$EquipmentListItemImpl instance) =>
    <String, dynamic>{
      'id': instance.id,
      'itemName': instance.itemName,
      'imageUrl': instance.imageUrl,
      'costPerUse': instance.costPerUse,
      'manufacturer': instance.manufacturer,
      'stockQuantity': instance.stockQuantity,
    };
