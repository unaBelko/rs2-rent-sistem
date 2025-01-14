// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'equipment_list.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$EquipmentListImpl _$$EquipmentListImplFromJson(Map<String, dynamic> json) =>
    _$EquipmentListImpl(
      result: (json['result'] as List<dynamic>?)
              ?.map(
                  (e) => EquipmentListItem.fromJson(e as Map<String, dynamic>))
              .toList() ??
          const [],
      count: (json['count'] as num).toInt(),
    );

Map<String, dynamic> _$$EquipmentListImplToJson(_$EquipmentListImpl instance) =>
    <String, dynamic>{
      'result': instance.result,
      'count': instance.count,
    };
