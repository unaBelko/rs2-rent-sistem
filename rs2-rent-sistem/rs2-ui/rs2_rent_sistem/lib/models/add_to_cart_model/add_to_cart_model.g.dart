// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'add_to_cart_model.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$AddToCartModelImpl _$$AddToCartModelImplFromJson(Map<String, dynamic> json) =>
    _$AddToCartModelImpl(
      quantity: (json['quantity'] as num).toInt(),
      startDate: DateTime.parse(json['startDate'] as String),
      endDate: DateTime.parse(json['endDate'] as String),
      equipmentID: (json['equipmentID'] as num).toInt(),
    );

Map<String, dynamic> _$$AddToCartModelImplToJson(
        _$AddToCartModelImpl instance) =>
    <String, dynamic>{
      'quantity': instance.quantity,
      'startDate': instance.startDate.toIso8601String(),
      'endDate': instance.endDate.toIso8601String(),
      'equipmentID': instance.equipmentID,
    };
