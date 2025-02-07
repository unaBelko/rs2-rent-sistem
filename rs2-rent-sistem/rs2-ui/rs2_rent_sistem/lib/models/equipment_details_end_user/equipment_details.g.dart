// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'equipment_details.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$EquipmentDetailsImpl _$$EquipmentDetailsImplFromJson(
        Map<String, dynamic> json) =>
    _$EquipmentDetailsImpl(
      id: (json['id'] as num).toInt(),
      itemName: json['itemName'] as String? ?? '',
      manufacturerID: json['manufacturerID'] as String? ?? '',
      equipmentCategoryID: json['equipmentCategoryID'] as String? ?? '',
      imageUrl: json['imageUrl'] as String? ?? '',
      minQuantity: (json['minQuantity'] as num?)?.toInt() ?? 1,
      maxQuantity: (json['maxQuantity'] as num?)?.toInt() ?? 1,
      description: json['description'] as String? ?? '',
      costPerUse: (json['costPerUse'] as num?)?.toDouble() ?? 0.0,
      averageRating: (json['averageRating'] as num?)?.toDouble() ?? 0.0,
      manufacturer: json['manufacturer'] as String? ?? '',
      equipmentCategory: json['equipmentCategory'] as String? ?? '',
      availableDatesForRent: (json['availableDatesForRent'] as List<dynamic>?)
              ?.map((e) => DateTime.parse(e as String))
              .toList() ??
          const [],
      isInCart: json['isInCart'] as bool? ?? false,
    );

Map<String, dynamic> _$$EquipmentDetailsImplToJson(
        _$EquipmentDetailsImpl instance) =>
    <String, dynamic>{
      'id': instance.id,
      'itemName': instance.itemName,
      'manufacturerID': instance.manufacturerID,
      'equipmentCategoryID': instance.equipmentCategoryID,
      'imageUrl': instance.imageUrl,
      'minQuantity': instance.minQuantity,
      'maxQuantity': instance.maxQuantity,
      'description': instance.description,
      'costPerUse': instance.costPerUse,
      'averageRating': instance.averageRating,
      'manufacturer': instance.manufacturer,
      'equipmentCategory': instance.equipmentCategory,
      'availableDatesForRent': instance.availableDatesForRent
          .map((e) => e.toIso8601String())
          .toList(),
      'isInCart': instance.isInCart,
    };
