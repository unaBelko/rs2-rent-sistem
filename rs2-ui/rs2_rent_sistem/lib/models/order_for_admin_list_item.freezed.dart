// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'order_for_admin_list_item.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

OrderForAdminListItem _$OrderForAdminListItemFromJson(
    Map<String, dynamic> json) {
  return _OrderForAdminListItem.fromJson(json);
}

/// @nodoc
mixin _$OrderForAdminListItem {
  String get id => throw _privateConstructorUsedError;
  String get userName => throw _privateConstructorUsedError;
  String get userSurname => throw _privateConstructorUsedError;
  DateTime get dateCreated => throw _privateConstructorUsedError;
  double get price => throw _privateConstructorUsedError;
  String get status => throw _privateConstructorUsedError;

  Map<String, dynamic> toJson() => throw _privateConstructorUsedError;
  @JsonKey(ignore: true)
  $OrderForAdminListItemCopyWith<OrderForAdminListItem> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $OrderForAdminListItemCopyWith<$Res> {
  factory $OrderForAdminListItemCopyWith(OrderForAdminListItem value,
          $Res Function(OrderForAdminListItem) then) =
      _$OrderForAdminListItemCopyWithImpl<$Res, OrderForAdminListItem>;
  @useResult
  $Res call(
      {String id,
      String userName,
      String userSurname,
      DateTime dateCreated,
      double price,
      String status});
}

/// @nodoc
class _$OrderForAdminListItemCopyWithImpl<$Res,
        $Val extends OrderForAdminListItem>
    implements $OrderForAdminListItemCopyWith<$Res> {
  _$OrderForAdminListItemCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? userName = null,
    Object? userSurname = null,
    Object? dateCreated = null,
    Object? price = null,
    Object? status = null,
  }) {
    return _then(_value.copyWith(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as String,
      userName: null == userName
          ? _value.userName
          : userName // ignore: cast_nullable_to_non_nullable
              as String,
      userSurname: null == userSurname
          ? _value.userSurname
          : userSurname // ignore: cast_nullable_to_non_nullable
              as String,
      dateCreated: null == dateCreated
          ? _value.dateCreated
          : dateCreated // ignore: cast_nullable_to_non_nullable
              as DateTime,
      price: null == price
          ? _value.price
          : price // ignore: cast_nullable_to_non_nullable
              as double,
      status: null == status
          ? _value.status
          : status // ignore: cast_nullable_to_non_nullable
              as String,
    ) as $Val);
  }
}

/// @nodoc
abstract class _$$OrderForAdminListItemImplCopyWith<$Res>
    implements $OrderForAdminListItemCopyWith<$Res> {
  factory _$$OrderForAdminListItemImplCopyWith(
          _$OrderForAdminListItemImpl value,
          $Res Function(_$OrderForAdminListItemImpl) then) =
      __$$OrderForAdminListItemImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call(
      {String id,
      String userName,
      String userSurname,
      DateTime dateCreated,
      double price,
      String status});
}

/// @nodoc
class __$$OrderForAdminListItemImplCopyWithImpl<$Res>
    extends _$OrderForAdminListItemCopyWithImpl<$Res,
        _$OrderForAdminListItemImpl>
    implements _$$OrderForAdminListItemImplCopyWith<$Res> {
  __$$OrderForAdminListItemImplCopyWithImpl(_$OrderForAdminListItemImpl _value,
      $Res Function(_$OrderForAdminListItemImpl) _then)
      : super(_value, _then);

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? userName = null,
    Object? userSurname = null,
    Object? dateCreated = null,
    Object? price = null,
    Object? status = null,
  }) {
    return _then(_$OrderForAdminListItemImpl(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as String,
      userName: null == userName
          ? _value.userName
          : userName // ignore: cast_nullable_to_non_nullable
              as String,
      userSurname: null == userSurname
          ? _value.userSurname
          : userSurname // ignore: cast_nullable_to_non_nullable
              as String,
      dateCreated: null == dateCreated
          ? _value.dateCreated
          : dateCreated // ignore: cast_nullable_to_non_nullable
              as DateTime,
      price: null == price
          ? _value.price
          : price // ignore: cast_nullable_to_non_nullable
              as double,
      status: null == status
          ? _value.status
          : status // ignore: cast_nullable_to_non_nullable
              as String,
    ));
  }
}

/// @nodoc
@JsonSerializable()
class _$OrderForAdminListItemImpl implements _OrderForAdminListItem {
  const _$OrderForAdminListItemImpl(
      {this.id = '',
      this.userName = '',
      this.userSurname = '',
      required this.dateCreated,
      this.price = 0,
      this.status = ''});

  factory _$OrderForAdminListItemImpl.fromJson(Map<String, dynamic> json) =>
      _$$OrderForAdminListItemImplFromJson(json);

  @override
  @JsonKey()
  final String id;
  @override
  @JsonKey()
  final String userName;
  @override
  @JsonKey()
  final String userSurname;
  @override
  final DateTime dateCreated;
  @override
  @JsonKey()
  final double price;
  @override
  @JsonKey()
  final String status;

  @override
  String toString() {
    return 'OrderForAdminListItem(id: $id, userName: $userName, userSurname: $userSurname, dateCreated: $dateCreated, price: $price, status: $status)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$OrderForAdminListItemImpl &&
            (identical(other.id, id) || other.id == id) &&
            (identical(other.userName, userName) ||
                other.userName == userName) &&
            (identical(other.userSurname, userSurname) ||
                other.userSurname == userSurname) &&
            (identical(other.dateCreated, dateCreated) ||
                other.dateCreated == dateCreated) &&
            (identical(other.price, price) || other.price == price) &&
            (identical(other.status, status) || other.status == status));
  }

  @JsonKey(ignore: true)
  @override
  int get hashCode => Object.hash(
      runtimeType, id, userName, userSurname, dateCreated, price, status);

  @JsonKey(ignore: true)
  @override
  @pragma('vm:prefer-inline')
  _$$OrderForAdminListItemImplCopyWith<_$OrderForAdminListItemImpl>
      get copyWith => __$$OrderForAdminListItemImplCopyWithImpl<
          _$OrderForAdminListItemImpl>(this, _$identity);

  @override
  Map<String, dynamic> toJson() {
    return _$$OrderForAdminListItemImplToJson(
      this,
    );
  }
}

abstract class _OrderForAdminListItem implements OrderForAdminListItem {
  const factory _OrderForAdminListItem(
      {final String id,
      final String userName,
      final String userSurname,
      required final DateTime dateCreated,
      final double price,
      final String status}) = _$OrderForAdminListItemImpl;

  factory _OrderForAdminListItem.fromJson(Map<String, dynamic> json) =
      _$OrderForAdminListItemImpl.fromJson;

  @override
  String get id;
  @override
  String get userName;
  @override
  String get userSurname;
  @override
  DateTime get dateCreated;
  @override
  double get price;
  @override
  String get status;
  @override
  @JsonKey(ignore: true)
  _$$OrderForAdminListItemImplCopyWith<_$OrderForAdminListItemImpl>
      get copyWith => throw _privateConstructorUsedError;
}
