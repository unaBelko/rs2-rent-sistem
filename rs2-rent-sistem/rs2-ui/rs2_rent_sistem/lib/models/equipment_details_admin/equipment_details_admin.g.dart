// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'equipment_details_admin.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$EquipmentDetailsAdminImpl _$$EquipmentDetailsAdminImplFromJson(
        Map<String, dynamic> json) =>
    _$EquipmentDetailsAdminImpl(
      id: (json['id'] as num).toInt(),
      itemName: json['itemName'] as String? ?? '',
      manufacturerID: json['manufacturerID'] as String? ?? '',
      equipmentCategoryID: json['equipmentCategoryID'] as String? ?? '',
      imageUrl: json['imageUrl'] as String? ?? '',
      minQuantity: (json['minQuantity'] as num?)?.toInt() ?? 1,
      maxQuantity: (json['maxQuantity'] as num?)?.toInt() ?? 1,
      stockQuantity: (json['stockQuantity'] as num?)?.toInt() ?? 1,
      description: json['description'] as String? ?? '',
      costPerUse: (json['costPerUse'] as num?)?.toDouble() ?? 0.0,
      dateAdded: DateTime.parse(json['dateAdded'] as String),
      photoBase64: json['photoBase64'] as String? ?? '',
    );

Map<String, dynamic> _$$EquipmentDetailsAdminImplToJson(
        _$EquipmentDetailsAdminImpl instance) =>
    <String, dynamic>{
      'id': instance.id,
      'itemName': instance.itemName,
      'manufacturerID': instance.manufacturerID,
      'equipmentCategoryID': instance.equipmentCategoryID,
      'imageUrl': instance.imageUrl,
      'minQuantity': instance.minQuantity,
      'maxQuantity': instance.maxQuantity,
      'stockQuantity': instance.stockQuantity,
      'description': instance.description,
      'costPerUse': instance.costPerUse,
      'dateAdded': instance.dateAdded.toIso8601String(),
      'photoBase64': instance.photoBase64,
    };
