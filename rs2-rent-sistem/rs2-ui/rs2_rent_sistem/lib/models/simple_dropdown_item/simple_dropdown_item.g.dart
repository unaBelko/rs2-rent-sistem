// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'simple_dropdown_item.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$SimpleDropdownItemImpl _$$SimpleDropdownItemImplFromJson(
        Map<String, dynamic> json) =>
    _$SimpleDropdownItemImpl(
      id: (json['id'] as num).toInt(),
      name: json['name'] as String? ?? '',
      description: json['description'] as String? ?? '',
    );

Map<String, dynamic> _$$SimpleDropdownItemImplToJson(
        _$SimpleDropdownItemImpl instance) =>
    <String, dynamic>{
      'id': instance.id,
      'name': instance.name,
      'description': instance.description,
    };
