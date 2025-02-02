// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'available_date.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$AvailableDateImpl _$$AvailableDateImplFromJson(Map<String, dynamic> json) =>
    _$AvailableDateImpl(
      date: DateTime.parse(json['date'] as String),
      quantity: json['quantity'] ?? 0,
    );

Map<String, dynamic> _$$AvailableDateImplToJson(_$AvailableDateImpl instance) =>
    <String, dynamic>{
      'date': instance.date.toIso8601String(),
      'quantity': instance.quantity,
    };
