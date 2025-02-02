// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'equipment_creation_model.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$EquipmentCreationModelImpl _$$EquipmentCreationModelImplFromJson(
        Map<String, dynamic> json) =>
    _$EquipmentCreationModelImpl(
      itemName: json['itemName'] as String,
      costPerUse: (json['costPerUse'] as num).toDouble(),
      dateAdded: DateTime.parse(json['dateAdded'] as String),
      equipmentCategoryID: (json['equipmentCategoryID'] as num).toInt(),
      manufacturerID: (json['manufacturerID'] as num).toInt(),
      imageUrl: json['imageUrl'] as String? ?? '',
      stockQuantity: (json['stockQuantity'] as num?)?.toInt() ?? 1,
      minQuantity: (json['minQuantity'] as num?)?.toInt() ?? 1,
      maxQuantity: (json['maxQuantity'] as num?)?.toInt() ?? 1,
      description: json['description'] as String? ?? '',
    );

Map<String, dynamic> _$$EquipmentCreationModelImplToJson(
        _$EquipmentCreationModelImpl instance) =>
    <String, dynamic>{
      'itemName': instance.itemName,
      'costPerUse': instance.costPerUse,
      'dateAdded': instance.dateAdded.toIso8601String(),
      'equipmentCategoryID': instance.equipmentCategoryID,
      'manufacturerID': instance.manufacturerID,
      'imageUrl': instance.imageUrl,
      'stockQuantity': instance.stockQuantity,
      'minQuantity': instance.minQuantity,
      'maxQuantity': instance.maxQuantity,
      'description': instance.description,
    };
