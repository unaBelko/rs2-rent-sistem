// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'equipment_list_item.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

EquipmentListItem _$EquipmentListItemFromJson(Map<String, dynamic> json) {
  return _EquipmentListItem.fromJson(json);
}

/// @nodoc
mixin _$EquipmentListItem {
  String get id => throw _privateConstructorUsedError;
  String get imageUrl => throw _privateConstructorUsedError;
  String get itemName => throw _privateConstructorUsedError;
  String get manufacturer => throw _privateConstructorUsedError;
  double get rating => throw _privateConstructorUsedError;
  int get numberOfReviews => throw _privateConstructorUsedError;
  String get costPerDay => throw _privateConstructorUsedError;
  bool get isInCart => throw _privateConstructorUsedError;

  Map<String, dynamic> toJson() => throw _privateConstructorUsedError;
  @JsonKey(ignore: true)
  $EquipmentListItemCopyWith<EquipmentListItem> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $EquipmentListItemCopyWith<$Res> {
  factory $EquipmentListItemCopyWith(
          EquipmentListItem value, $Res Function(EquipmentListItem) then) =
      _$EquipmentListItemCopyWithImpl<$Res, EquipmentListItem>;
  @useResult
  $Res call(
      {String id,
      String imageUrl,
      String itemName,
      String manufacturer,
      double rating,
      int numberOfReviews,
      String costPerDay,
      bool isInCart});
}

/// @nodoc
class _$EquipmentListItemCopyWithImpl<$Res, $Val extends EquipmentListItem>
    implements $EquipmentListItemCopyWith<$Res> {
  _$EquipmentListItemCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? imageUrl = null,
    Object? itemName = null,
    Object? manufacturer = null,
    Object? rating = null,
    Object? numberOfReviews = null,
    Object? costPerDay = null,
    Object? isInCart = null,
  }) {
    return _then(_value.copyWith(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as String,
      imageUrl: null == imageUrl
          ? _value.imageUrl
          : imageUrl // ignore: cast_nullable_to_non_nullable
              as String,
      itemName: null == itemName
          ? _value.itemName
          : itemName // ignore: cast_nullable_to_non_nullable
              as String,
      manufacturer: null == manufacturer
          ? _value.manufacturer
          : manufacturer // ignore: cast_nullable_to_non_nullable
              as String,
      rating: null == rating
          ? _value.rating
          : rating // ignore: cast_nullable_to_non_nullable
              as double,
      numberOfReviews: null == numberOfReviews
          ? _value.numberOfReviews
          : numberOfReviews // ignore: cast_nullable_to_non_nullable
              as int,
      costPerDay: null == costPerDay
          ? _value.costPerDay
          : costPerDay // ignore: cast_nullable_to_non_nullable
              as String,
      isInCart: null == isInCart
          ? _value.isInCart
          : isInCart // ignore: cast_nullable_to_non_nullable
              as bool,
    ) as $Val);
  }
}

/// @nodoc
abstract class _$$EquipmentListItemImplCopyWith<$Res>
    implements $EquipmentListItemCopyWith<$Res> {
  factory _$$EquipmentListItemImplCopyWith(_$EquipmentListItemImpl value,
          $Res Function(_$EquipmentListItemImpl) then) =
      __$$EquipmentListItemImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call(
      {String id,
      String imageUrl,
      String itemName,
      String manufacturer,
      double rating,
      int numberOfReviews,
      String costPerDay,
      bool isInCart});
}

/// @nodoc
class __$$EquipmentListItemImplCopyWithImpl<$Res>
    extends _$EquipmentListItemCopyWithImpl<$Res, _$EquipmentListItemImpl>
    implements _$$EquipmentListItemImplCopyWith<$Res> {
  __$$EquipmentListItemImplCopyWithImpl(_$EquipmentListItemImpl _value,
      $Res Function(_$EquipmentListItemImpl) _then)
      : super(_value, _then);

  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? imageUrl = null,
    Object? itemName = null,
    Object? manufacturer = null,
    Object? rating = null,
    Object? numberOfReviews = null,
    Object? costPerDay = null,
    Object? isInCart = null,
  }) {
    return _then(_$EquipmentListItemImpl(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as String,
      imageUrl: null == imageUrl
          ? _value.imageUrl
          : imageUrl // ignore: cast_nullable_to_non_nullable
              as String,
      itemName: null == itemName
          ? _value.itemName
          : itemName // ignore: cast_nullable_to_non_nullable
              as String,
      manufacturer: null == manufacturer
          ? _value.manufacturer
          : manufacturer // ignore: cast_nullable_to_non_nullable
              as String,
      rating: null == rating
          ? _value.rating
          : rating // ignore: cast_nullable_to_non_nullable
              as double,
      numberOfReviews: null == numberOfReviews
          ? _value.numberOfReviews
          : numberOfReviews // ignore: cast_nullable_to_non_nullable
              as int,
      costPerDay: null == costPerDay
          ? _value.costPerDay
          : costPerDay // ignore: cast_nullable_to_non_nullable
              as String,
      isInCart: null == isInCart
          ? _value.isInCart
          : isInCart // ignore: cast_nullable_to_non_nullable
              as bool,
    ));
  }
}

/// @nodoc
@JsonSerializable()
class _$EquipmentListItemImpl implements _EquipmentListItem {
  const _$EquipmentListItemImpl(
      {this.id = '',
      this.imageUrl = '',
      this.itemName = '',
      this.manufacturer = '',
      this.rating = 0.0,
      this.numberOfReviews = 0,
      this.costPerDay = '',
      this.isInCart = false});

  factory _$EquipmentListItemImpl.fromJson(Map<String, dynamic> json) =>
      _$$EquipmentListItemImplFromJson(json);

  @override
  @JsonKey()
  final String id;
  @override
  @JsonKey()
  final String imageUrl;
  @override
  @JsonKey()
  final String itemName;
  @override
  @JsonKey()
  final String manufacturer;
  @override
  @JsonKey()
  final double rating;
  @override
  @JsonKey()
  final int numberOfReviews;
  @override
  @JsonKey()
  final String costPerDay;
  @override
  @JsonKey()
  final bool isInCart;

  @override
  String toString() {
    return 'EquipmentListItem(id: $id, imageUrl: $imageUrl, itemName: $itemName, manufacturer: $manufacturer, rating: $rating, numberOfReviews: $numberOfReviews, costPerDay: $costPerDay, isInCart: $isInCart)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$EquipmentListItemImpl &&
            (identical(other.id, id) || other.id == id) &&
            (identical(other.imageUrl, imageUrl) ||
                other.imageUrl == imageUrl) &&
            (identical(other.itemName, itemName) ||
                other.itemName == itemName) &&
            (identical(other.manufacturer, manufacturer) ||
                other.manufacturer == manufacturer) &&
            (identical(other.rating, rating) || other.rating == rating) &&
            (identical(other.numberOfReviews, numberOfReviews) ||
                other.numberOfReviews == numberOfReviews) &&
            (identical(other.costPerDay, costPerDay) ||
                other.costPerDay == costPerDay) &&
            (identical(other.isInCart, isInCart) ||
                other.isInCart == isInCart));
  }

  @JsonKey(ignore: true)
  @override
  int get hashCode => Object.hash(runtimeType, id, imageUrl, itemName,
      manufacturer, rating, numberOfReviews, costPerDay, isInCart);

  @JsonKey(ignore: true)
  @override
  @pragma('vm:prefer-inline')
  _$$EquipmentListItemImplCopyWith<_$EquipmentListItemImpl> get copyWith =>
      __$$EquipmentListItemImplCopyWithImpl<_$EquipmentListItemImpl>(
          this, _$identity);

  @override
  Map<String, dynamic> toJson() {
    return _$$EquipmentListItemImplToJson(
      this,
    );
  }
}

abstract class _EquipmentListItem implements EquipmentListItem {
  const factory _EquipmentListItem(
      {final String id,
      final String imageUrl,
      final String itemName,
      final String manufacturer,
      final double rating,
      final int numberOfReviews,
      final String costPerDay,
      final bool isInCart}) = _$EquipmentListItemImpl;

  factory _EquipmentListItem.fromJson(Map<String, dynamic> json) =
      _$EquipmentListItemImpl.fromJson;

  @override
  String get id;
  @override
  String get imageUrl;
  @override
  String get itemName;
  @override
  String get manufacturer;
  @override
  double get rating;
  @override
  int get numberOfReviews;
  @override
  String get costPerDay;
  @override
  bool get isInCart;
  @override
  @JsonKey(ignore: true)
  _$$EquipmentListItemImplCopyWith<_$EquipmentListItemImpl> get copyWith =>
      throw _privateConstructorUsedError;
}