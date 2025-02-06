// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'review.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$ReviewImpl _$$ReviewImplFromJson(Map<String, dynamic> json) => _$ReviewImpl(
      id: (json['id'] as num).toInt(),
      dateAdded: DateTime.parse(json['dateAdded'] as String),
      numberOfStars: (json['numberOfStars'] as num).toDouble(),
      orderItemID: (json['orderItemID'] as num).toInt(),
      description: json['description'] as String? ?? '',
    );

Map<String, dynamic> _$$ReviewImplToJson(_$ReviewImpl instance) =>
    <String, dynamic>{
      'id': instance.id,
      'dateAdded': instance.dateAdded.toIso8601String(),
      'numberOfStars': instance.numberOfStars,
      'orderItemID': instance.orderItemID,
      'description': instance.description,
    };
