// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'equipment_details_admin.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

EquipmentDetailsAdmin _$EquipmentDetailsAdminFromJson(
    Map<String, dynamic> json) {
  return _EquipmentDetailsAdmin.fromJson(json);
}

/// @nodoc
mixin _$EquipmentDetailsAdmin {
  int get id => throw _privateConstructorUsedError;
  String get itemName => throw _privateConstructorUsedError;
  int get manufacturerID => throw _privateConstructorUsedError;
  int get equipmentCategoryID => throw _privateConstructorUsedError;
  String get photo => throw _privateConstructorUsedError;
  int get minQuantity => throw _privateConstructorUsedError;
  int get maxQuantity => throw _privateConstructorUsedError;
  int get stockQuantity => throw _privateConstructorUsedError;
  String get description => throw _privateConstructorUsedError;
  double get costPerUse => throw _privateConstructorUsedError;
  DateTime get dateAdded => throw _privateConstructorUsedError;
  String get manufacturer => throw _privateConstructorUsedError;
  String get equipmentCategory => throw _privateConstructorUsedError;
  List<AvailableDate> get availableDates => throw _privateConstructorUsedError;
  bool get isInCart => throw _privateConstructorUsedError;

  /// Serializes this EquipmentDetailsAdmin to a JSON map.
  Map<String, dynamic> toJson() => throw _privateConstructorUsedError;

  /// Create a copy of EquipmentDetailsAdmin
  /// with the given fields replaced by the non-null parameter values.
  @JsonKey(includeFromJson: false, includeToJson: false)
  $EquipmentDetailsAdminCopyWith<EquipmentDetailsAdmin> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $EquipmentDetailsAdminCopyWith<$Res> {
  factory $EquipmentDetailsAdminCopyWith(EquipmentDetailsAdmin value,
          $Res Function(EquipmentDetailsAdmin) then) =
      _$EquipmentDetailsAdminCopyWithImpl<$Res, EquipmentDetailsAdmin>;
  @useResult
  $Res call(
      {int id,
      String itemName,
      int manufacturerID,
      int equipmentCategoryID,
      String photo,
      int minQuantity,
      int maxQuantity,
      int stockQuantity,
      String description,
      double costPerUse,
      DateTime dateAdded,
      String manufacturer,
      String equipmentCategory,
      List<AvailableDate> availableDates,
      bool isInCart});
}

/// @nodoc
class _$EquipmentDetailsAdminCopyWithImpl<$Res,
        $Val extends EquipmentDetailsAdmin>
    implements $EquipmentDetailsAdminCopyWith<$Res> {
  _$EquipmentDetailsAdminCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;

  /// Create a copy of EquipmentDetailsAdmin
  /// with the given fields replaced by the non-null parameter values.
  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? itemName = null,
    Object? manufacturerID = null,
    Object? equipmentCategoryID = null,
    Object? photo = null,
    Object? minQuantity = null,
    Object? maxQuantity = null,
    Object? stockQuantity = null,
    Object? description = null,
    Object? costPerUse = null,
    Object? dateAdded = null,
    Object? manufacturer = null,
    Object? equipmentCategory = null,
    Object? availableDates = null,
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
              as int,
      equipmentCategoryID: null == equipmentCategoryID
          ? _value.equipmentCategoryID
          : equipmentCategoryID // ignore: cast_nullable_to_non_nullable
              as int,
      photo: null == photo
          ? _value.photo
          : photo // ignore: cast_nullable_to_non_nullable
              as String,
      minQuantity: null == minQuantity
          ? _value.minQuantity
          : minQuantity // ignore: cast_nullable_to_non_nullable
              as int,
      maxQuantity: null == maxQuantity
          ? _value.maxQuantity
          : maxQuantity // ignore: cast_nullable_to_non_nullable
              as int,
      stockQuantity: null == stockQuantity
          ? _value.stockQuantity
          : stockQuantity // ignore: cast_nullable_to_non_nullable
              as int,
      description: null == description
          ? _value.description
          : description // ignore: cast_nullable_to_non_nullable
              as String,
      costPerUse: null == costPerUse
          ? _value.costPerUse
          : costPerUse // ignore: cast_nullable_to_non_nullable
              as double,
      dateAdded: null == dateAdded
          ? _value.dateAdded
          : dateAdded // ignore: cast_nullable_to_non_nullable
              as DateTime,
      manufacturer: null == manufacturer
          ? _value.manufacturer
          : manufacturer // ignore: cast_nullable_to_non_nullable
              as String,
      equipmentCategory: null == equipmentCategory
          ? _value.equipmentCategory
          : equipmentCategory // ignore: cast_nullable_to_non_nullable
              as String,
      availableDates: null == availableDates
          ? _value.availableDates
          : availableDates // ignore: cast_nullable_to_non_nullable
              as List<AvailableDate>,
      isInCart: null == isInCart
          ? _value.isInCart
          : isInCart // ignore: cast_nullable_to_non_nullable
              as bool,
    ) as $Val);
  }
}

/// @nodoc
abstract class _$$EquipmentDetailsAdminImplCopyWith<$Res>
    implements $EquipmentDetailsAdminCopyWith<$Res> {
  factory _$$EquipmentDetailsAdminImplCopyWith(
          _$EquipmentDetailsAdminImpl value,
          $Res Function(_$EquipmentDetailsAdminImpl) then) =
      __$$EquipmentDetailsAdminImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call(
      {int id,
      String itemName,
      int manufacturerID,
      int equipmentCategoryID,
      String photo,
      int minQuantity,
      int maxQuantity,
      int stockQuantity,
      String description,
      double costPerUse,
      DateTime dateAdded,
      String manufacturer,
      String equipmentCategory,
      List<AvailableDate> availableDates,
      bool isInCart});
}

/// @nodoc
class __$$EquipmentDetailsAdminImplCopyWithImpl<$Res>
    extends _$EquipmentDetailsAdminCopyWithImpl<$Res,
        _$EquipmentDetailsAdminImpl>
    implements _$$EquipmentDetailsAdminImplCopyWith<$Res> {
  __$$EquipmentDetailsAdminImplCopyWithImpl(_$EquipmentDetailsAdminImpl _value,
      $Res Function(_$EquipmentDetailsAdminImpl) _then)
      : super(_value, _then);

  /// Create a copy of EquipmentDetailsAdmin
  /// with the given fields replaced by the non-null parameter values.
  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? itemName = null,
    Object? manufacturerID = null,
    Object? equipmentCategoryID = null,
    Object? photo = null,
    Object? minQuantity = null,
    Object? maxQuantity = null,
    Object? stockQuantity = null,
    Object? description = null,
    Object? costPerUse = null,
    Object? dateAdded = null,
    Object? manufacturer = null,
    Object? equipmentCategory = null,
    Object? availableDates = null,
    Object? isInCart = null,
  }) {
    return _then(_$EquipmentDetailsAdminImpl(
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
              as int,
      equipmentCategoryID: null == equipmentCategoryID
          ? _value.equipmentCategoryID
          : equipmentCategoryID // ignore: cast_nullable_to_non_nullable
              as int,
      photo: null == photo
          ? _value.photo
          : photo // ignore: cast_nullable_to_non_nullable
              as String,
      minQuantity: null == minQuantity
          ? _value.minQuantity
          : minQuantity // ignore: cast_nullable_to_non_nullable
              as int,
      maxQuantity: null == maxQuantity
          ? _value.maxQuantity
          : maxQuantity // ignore: cast_nullable_to_non_nullable
              as int,
      stockQuantity: null == stockQuantity
          ? _value.stockQuantity
          : stockQuantity // ignore: cast_nullable_to_non_nullable
              as int,
      description: null == description
          ? _value.description
          : description // ignore: cast_nullable_to_non_nullable
              as String,
      costPerUse: null == costPerUse
          ? _value.costPerUse
          : costPerUse // ignore: cast_nullable_to_non_nullable
              as double,
      dateAdded: null == dateAdded
          ? _value.dateAdded
          : dateAdded // ignore: cast_nullable_to_non_nullable
              as DateTime,
      manufacturer: null == manufacturer
          ? _value.manufacturer
          : manufacturer // ignore: cast_nullable_to_non_nullable
              as String,
      equipmentCategory: null == equipmentCategory
          ? _value.equipmentCategory
          : equipmentCategory // ignore: cast_nullable_to_non_nullable
              as String,
      availableDates: null == availableDates
          ? _value._availableDates
          : availableDates // ignore: cast_nullable_to_non_nullable
              as List<AvailableDate>,
      isInCart: null == isInCart
          ? _value.isInCart
          : isInCart // ignore: cast_nullable_to_non_nullable
              as bool,
    ));
  }
}

/// @nodoc
@JsonSerializable()
class _$EquipmentDetailsAdminImpl implements _EquipmentDetailsAdmin {
  const _$EquipmentDetailsAdminImpl(
      {required this.id,
      this.itemName = '',
      this.manufacturerID = 0,
      this.equipmentCategoryID = 0,
      this.photo = '',
      this.minQuantity = 1,
      this.maxQuantity = 1,
      this.stockQuantity = 1,
      this.description = '',
      this.costPerUse = 0.0,
      required this.dateAdded,
      this.manufacturer = '',
      this.equipmentCategory = '',
      final List<AvailableDate> availableDates = const [],
      this.isInCart = false})
      : _availableDates = availableDates;

  factory _$EquipmentDetailsAdminImpl.fromJson(Map<String, dynamic> json) =>
      _$$EquipmentDetailsAdminImplFromJson(json);

  @override
  final int id;
  @override
  @JsonKey()
  final String itemName;
  @override
  @JsonKey()
  final int manufacturerID;
  @override
  @JsonKey()
  final int equipmentCategoryID;
  @override
  @JsonKey()
  final String photo;
  @override
  @JsonKey()
  final int minQuantity;
  @override
  @JsonKey()
  final int maxQuantity;
  @override
  @JsonKey()
  final int stockQuantity;
  @override
  @JsonKey()
  final String description;
  @override
  @JsonKey()
  final double costPerUse;
  @override
  final DateTime dateAdded;
  @override
  @JsonKey()
  final String manufacturer;
  @override
  @JsonKey()
  final String equipmentCategory;
  final List<AvailableDate> _availableDates;
  @override
  @JsonKey()
  List<AvailableDate> get availableDates {
    if (_availableDates is EqualUnmodifiableListView) return _availableDates;
    // ignore: implicit_dynamic_type
    return EqualUnmodifiableListView(_availableDates);
  }

  @override
  @JsonKey()
  final bool isInCart;

  @override
  String toString() {
    return 'EquipmentDetailsAdmin(id: $id, itemName: $itemName, manufacturerID: $manufacturerID, equipmentCategoryID: $equipmentCategoryID, photo: $photo, minQuantity: $minQuantity, maxQuantity: $maxQuantity, stockQuantity: $stockQuantity, description: $description, costPerUse: $costPerUse, dateAdded: $dateAdded, manufacturer: $manufacturer, equipmentCategory: $equipmentCategory, availableDates: $availableDates, isInCart: $isInCart)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$EquipmentDetailsAdminImpl &&
            (identical(other.id, id) || other.id == id) &&
            (identical(other.itemName, itemName) ||
                other.itemName == itemName) &&
            (identical(other.manufacturerID, manufacturerID) ||
                other.manufacturerID == manufacturerID) &&
            (identical(other.equipmentCategoryID, equipmentCategoryID) ||
                other.equipmentCategoryID == equipmentCategoryID) &&
            (identical(other.photo, photo) || other.photo == photo) &&
            (identical(other.minQuantity, minQuantity) ||
                other.minQuantity == minQuantity) &&
            (identical(other.maxQuantity, maxQuantity) ||
                other.maxQuantity == maxQuantity) &&
            (identical(other.stockQuantity, stockQuantity) ||
                other.stockQuantity == stockQuantity) &&
            (identical(other.description, description) ||
                other.description == description) &&
            (identical(other.costPerUse, costPerUse) ||
                other.costPerUse == costPerUse) &&
            (identical(other.dateAdded, dateAdded) ||
                other.dateAdded == dateAdded) &&
            (identical(other.manufacturer, manufacturer) ||
                other.manufacturer == manufacturer) &&
            (identical(other.equipmentCategory, equipmentCategory) ||
                other.equipmentCategory == equipmentCategory) &&
            const DeepCollectionEquality()
                .equals(other._availableDates, _availableDates) &&
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
      photo,
      minQuantity,
      maxQuantity,
      stockQuantity,
      description,
      costPerUse,
      dateAdded,
      manufacturer,
      equipmentCategory,
      const DeepCollectionEquality().hash(_availableDates),
      isInCart);

  /// Create a copy of EquipmentDetailsAdmin
  /// with the given fields replaced by the non-null parameter values.
  @JsonKey(includeFromJson: false, includeToJson: false)
  @override
  @pragma('vm:prefer-inline')
  _$$EquipmentDetailsAdminImplCopyWith<_$EquipmentDetailsAdminImpl>
      get copyWith => __$$EquipmentDetailsAdminImplCopyWithImpl<
          _$EquipmentDetailsAdminImpl>(this, _$identity);

  @override
  Map<String, dynamic> toJson() {
    return _$$EquipmentDetailsAdminImplToJson(
      this,
    );
  }
}

abstract class _EquipmentDetailsAdmin implements EquipmentDetailsAdmin {
  const factory _EquipmentDetailsAdmin(
      {required final int id,
      final String itemName,
      final int manufacturerID,
      final int equipmentCategoryID,
      final String photo,
      final int minQuantity,
      final int maxQuantity,
      final int stockQuantity,
      final String description,
      final double costPerUse,
      required final DateTime dateAdded,
      final String manufacturer,
      final String equipmentCategory,
      final List<AvailableDate> availableDates,
      final bool isInCart}) = _$EquipmentDetailsAdminImpl;

  factory _EquipmentDetailsAdmin.fromJson(Map<String, dynamic> json) =
      _$EquipmentDetailsAdminImpl.fromJson;

  @override
  int get id;
  @override
  String get itemName;
  @override
  int get manufacturerID;
  @override
  int get equipmentCategoryID;
  @override
  String get photo;
  @override
  int get minQuantity;
  @override
  int get maxQuantity;
  @override
  int get stockQuantity;
  @override
  String get description;
  @override
  double get costPerUse;
  @override
  DateTime get dateAdded;
  @override
  String get manufacturer;
  @override
  String get equipmentCategory;
  @override
  List<AvailableDate> get availableDates;
  @override
  bool get isInCart;

  /// Create a copy of EquipmentDetailsAdmin
  /// with the given fields replaced by the non-null parameter values.
  @override
  @JsonKey(includeFromJson: false, includeToJson: false)
  _$$EquipmentDetailsAdminImplCopyWith<_$EquipmentDetailsAdminImpl>
      get copyWith => throw _privateConstructorUsedError;
}
