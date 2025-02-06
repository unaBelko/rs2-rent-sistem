// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'review_search_model.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$ReviewSearchModelImpl _$$ReviewSearchModelImplFromJson(
        Map<String, dynamic> json) =>
    _$ReviewSearchModelImpl(
      searchForUserId: json['searchForUserId'] as String? ?? '',
      searchForEquipmentId: json['searchForEquipmentId'] as String? ?? '',
    );

Map<String, dynamic> _$$ReviewSearchModelImplToJson(
        _$ReviewSearchModelImpl instance) =>
    <String, dynamic>{
      'searchForUserId': instance.searchForUserId,
      'searchForEquipmentId': instance.searchForEquipmentId,
    };
