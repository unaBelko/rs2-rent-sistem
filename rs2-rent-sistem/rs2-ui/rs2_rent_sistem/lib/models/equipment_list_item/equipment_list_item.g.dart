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
      costPerUse: (json['costPerUse'] as num?)?.toDouble() ?? 0.0,
      manufacturer: json['manufacturer'] as String? ?? '',
      averageRating: (json['averageRating'] as num?)?.toDouble() ?? 0.0,
      stockQuantity: (json['stockQuantity'] as num?)?.toInt() ?? 0,
      photo: json['photo'] as String? ?? '',
    );

Map<String, dynamic> _$$EquipmentListItemImplToJson(
        _$EquipmentListItemImpl instance) =>
    <String, dynamic>{
      'id': instance.id,
      'itemName': instance.itemName,
      'costPerUse': instance.costPerUse,
      'manufacturer': instance.manufacturer,
      'averageRating': instance.averageRating,
      'stockQuantity': instance.stockQuantity,
      'photo': instance.photo,
    };
