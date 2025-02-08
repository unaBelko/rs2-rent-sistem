// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'damage.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$DamageImpl _$$DamageImplFromJson(Map<String, dynamic> json) => _$DamageImpl(
      id: (json['id'] as num).toInt(),
      orderItem:
          ItemInOrder.fromJson(json['orderItem'] as Map<String, dynamic>),
      comment: json['comment'] as String? ?? '',
      dateAdded: json['dateAdded'] == null
          ? null
          : DateTime.parse(json['dateAdded'] as String),
    );

Map<String, dynamic> _$$DamageImplToJson(_$DamageImpl instance) =>
    <String, dynamic>{
      'id': instance.id,
      'orderItem': instance.orderItem,
      'comment': instance.comment,
      'dateAdded': instance.dateAdded?.toIso8601String(),
    };
