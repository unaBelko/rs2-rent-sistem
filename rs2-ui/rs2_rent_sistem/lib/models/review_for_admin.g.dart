// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'review_for_admin.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$ReviewForAdminImpl _$$ReviewForAdminImplFromJson(Map<String, dynamic> json) =>
    _$ReviewForAdminImpl(
      id: json['id'] as String? ?? '',
      equipmentName: json['equipmentName'] as String?,
      content: json['content'] as String? ?? '',
      dateOfCreation: json['dateOfCreation'] == null
          ? null
          : DateTime.parse(json['dateOfCreation'] as String),
    );

Map<String, dynamic> _$$ReviewForAdminImplToJson(
        _$ReviewForAdminImpl instance) =>
    <String, dynamic>{
      'id': instance.id,
      'equipmentName': instance.equipmentName,
      'content': instance.content,
      'dateOfCreation': instance.dateOfCreation?.toIso8601String(),
    };
