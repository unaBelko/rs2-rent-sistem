// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'user_order_list_item.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

UserOrderListItem _$UserOrderListItemFromJson(Map<String, dynamic> json) {
  return _UserOrderListItem.fromJson(json);
}

/// @nodoc
mixin _$UserOrderListItem {
  String get id => throw _privateConstructorUsedError;
  String get dateOfCreation => throw _privateConstructorUsedError;
  double get price => throw _privateConstructorUsedError;
  int get numberOfItems => throw _privateConstructorUsedError;
  String get status => throw _privateConstructorUsedError;

  Map<String, dynamic> toJson() => throw _privateConstructorUsedError;
  @JsonKey(ignore: true)
  $UserOrderListItemCopyWith<UserOrderListItem> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $UserOrderListItemCopyWith<$Res> {
  factory $UserOrderListItemCopyWith(
          UserOrderListItem value, $Res Function(UserOrderListItem) then) =
      _$UserOrderListItemCopyWithImpl<$Res, UserOrderListItem>;
  @useResult
  $Res call(
      {String id,
      String dateOfCreation,
      double price,
      int numberOfItems,
      String status});
}

/// @nodoc
class _$UserOrderListItemCopyWithImpl<$Res, $Val extends UserOrderListItem>
    implements $UserOrderListItemCopyWith<$Res> {
  _$UserOrderListItemCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? dateOfCreation = null,
    Object? price = null,
    Object? numberOfItems = null,
    Object? status = null,
  }) {
    return _then(_value.copyWith(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as String,
      dateOfCreation: null == dateOfCreation
          ? _value.dateOfCreation
          : dateOfCreation // ignore: cast_nullable_to_non_nullable
              as String,
      price: null == price
          ? _value.price
          : price // ignore: cast_nullable_to_non_nullable
              as double,
      numberOfItems: null == numberOfItems
          ? _value.numberOfItems
          : numberOfItems // ignore: cast_nullable_to_non_nullable
              as int,
      status: null == status
          ? _value.status
          : status // ignore: cast_nullable_to_non_nullable
              as String,
    ) as $Val);
  }
}

/// @nodoc
abstract class _$$UserOrderListItemImplCopyWith<$Res>
    implements $UserOrderListItemCopyWith<$Res> {
  factory _$$UserOrderListItemImplCopyWith(_$UserOrderListItemImpl value,
          $Res Function(_$UserOrderListItemImpl) then) =
      __$$UserOrderListItemImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call(
      {String id,
      String dateOfCreation,
      double price,
      int numberOfItems,
      String status});
}

/// @nodoc
class __$$UserOrderListItemImplCopyWithImpl<$Res>
    extends _$UserOrderListItemCopyWithImpl<$Res, _$UserOrderListItemImpl>
    implements _$$UserOrderListItemImplCopyWith<$Res> {
  __$$UserOrderListItemImplCopyWithImpl(_$UserOrderListItemImpl _value,
      $Res Function(_$UserOrderListItemImpl) _then)
      : super(_value, _then);

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? dateOfCreation = null,
    Object? price = null,
    Object? numberOfItems = null,
    Object? status = null,
  }) {
    return _then(_$UserOrderListItemImpl(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as String,
      dateOfCreation: null == dateOfCreation
          ? _value.dateOfCreation
          : dateOfCreation // ignore: cast_nullable_to_non_nullable
              as String,
      price: null == price
          ? _value.price
          : price // ignore: cast_nullable_to_non_nullable
              as double,
      numberOfItems: null == numberOfItems
          ? _value.numberOfItems
          : numberOfItems // ignore: cast_nullable_to_non_nullable
              as int,
      status: null == status
          ? _value.status
          : status // ignore: cast_nullable_to_non_nullable
              as String,
    ));
  }
}

/// @nodoc
@JsonSerializable()
class _$UserOrderListItemImpl implements _UserOrderListItem {
  const _$UserOrderListItemImpl(
      {this.id = '',
      this.dateOfCreation = '',
      this.price = 0.0,
      this.numberOfItems = 0,
      this.status = ''});

  factory _$UserOrderListItemImpl.fromJson(Map<String, dynamic> json) =>
      _$$UserOrderListItemImplFromJson(json);

  @override
  @JsonKey()
  final String id;
  @override
  @JsonKey()
  final String dateOfCreation;
  @override
  @JsonKey()
  final double price;
  @override
  @JsonKey()
  final int numberOfItems;
  @override
  @JsonKey()
  final String status;

  @override
  String toString() {
    return 'UserOrderListItem(id: $id, dateOfCreation: $dateOfCreation, price: $price, numberOfItems: $numberOfItems, status: $status)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$UserOrderListItemImpl &&
            (identical(other.id, id) || other.id == id) &&
            (identical(other.dateOfCreation, dateOfCreation) ||
                other.dateOfCreation == dateOfCreation) &&
            (identical(other.price, price) || other.price == price) &&
            (identical(other.numberOfItems, numberOfItems) ||
                other.numberOfItems == numberOfItems) &&
            (identical(other.status, status) || other.status == status));
  }

  @JsonKey(ignore: true)
  @override
  int get hashCode => Object.hash(
      runtimeType, id, dateOfCreation, price, numberOfItems, status);

  @JsonKey(ignore: true)
  @override
  @pragma('vm:prefer-inline')
  _$$UserOrderListItemImplCopyWith<_$UserOrderListItemImpl> get copyWith =>
      __$$UserOrderListItemImplCopyWithImpl<_$UserOrderListItemImpl>(
          this, _$identity);

  @override
  Map<String, dynamic> toJson() {
    return _$$UserOrderListItemImplToJson(
      this,
    );
  }
}

abstract class _UserOrderListItem implements UserOrderListItem {
  const factory _UserOrderListItem(
      {final String id,
      final String dateOfCreation,
      final double price,
      final int numberOfItems,
      final String status}) = _$UserOrderListItemImpl;

  factory _UserOrderListItem.fromJson(Map<String, dynamic> json) =
      _$UserOrderListItemImpl.fromJson;

  @override
  String get id;
  @override
  String get dateOfCreation;
  @override
  double get price;
  @override
  int get numberOfItems;
  @override
  String get status;
  @override
  @JsonKey(ignore: true)
  _$$UserOrderListItemImplCopyWith<_$UserOrderListItemImpl> get copyWith =>
      throw _privateConstructorUsedError;
}
