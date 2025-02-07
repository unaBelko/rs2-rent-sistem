// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'equipment_details.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

EquipmentDetails _$EquipmentDetailsFromJson(Map<String, dynamic> json) {
  return _EquipmentDetails.fromJson(json);
}

/// @nodoc
mixin _$EquipmentDetails {
  int get id => throw _privateConstructorUsedError;
  String get itemName => throw _privateConstructorUsedError;
  String get manufacturerID => throw _privateConstructorUsedError;
  String get equipmentCategoryID => throw _privateConstructorUsedError;
  String get imageUrl => throw _privateConstructorUsedError;
  int get minQuantity => throw _privateConstructorUsedError;
  int get maxQuantity => throw _privateConstructorUsedError;
  String get description => throw _privateConstructorUsedError;
  double get costPerUse => throw _privateConstructorUsedError;
  double get averageRating => throw _privateConstructorUsedError;
  String get manufacturer => throw _privateConstructorUsedError;
  String get equipmentCategory => throw _privateConstructorUsedError;
  List<DateTime> get availableDatesForRent =>
      throw _privateConstructorUsedError;
  bool get isInCart => throw _privateConstructorUsedError;

  /// Serializes this EquipmentDetails to a JSON map.
  Map<String, dynamic> toJson() => throw _privateConstructorUsedError;

  /// Create a copy of EquipmentDetails
  /// with the given fields replaced by the non-null parameter values.
  @JsonKey(includeFromJson: false, includeToJson: false)
  $EquipmentDetailsCopyWith<EquipmentDetails> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $EquipmentDetailsCopyWith<$Res> {
  factory $EquipmentDetailsCopyWith(
          EquipmentDetails value, $Res Function(EquipmentDetails) then) =
      _$EquipmentDetailsCopyWithImpl<$Res, EquipmentDetails>;
  @useResult
  $Res call(
      {int id,
      String itemName,
      String manufacturerID,
      String equipmentCategoryID,
      String imageUrl,
      int minQuantity,
      int maxQuantity,
      String description,
      double costPerUse,
      double averageRating,
      String manufacturer,
      String equipmentCategory,
      List<DateTime> availableDatesForRent,
      bool isInCart});
}

/// @nodoc
class _$EquipmentDetailsCopyWithImpl<$Res, $Val extends EquipmentDetails>
    implements $EquipmentDetailsCopyWith<$Res> {
  _$EquipmentDetailsCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;

  /// Create a copy of EquipmentDetails
  /// with the given fields replaced by the non-null parameter values.
  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? itemName = null,
    Object? manufacturerID = null,
    Object? equipmentCategoryID = null,
    Object? imageUrl = null,
    Object? minQuantity = null,
    Object? maxQuantity = null,
    Object? description = null,
    Object? costPerUse = null,
    Object? averageRating = null,
    Object? manufacturer = null,
    Object? equipmentCategory = null,
    Object? availableDatesForRent = null,
    Object? isInCart = null,
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
      manufacturerID: null == manufacturerID
          ? _value.manufacturerID
          : manufacturerID // ignore: cast_nullable_to_non_nullable
              as String,
      equipmentCategoryID: null == equipmentCategoryID
          ? _value.equipmentCategoryID
          : equipmentCategoryID // ignore: cast_nullable_to_non_nullable
              as String,
      imageUrl: null == imageUrl
          ? _value.imageUrl
          : imageUrl // ignore: cast_nullable_to_non_nullable
              as String,
      minQuantity: null == minQuantity
          ? _value.minQuantity
          : minQuantity // ignore: cast_nullable_to_non_nullable
              as int,
      maxQuantity: null == maxQuantity
          ? _value.maxQuantity
          : maxQuantity // ignore: cast_nullable_to_non_nullable
              as int,
      description: null == description
          ? _value.description
          : description // ignore: cast_nullable_to_non_nullable
              as String,
      costPerUse: null == costPerUse
          ? _value.costPerUse
          : costPerUse // ignore: cast_nullable_to_non_nullable
              as double,
      averageRating: null == averageRating
          ? _value.averageRating
          : averageRating // ignore: cast_nullable_to_non_nullable
              as double,
      manufacturer: null == manufacturer
          ? _value.manufacturer
          : manufacturer // ignore: cast_nullable_to_non_nullable
              as String,
      equipmentCategory: null == equipmentCategory
          ? _value.equipmentCategory
          : equipmentCategory // ignore: cast_nullable_to_non_nullable
              as String,
      availableDatesForRent: null == availableDatesForRent
          ? _value.availableDatesForRent
          : availableDatesForRent // ignore: cast_nullable_to_non_nullable
              as List<DateTime>,
      isInCart: null == isInCart
          ? _value.isInCart
          : isInCart // ignore: cast_nullable_to_non_nullable
              as bool,
    ) as $Val);
  }
}

/// @nodoc
abstract class _$$EquipmentDetailsImplCopyWith<$Res>
    implements $EquipmentDetailsCopyWith<$Res> {
  factory _$$EquipmentDetailsImplCopyWith(_$EquipmentDetailsImpl value,
          $Res Function(_$EquipmentDetailsImpl) then) =
      __$$EquipmentDetailsImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call(
      {int id,
      String itemName,
      String manufacturerID,
      String equipmentCategoryID,
      String imageUrl,
      int minQuantity,
      int maxQuantity,
      String description,
      double costPerUse,
      double averageRating,
      String manufacturer,
      String equipmentCategory,
      List<DateTime> availableDatesForRent,
      bool isInCart});
}

/// @nodoc
class __$$EquipmentDetailsImplCopyWithImpl<$Res>
    extends _$EquipmentDetailsCopyWithImpl<$Res, _$EquipmentDetailsImpl>
    implements _$$EquipmentDetailsImplCopyWith<$Res> {
  __$$EquipmentDetailsImplCopyWithImpl(_$EquipmentDetailsImpl _value,
      $Res Function(_$EquipmentDetailsImpl) _then)
      : super(_value, _then);

  /// Create a copy of EquipmentDetails
  /// with the given fields replaced by the non-null parameter values.
  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? itemName = null,
    Object? manufacturerID = null,
    Object? equipmentCategoryID = null,
    Object? imageUrl = null,
    Object? minQuantity = null,
    Object? maxQuantity = null,
    Object? description = null,
    Object? costPerUse = null,
    Object? averageRating = null,
    Object? manufacturer = null,
    Object? equipmentCategory = null,
    Object? availableDatesForRent = null,
    Object? isInCart = null,
  }) {
    return _then(_$EquipmentDetailsImpl(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as int,
      itemName: null == itemName
          ? _value.itemName
          : itemName // ignore: cast_nullable_to_non_nullable
              as String,
      manufacturerID: null == manufacturerID
          ? _value.manufacturerID
          : manufacturerID // ignore: cast_nullable_to_non_nullable
              as String,
      equipmentCategoryID: null == equipmentCategoryID
          ? _value.equipmentCategoryID
          : equipmentCategoryID // ignore: cast_nullable_to_non_nullable
              as String,
      imageUrl: null == imageUrl
          ? _value.imageUrl
          : imageUrl // ignore: cast_nullable_to_non_nullable
              as String,
      minQuantity: null == minQuantity
          ? _value.minQuantity
          : minQuantity // ignore: cast_nullable_to_non_nullable
              as int,
      maxQuantity: null == maxQuantity
          ? _value.maxQuantity
          : maxQuantity // ignore: cast_nullable_to_non_nullable
              as int,
      description: null == description
          ? _value.description
          : description // ignore: cast_nullable_to_non_nullable
              as String,
      costPerUse: null == costPerUse
          ? _value.costPerUse
          : costPerUse // ignore: cast_nullable_to_non_nullable
              as double,
      averageRating: null == averageRating
          ? _value.averageRating
          : averageRating // ignore: cast_nullable_to_non_nullable
              as double,
      manufacturer: null == manufacturer
          ? _value.manufacturer
          : manufacturer // ignore: cast_nullable_to_non_nullable
              as String,
      equipmentCategory: null == equipmentCategory
          ? _value.equipmentCategory
          : equipmentCategory // ignore: cast_nullable_to_non_nullable
              as String,
      availableDatesForRent: null == availableDatesForRent
          ? _value._availableDatesForRent
          : availableDatesForRent // ignore: cast_nullable_to_non_nullable
              as List<DateTime>,
      isInCart: null == isInCart
          ? _value.isInCart
          : isInCart // ignore: cast_nullable_to_non_nullable
              as bool,
    ));
  }
}

/// @nodoc
@JsonSerializable()
class _$EquipmentDetailsImpl implements _EquipmentDetails {
  const _$EquipmentDetailsImpl(
      {required this.id,
      this.itemName = '',
      this.manufacturerID = '',
      this.equipmentCategoryID = '',
      this.imageUrl = '',
      this.minQuantity = 1,
      this.maxQuantity = 1,
      this.description = '',
      this.costPerUse = 0.0,
      this.averageRating = 0.0,
      this.manufacturer = '',
      this.equipmentCategory = '',
      final List<DateTime> availableDatesForRent = const [],
      this.isInCart = false})
      : _availableDatesForRent = availableDatesForRent;

  factory _$EquipmentDetailsImpl.fromJson(Map<String, dynamic> json) =>
      _$$EquipmentDetailsImplFromJson(json);

  @override
  final int id;
  @override
  @JsonKey()
  final String itemName;
  @override
  @JsonKey()
  final String manufacturerID;
  @override
  @JsonKey()
  final String equipmentCategoryID;
  @override
  @JsonKey()
  final String imageUrl;
  @override
  @JsonKey()
  final int minQuantity;
  @override
  @JsonKey()
  final int maxQuantity;
  @override
  @JsonKey()
  final String description;
  @override
  @JsonKey()
  final double costPerUse;
  @override
  @JsonKey()
  final double averageRating;
  @override
  @JsonKey()
  final String manufacturer;
  @override
  @JsonKey()
  final String equipmentCategory;
  final List<DateTime> _availableDatesForRent;
  @override
  @JsonKey()
  List<DateTime> get availableDatesForRent {
    if (_availableDatesForRent is EqualUnmodifiableListView)
      return _availableDatesForRent;
    // ignore: implicit_dynamic_type
    return EqualUnmodifiableListView(_availableDatesForRent);
  }

  @override
  @JsonKey()
  final bool isInCart;

  @override
  String toString() {
    return 'EquipmentDetails(id: $id, itemName: $itemName, manufacturerID: $manufacturerID, equipmentCategoryID: $equipmentCategoryID, imageUrl: $imageUrl, minQuantity: $minQuantity, maxQuantity: $maxQuantity, description: $description, costPerUse: $costPerUse, averageRating: $averageRating, manufacturer: $manufacturer, equipmentCategory: $equipmentCategory, availableDatesForRent: $availableDatesForRent, isInCart: $isInCart)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$EquipmentDetailsImpl &&
            (identical(other.id, id) || other.id == id) &&
            (identical(other.itemName, itemName) ||
                other.itemName == itemName) &&
            (identical(other.manufacturerID, manufacturerID) ||
                other.manufacturerID == manufacturerID) &&
            (identical(other.equipmentCategoryID, equipmentCategoryID) ||
                other.equipmentCategoryID == equipmentCategoryID) &&
            (identical(other.imageUrl, imageUrl) ||
                other.imageUrl == imageUrl) &&
            (identical(other.minQuantity, minQuantity) ||
                other.minQuantity == minQuantity) &&
            (identical(other.maxQuantity, maxQuantity) ||
                other.maxQuantity == maxQuantity) &&
            (identical(other.description, description) ||
                other.description == description) &&
            (identical(other.costPerUse, costPerUse) ||
                other.costPerUse == costPerUse) &&
            (identical(other.averageRating, averageRating) ||
                other.averageRating == averageRating) &&
            (identical(other.manufacturer, manufacturer) ||
                other.manufacturer == manufacturer) &&
            (identical(other.equipmentCategory, equipmentCategory) ||
                other.equipmentCategory == equipmentCategory) &&
            const DeepCollectionEquality()
                .equals(other._availableDatesForRent, _availableDatesForRent) &&
            (identical(other.isInCart, isInCart) ||
                other.isInCart == isInCart));
  }

  @JsonKey(includeFromJson: false, includeToJson: false)
  @override
  int get hashCode => Object.hash(
      runtimeType,
      id,
      itemName,
      manufacturerID,
      equipmentCategoryID,
      imageUrl,
      minQuantity,
      maxQuantity,
      description,
      costPerUse,
      averageRating,
      manufacturer,
      equipmentCategory,
      const DeepCollectionEquality().hash(_availableDatesForRent),
      isInCart);

  /// Create a copy of EquipmentDetails
  /// with the given fields replaced by the non-null parameter values.
  @JsonKey(includeFromJson: false, includeToJson: false)
  @override
  @pragma('vm:prefer-inline')
  _$$EquipmentDetailsImplCopyWith<_$EquipmentDetailsImpl> get copyWith =>
      __$$EquipmentDetailsImplCopyWithImpl<_$EquipmentDetailsImpl>(
          this, _$identity);

  @override
  Map<String, dynamic> toJson() {
    return _$$EquipmentDetailsImplToJson(
      this,
    );
  }
}

abstract class _EquipmentDetails implements EquipmentDetails {
  const factory _EquipmentDetails(
      {required final int id,
      final String itemName,
      final String manufacturerID,
      final String equipmentCategoryID,
      final String imageUrl,
      final int minQuantity,
      final int maxQuantity,
      final String description,
      final double costPerUse,
      final double averageRating,
      final String manufacturer,
      final String equipmentCategory,
      final List<DateTime> availableDatesForRent,
      final bool isInCart}) = _$EquipmentDetailsImpl;

  factory _EquipmentDetails.fromJson(Map<String, dynamic> json) =
      _$EquipmentDetailsImpl.fromJson;

  @override
  int get id;
  @override
  String get itemName;
  @override
  String get manufacturerID;
  @override
  String get equipmentCategoryID;
  @override
  String get imageUrl;
  @override
  int get minQuantity;
  @override
  int get maxQuantity;
  @override
  String get description;
  @override
  double get costPerUse;
  @override
  double get averageRating;
  @override
  String get manufacturer;
  @override
  String get equipmentCategory;
  @override
  List<DateTime> get availableDatesForRent;
  @override
  bool get isInCart;

  /// Create a copy of EquipmentDetails
  /// with the given fields replaced by the non-null parameter values.
  @override
  @JsonKey(includeFromJson: false, includeToJson: false)
  _$$EquipmentDetailsImplCopyWith<_$EquipmentDetailsImpl> get copyWith =>
      throw _privateConstructorUsedError;
}
