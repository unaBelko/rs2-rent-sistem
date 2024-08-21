// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'order_for_admin_list_item.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

_$OrderForAdminListItemImpl _$$OrderForAdminListItemImplFromJson(
        Map<String, dynamic> json) =>
    _$OrderForAdminListItemImpl(
      id: json['id'] as String? ?? '',
      userName: json['userName'] as String? ?? '',
      userSurname: json['userSurname'] as String? ?? '',
      dateCreated: DateTime.parse(json['dateCreated'] as String),
      price: (json['price'] as num?)?.toDouble() ?? 0,
      status: json['status'] as String? ?? '',
    );

Map<String, dynamic> _$$OrderForAdminListItemImplToJson(
        _$OrderForAdminListItemImpl instance) =>
    <String, dynamic>{
      'id': instance.id,
      'userName': instance.userName,
      'userSurname': instance.userSurname,
      'dateCreated': instance.dateCreated.toIso8601String(),
      'price': instance.price,
      'status': instance.status,
    };
