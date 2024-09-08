// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'order_list_item.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$OrderListItemImpl _$$OrderListItemImplFromJson(Map<String, dynamic> json) =>
    _$OrderListItemImpl(
      id: (json['id'] as num).toInt(),
      datePlaced: DateTime.parse(json['datePlaced'] as String),
      totalPrice: (json['totalPrice'] as num?)?.toDouble() ?? 0.0,
    );

Map<String, dynamic> _$$OrderListItemImplToJson(_$OrderListItemImpl instance) =>
    <String, dynamic>{
      'id': instance.id,
      'datePlaced': instance.datePlaced.toIso8601String(),
      'totalPrice': instance.totalPrice,
    };
