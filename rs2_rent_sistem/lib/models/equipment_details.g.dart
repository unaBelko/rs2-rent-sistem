// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'equipment_details.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$EquipmentDetailsImpl _$$EquipmentDetailsImplFromJson(
        Map<String, dynamic> json) =>
    _$EquipmentDetailsImpl(
      id: json['id'] as String? ?? '',
      itemName: json['itemName'] as String? ?? '',
      manufacturer: json['manufacturer'] as String? ?? '',
      imageUrl: json['imageUrl'] as String? ?? '',
      minQuantity: (json['minQuantity'] as num?)?.toInt() ?? 1,
      maxQuantity: (json['maxQuantity'] as num?)?.toInt() ?? 1,
      availableDatesForRent: (json['availableDatesForRent'] as List<dynamic>?)
              ?.map((e) => DateTime.parse(e as String))
              .toList() ??
          const [],
      description: json['description'] as String? ?? '',
      costPerUse: (json['costPerUse'] as num?)?.toDouble() ?? 0.0,
      isInCart: json['isInCart'] as bool? ?? false,
    );

Map<String, dynamic> _$$EquipmentDetailsImplToJson(
        _$EquipmentDetailsImpl instance) =>
    <String, dynamic>{
      'id': instance.id,
      'itemName': instance.itemName,
      'manufacturer': instance.manufacturer,
      'imageUrl': instance.imageUrl,
      'minQuantity': instance.minQuantity,
      'maxQuantity': instance.maxQuantity,
      'availableDatesForRent': instance.availableDatesForRent
          .map((e) => e.toIso8601String())
          .toList(),
      'description': instance.description,
      'costPerUse': instance.costPerUse,
      'isInCart': instance.isInCart,
    };
