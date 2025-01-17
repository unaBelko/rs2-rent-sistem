// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'add_to_cart_model.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

AddToCartModel _$AddToCartModelFromJson(Map<String, dynamic> json) {
  return _AddToCartModel.fromJson(json);
}

/// @nodoc
mixin _$AddToCartModel {
  int get quantity => throw _privateConstructorUsedError;
  DateTime get startDate => throw _privateConstructorUsedError;
  DateTime get endDate => throw _privateConstructorUsedError;
  int get equipmentID => throw _privateConstructorUsedError;

  /// Serializes this AddToCartModel to a JSON map.
  Map<String, dynamic> toJson() => throw _privateConstructorUsedError;

  /// Create a copy of AddToCartModel
  /// with the given fields replaced by the non-null parameter values.
  @JsonKey(includeFromJson: false, includeToJson: false)
  $AddToCartModelCopyWith<AddToCartModel> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $AddToCartModelCopyWith<$Res> {
  factory $AddToCartModelCopyWith(
          AddToCartModel value, $Res Function(AddToCartModel) then) =
      _$AddToCartModelCopyWithImpl<$Res, AddToCartModel>;
  @useResult
  $Res call(
      {int quantity, DateTime startDate, DateTime endDate, int equipmentID});
}

/// @nodoc
class _$AddToCartModelCopyWithImpl<$Res, $Val extends AddToCartModel>
    implements $AddToCartModelCopyWith<$Res> {
  _$AddToCartModelCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;

  /// Create a copy of AddToCartModel
  /// with the given fields replaced by the non-null parameter values.
  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? quantity = null,
    Object? startDate = null,
    Object? endDate = null,
    Object? equipmentID = null,
  }) {
    return _then(_value.copyWith(
      quantity: null == quantity
          ? _value.quantity
          : quantity // ignore: cast_nullable_to_non_nullable
              as int,
      startDate: null == startDate
          ? _value.startDate
          : startDate // ignore: cast_nullable_to_non_nullable
              as DateTime,
      endDate: null == endDate
          ? _value.endDate
          : endDate // ignore: cast_nullable_to_non_nullable
              as DateTime,
      equipmentID: null == equipmentID
          ? _value.equipmentID
          : equipmentID // ignore: cast_nullable_to_non_nullable
              as int,
    ) as $Val);
  }
}

/// @nodoc
abstract class _$$AddToCartModelImplCopyWith<$Res>
    implements $AddToCartModelCopyWith<$Res> {
  factory _$$AddToCartModelImplCopyWith(_$AddToCartModelImpl value,
          $Res Function(_$AddToCartModelImpl) then) =
      __$$AddToCartModelImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call(
      {int quantity, DateTime startDate, DateTime endDate, int equipmentID});
}

/// @nodoc
class __$$AddToCartModelImplCopyWithImpl<$Res>
    extends _$AddToCartModelCopyWithImpl<$Res, _$AddToCartModelImpl>
    implements _$$AddToCartModelImplCopyWith<$Res> {
  __$$AddToCartModelImplCopyWithImpl(
      _$AddToCartModelImpl _value, $Res Function(_$AddToCartModelImpl) _then)
      : super(_value, _then);

  /// Create a copy of AddToCartModel
  /// with the given fields replaced by the non-null parameter values.
  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? quantity = null,
    Object? startDate = null,
    Object? endDate = null,
    Object? equipmentID = null,
  }) {
    return _then(_$AddToCartModelImpl(
      quantity: null == quantity
          ? _value.quantity
          : quantity // ignore: cast_nullable_to_non_nullable
              as int,
      startDate: null == startDate
          ? _value.startDate
          : startDate // ignore: cast_nullable_to_non_nullable
              as DateTime,
      endDate: null == endDate
          ? _value.endDate
          : endDate // ignore: cast_nullable_to_non_nullable
              as DateTime,
      equipmentID: null == equipmentID
          ? _value.equipmentID
          : equipmentID // ignore: cast_nullable_to_non_nullable
              as int,
    ));
  }
}

/// @nodoc
@JsonSerializable()
class _$AddToCartModelImpl implements _AddToCartModel {
  const _$AddToCartModelImpl(
      {required this.quantity,
      required this.startDate,
      required this.endDate,
      required this.equipmentID});

  factory _$AddToCartModelImpl.fromJson(Map<String, dynamic> json) =>
      _$$AddToCartModelImplFromJson(json);

  @override
  final int quantity;
  @override
  final DateTime startDate;
  @override
  final DateTime endDate;
  @override
  final int equipmentID;

  @override
  String toString() {
    return 'AddToCartModel(quantity: $quantity, startDate: $startDate, endDate: $endDate, equipmentID: $equipmentID)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$AddToCartModelImpl &&
            (identical(other.quantity, quantity) ||
                other.quantity == quantity) &&
            (identical(other.startDate, startDate) ||
                other.startDate == startDate) &&
            (identical(other.endDate, endDate) || other.endDate == endDate) &&
            (identical(other.equipmentID, equipmentID) ||
                other.equipmentID == equipmentID));
  }

  @JsonKey(includeFromJson: false, includeToJson: false)
  @override
  int get hashCode =>
      Object.hash(runtimeType, quantity, startDate, endDate, equipmentID);

  /// Create a copy of AddToCartModel
  /// with the given fields replaced by the non-null parameter values.
  @JsonKey(includeFromJson: false, includeToJson: false)
  @override
  @pragma('vm:prefer-inline')
  _$$AddToCartModelImplCopyWith<_$AddToCartModelImpl> get copyWith =>
      __$$AddToCartModelImplCopyWithImpl<_$AddToCartModelImpl>(
          this, _$identity);

  @override
  Map<String, dynamic> toJson() {
    return _$$AddToCartModelImplToJson(
      this,
    );
  }
}

abstract class _AddToCartModel implements AddToCartModel {
  const factory _AddToCartModel(
      {required final int quantity,
      required final DateTime startDate,
      required final DateTime endDate,
      required final int equipmentID}) = _$AddToCartModelImpl;

  factory _AddToCartModel.fromJson(Map<String, dynamic> json) =
      _$AddToCartModelImpl.fromJson;

  @override
  int get quantity;
  @override
  DateTime get startDate;
  @override
  DateTime get endDate;
  @override
  int get equipmentID;

  /// Create a copy of AddToCartModel
  /// with the given fields replaced by the non-null parameter values.
  @override
  @JsonKey(includeFromJson: false, includeToJson: false)
  _$$AddToCartModelImplCopyWith<_$AddToCartModelImpl> get copyWith =>
      throw _privateConstructorUsedError;
}
