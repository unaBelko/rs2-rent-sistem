// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'order_list_item.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

AdminOrderListItemModel _$AdminOrderListItemModelFromJson(
    Map<String, dynamic> json) {
  return _OrderListItem.fromJson(json);
}

/// @nodoc
mixin _$AdminOrderListItemModel {
  int get id => throw _privateConstructorUsedError;
  DateTime get datePlaced => throw _privateConstructorUsedError;
  double get totalPrice => throw _privateConstructorUsedError;
  String get status => throw _privateConstructorUsedError;
  String get userNameSurname => throw _privateConstructorUsedError;

  /// Serializes this AdminOrderListItemModel to a JSON map.
  Map<String, dynamic> toJson() => throw _privateConstructorUsedError;

  /// Create a copy of AdminOrderListItemModel
  /// with the given fields replaced by the non-null parameter values.
  @JsonKey(includeFromJson: false, includeToJson: false)
  $AdminOrderListItemModelCopyWith<AdminOrderListItemModel> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $AdminOrderListItemModelCopyWith<$Res> {
  factory $AdminOrderListItemModelCopyWith(AdminOrderListItemModel value,
          $Res Function(AdminOrderListItemModel) then) =
      _$AdminOrderListItemModelCopyWithImpl<$Res, AdminOrderListItemModel>;
  @useResult
  $Res call(
      {int id,
      DateTime datePlaced,
      double totalPrice,
      String status,
      String userNameSurname});
}

/// @nodoc
class _$AdminOrderListItemModelCopyWithImpl<$Res,
        $Val extends AdminOrderListItemModel>
    implements $AdminOrderListItemModelCopyWith<$Res> {
  _$AdminOrderListItemModelCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;

  /// Create a copy of AdminOrderListItemModel
  /// with the given fields replaced by the non-null parameter values.
  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? datePlaced = null,
    Object? totalPrice = null,
    Object? status = null,
    Object? userNameSurname = null,
  }) {
    return _then(_value.copyWith(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as int,
      datePlaced: null == datePlaced
          ? _value.datePlaced
          : datePlaced // ignore: cast_nullable_to_non_nullable
              as DateTime,
      totalPrice: null == totalPrice
          ? _value.totalPrice
          : totalPrice // ignore: cast_nullable_to_non_nullable
              as double,
      status: null == status
          ? _value.status
          : status // ignore: cast_nullable_to_non_nullable
              as String,
      userNameSurname: null == userNameSurname
          ? _value.userNameSurname
          : userNameSurname // ignore: cast_nullable_to_non_nullable
              as String,
    ) as $Val);
  }
}

/// @nodoc
abstract class _$$OrderListItemImplCopyWith<$Res>
    implements $AdminOrderListItemModelCopyWith<$Res> {
  factory _$$OrderListItemImplCopyWith(
          _$OrderListItemImpl value, $Res Function(_$OrderListItemImpl) then) =
      __$$OrderListItemImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call(
      {int id,
      DateTime datePlaced,
      double totalPrice,
      String status,
      String userNameSurname});
}

/// @nodoc
class __$$OrderListItemImplCopyWithImpl<$Res>
    extends _$AdminOrderListItemModelCopyWithImpl<$Res, _$OrderListItemImpl>
    implements _$$OrderListItemImplCopyWith<$Res> {
  __$$OrderListItemImplCopyWithImpl(
      _$OrderListItemImpl _value, $Res Function(_$OrderListItemImpl) _then)
      : super(_value, _then);

  /// Create a copy of AdminOrderListItemModel
  /// with the given fields replaced by the non-null parameter values.
  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? datePlaced = null,
    Object? totalPrice = null,
    Object? status = null,
    Object? userNameSurname = null,
  }) {
    return _then(_$OrderListItemImpl(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as int,
      datePlaced: null == datePlaced
          ? _value.datePlaced
          : datePlaced // ignore: cast_nullable_to_non_nullable
              as DateTime,
      totalPrice: null == totalPrice
          ? _value.totalPrice
          : totalPrice // ignore: cast_nullable_to_non_nullable
              as double,
      status: null == status
          ? _value.status
          : status // ignore: cast_nullable_to_non_nullable
              as String,
      userNameSurname: null == userNameSurname
          ? _value.userNameSurname
          : userNameSurname // ignore: cast_nullable_to_non_nullable
              as String,
    ));
  }
}

/// @nodoc
@JsonSerializable()
class _$OrderListItemImpl implements _OrderListItem {
  const _$OrderListItemImpl(
      {required this.id,
      required this.datePlaced,
      this.totalPrice = 0.0,
      this.status = '',
      this.userNameSurname = ''});

  factory _$OrderListItemImpl.fromJson(Map<String, dynamic> json) =>
      _$$OrderListItemImplFromJson(json);

  @override
  final int id;
  @override
  final DateTime datePlaced;
  @override
  @JsonKey()
  final double totalPrice;
  @override
  @JsonKey()
  final String status;
  @override
  @JsonKey()
  final String userNameSurname;

  @override
  String toString() {
    return 'AdminOrderListItemModel(id: $id, datePlaced: $datePlaced, totalPrice: $totalPrice, status: $status, userNameSurname: $userNameSurname)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$OrderListItemImpl &&
            (identical(other.id, id) || other.id == id) &&
            (identical(other.datePlaced, datePlaced) ||
                other.datePlaced == datePlaced) &&
            (identical(other.totalPrice, totalPrice) ||
                other.totalPrice == totalPrice) &&
            (identical(other.status, status) || other.status == status) &&
            (identical(other.userNameSurname, userNameSurname) ||
                other.userNameSurname == userNameSurname));
  }

  @JsonKey(includeFromJson: false, includeToJson: false)
  @override
  int get hashCode => Object.hash(
      runtimeType, id, datePlaced, totalPrice, status, userNameSurname);

  /// Create a copy of AdminOrderListItemModel
  /// with the given fields replaced by the non-null parameter values.
  @JsonKey(includeFromJson: false, includeToJson: false)
  @override
  @pragma('vm:prefer-inline')
  _$$OrderListItemImplCopyWith<_$OrderListItemImpl> get copyWith =>
      __$$OrderListItemImplCopyWithImpl<_$OrderListItemImpl>(this, _$identity);

  @override
  Map<String, dynamic> toJson() {
    return _$$OrderListItemImplToJson(
      this,
    );
  }
}

abstract class _OrderListItem implements AdminOrderListItemModel {
  const factory _OrderListItem(
      {required final int id,
      required final DateTime datePlaced,
      final double totalPrice,
      final String status,
      final String userNameSurname}) = _$OrderListItemImpl;

  factory _OrderListItem.fromJson(Map<String, dynamic> json) =
      _$OrderListItemImpl.fromJson;

  @override
  int get id;
  @override
  DateTime get datePlaced;
  @override
  double get totalPrice;
  @override
  String get status;
  @override
  String get userNameSurname;

  /// Create a copy of AdminOrderListItemModel
  /// with the given fields replaced by the non-null parameter values.
  @override
  @JsonKey(includeFromJson: false, includeToJson: false)
  _$$OrderListItemImplCopyWith<_$OrderListItemImpl> get copyWith =>
      throw _privateConstructorUsedError;
}
