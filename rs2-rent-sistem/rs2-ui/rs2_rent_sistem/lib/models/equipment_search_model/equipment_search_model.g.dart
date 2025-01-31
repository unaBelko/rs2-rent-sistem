// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'equipment_search_model.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$EquipmentSearchModelImpl _$$EquipmentSearchModelImplFromJson(
        Map<String, dynamic> json) =>
    _$EquipmentSearchModelImpl(
      name: json['name'] as String? ?? '',
      manufacturerID: (json['manufacturerID'] as num?)?.toInt(),
      equipmentCategoryID: (json['equipmentCategoryID'] as num?)?.toInt(),
      sortDescending: json['sortDescending'] as bool? ?? true,
    );

Map<String, dynamic> _$$EquipmentSearchModelImplToJson(
        _$EquipmentSearchModelImpl instance) =>
    <String, dynamic>{
      'name': instance.name,
      'manufacturerID': instance.manufacturerID,
      'equipmentCategoryID': instance.equipmentCategoryID,
      'sortDescending': instance.sortDescending,
    };
