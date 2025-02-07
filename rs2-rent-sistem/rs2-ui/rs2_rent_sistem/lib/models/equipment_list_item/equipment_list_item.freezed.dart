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
  int get id => throw _privateConstructorUsedError;
  String get itemName => throw _privateConstructorUsedError;
  String get imageUrl => throw _privateConstructorUsedError;
  double get costPerUse => throw _privateConstructorUsedError;
  String get manufacturer => throw _privateConstructorUsedError;
  double get averageRating =>
      throw _privateConstructorUsedError; // @Default(0) int numberOfReviews,
  int get stockQuantity => throw _privateConstructorUsedError;

  /// Serializes this EquipmentListItem to a JSON map.
  Map<String, dynamic> toJson() => throw _privateConstructorUsedError;

  /// Create a copy of EquipmentListItem
  /// with the given fields replaced by the non-null parameter values.
  @JsonKey(includeFromJson: false, includeToJson: false)
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
      {int id,
      String itemName,
      String imageUrl,
      double costPerUse,
      String manufacturer,
      double averageRating,
      int stockQuantity});
}

/// @nodoc
class _$EquipmentListItemCopyWithImpl<$Res, $Val extends EquipmentListItem>
    implements $EquipmentListItemCopyWith<$Res> {
  _$EquipmentListItemCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;

  /// Create a copy of EquipmentListItem
  /// with the given fields replaced by the non-null parameter values.
  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? itemName = null,
    Object? imageUrl = null,
    Object? costPerUse = null,
    Object? manufacturer = null,
    Object? averageRating = null,
    Object? stockQuantity = null,
  }) {
    return _then(_value.copyWith(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as int,
      itemName: null == itemName
          ? _value.itemName
          : itemName // ignore: cast_nullable_to_non_nullable
              as String,
      imageUrl: null == imageUrl
          ? _value.imageUrl
          : imageUrl // ignore: cast_nullable_to_non_nullable
              as String,
      costPerUse: null == costPerUse
          ? _value.costPerUse
          : costPerUse // ignore: cast_nullable_to_non_nullable
              as double,
      manufacturer: null == manufacturer
          ? _value.manufacturer
          : manufacturer // ignore: cast_nullable_to_non_nullable
              as String,
      averageRating: null == averageRating
          ? _value.averageRating
          : averageRating // ignore: cast_nullable_to_non_nullable
              as double,
      stockQuantity: null == stockQuantity
          ? _value.stockQuantity
          : stockQuantity // ignore: cast_nullable_to_non_nullable
              as int,
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
      {int id,
      String itemName,
      String imageUrl,
      double costPerUse,
      String manufacturer,
      double averageRating,
      int stockQuantity});
}

/// @nodoc
class __$$EquipmentListItemImplCopyWithImpl<$Res>
    extends _$EquipmentListItemCopyWithImpl<$Res, _$EquipmentListItemImpl>
    implements _$$EquipmentListItemImplCopyWith<$Res> {
  __$$EquipmentListItemImplCopyWithImpl(_$EquipmentListItemImpl _value,
      $Res Function(_$EquipmentListItemImpl) _then)
      : super(_value, _then);

  /// Create a copy of EquipmentListItem
  /// with the given fields replaced by the non-null parameter values.
  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? itemName = null,
    Object? imageUrl = null,
    Object? costPerUse = null,
    Object? manufacturer = null,
    Object? averageRating = null,
    Object? stockQuantity = null,
  }) {
    return _then(_$EquipmentListItemImpl(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as int,
      itemName: null == itemName
          ? _value.itemName
          : itemName // ignore: cast_nullable_to_non_nullable
              as String,
      imageUrl: null == imageUrl
          ? _value.imageUrl
          : imageUrl // ignore: cast_nullable_to_non_nullable
              as String,
      costPerUse: null == costPerUse
          ? _value.costPerUse
          : costPerUse // ignore: cast_nullable_to_non_nullable
              as double,
      manufacturer: null == manufacturer
          ? _value.manufacturer
          : manufacturer // ignore: cast_nullable_to_non_nullable
              as String,
      averageRating: null == averageRating
          ? _value.averageRating
          : averageRating // ignore: cast_nullable_to_non_nullable
              as double,
      stockQuantity: null == stockQuantity
          ? _value.stockQuantity
          : stockQuantity // ignore: cast_nullable_to_non_nullable
              as int,
    ));
  }
}

/// @nodoc
@JsonSerializable()
class _$EquipmentListItemImpl implements _EquipmentListItem {
  const _$EquipmentListItemImpl(
      {required this.id,
      this.itemName = '',
      this.imageUrl = '',
      this.costPerUse = 0.0,
      this.manufacturer = '',
      this.averageRating = 0.0,
      this.stockQuantity = 0});

  factory _$EquipmentListItemImpl.fromJson(Map<String, dynamic> json) =>
      _$$EquipmentListItemImplFromJson(json);

  @override
  final int id;
  @override
  @JsonKey()
  final String itemName;
  @override
  @JsonKey()
  final String imageUrl;
  @override
  @JsonKey()
  final double costPerUse;
  @override
  @JsonKey()
  final String manufacturer;
  @override
  @JsonKey()
  final double averageRating;
// @Default(0) int numberOfReviews,
  @override
  @JsonKey()
  final int stockQuantity;

  @override
  String toString() {
    return 'EquipmentListItem(id: $id, itemName: $itemName, imageUrl: $imageUrl, costPerUse: $costPerUse, manufacturer: $manufacturer, averageRating: $averageRating, stockQuantity: $stockQuantity)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$EquipmentListItemImpl &&
            (identical(other.id, id) || other.id == id) &&
            (identical(other.itemName, itemName) ||
                other.itemName == itemName) &&
            (identical(other.imageUrl, imageUrl) ||
                other.imageUrl == imageUrl) &&
            (identical(other.costPerUse, costPerUse) ||
                other.costPerUse == costPerUse) &&
            (identical(other.manufacturer, manufacturer) ||
                other.manufacturer == manufacturer) &&
            (identical(other.averageRating, averageRating) ||
                other.averageRating == averageRating) &&
            (identical(other.stockQuantity, stockQuantity) ||
                other.stockQuantity == stockQuantity));
  }

  @JsonKey(includeFromJson: false, includeToJson: false)
  @override
  int get hashCode => Object.hash(runtimeType, id, itemName, imageUrl,
      costPerUse, manufacturer, averageRating, stockQuantity);

  /// Create a copy of EquipmentListItem
  /// with the given fields replaced by the non-null parameter values.
  @JsonKey(includeFromJson: false, includeToJson: false)
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
      {required final int id,
      final String itemName,
      final String imageUrl,
      final double costPerUse,
      final String manufacturer,
      final double averageRating,
      final int stockQuantity}) = _$EquipmentListItemImpl;

  factory _EquipmentListItem.fromJson(Map<String, dynamic> json) =
      _$EquipmentListItemImpl.fromJson;

  @override
  int get id;
  @override
  String get itemName;
  @override
  String get imageUrl;
  @override
  double get costPerUse;
  @override
  String get manufacturer;
  @override
  double get averageRating; // @Default(0) int numberOfReviews,
  @override
  int get stockQuantity;

  /// Create a copy of EquipmentListItem
  /// with the given fields replaced by the non-null parameter values.
  @override
  @JsonKey(includeFromJson: false, includeToJson: false)
  _$$EquipmentListItemImplCopyWith<_$EquipmentListItemImpl> get copyWith =>
      throw _privateConstructorUsedError;
}
