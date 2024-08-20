// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'equipment_list_item.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$EquipmentListItemImpl _$$EquipmentListItemImplFromJson(
        Map<String, dynamic> json) =>
    _$EquipmentListItemImpl(
      id: json['id'] as String? ?? '',
      imageUrl: json['imageUrl'] as String? ?? '',
      itemName: json['itemName'] as String? ?? '',
      manufacturer: json['manufacturer'] as String? ?? '',
      rating: (json['rating'] as num?)?.toDouble() ?? 0.0,
      numberOfReviews: (json['numberOfReviews'] as num?)?.toInt() ?? 0,
      costPerDay: json['costPerDay'] as String? ?? '',
      isInCart: json['isInCart'] as bool? ?? false,
    );

Map<String, dynamic> _$$EquipmentListItemImplToJson(
        _$EquipmentListItemImpl instance) =>
    <String, dynamic>{
      'id': instance.id,
      'imageUrl': instance.imageUrl,
      'itemName': instance.itemName,
      'manufacturer': instance.manufacturer,
      'rating': instance.rating,
      'numberOfReviews': instance.numberOfReviews,
      'costPerDay': instance.costPerDay,
      'isInCart': instance.isInCart,
    };
