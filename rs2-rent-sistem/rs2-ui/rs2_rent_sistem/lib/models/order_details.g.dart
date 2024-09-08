// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'order_details.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$OrderDetailsImpl _$$OrderDetailsImplFromJson(Map<String, dynamic> json) =>
    _$OrderDetailsImpl(
      id: (json['id'] as num).toInt(),
      datePlaced: DateTime.parse(json['datePlaced'] as String),
      totalPrice: (json['totalPrice'] as num?)?.toDouble() ?? 0.0,
    );

Map<String, dynamic> _$$OrderDetailsImplToJson(_$OrderDetailsImpl instance) =>
    <String, dynamic>{
      'id': instance.id,
      'datePlaced': instance.datePlaced.toIso8601String(),
      'totalPrice': instance.totalPrice,
    };
