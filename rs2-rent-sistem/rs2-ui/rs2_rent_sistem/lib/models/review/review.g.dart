// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'review.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$ReviewImpl _$$ReviewImplFromJson(Map<String, dynamic> json) => _$ReviewImpl(
      id: (json['id'] as num).toInt(),
      orderItem:
          ItemInOrder.fromJson(json['orderItem'] as Map<String, dynamic>),
      description: json['description'] as String? ?? '',
      dateAdded: json['dateAdded'] == null
          ? null
          : DateTime.parse(json['dateAdded'] as String),
      numberOfStars: (json['numberOfStars'] as num).toDouble(),
    );

Map<String, dynamic> _$$ReviewImplToJson(_$ReviewImpl instance) =>
    <String, dynamic>{
      'id': instance.id,
      'orderItem': instance.orderItem,
      'description': instance.description,
      'dateAdded': instance.dateAdded?.toIso8601String(),
      'numberOfStars': instance.numberOfStars,
    };
