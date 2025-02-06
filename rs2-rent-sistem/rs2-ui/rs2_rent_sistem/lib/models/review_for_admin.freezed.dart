// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'review_for_admin.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

ReviewForAdmin _$ReviewForAdminFromJson(Map<String, dynamic> json) {
  return _ReviewForAdmin.fromJson(json);
}

/// @nodoc
mixin _$ReviewForAdmin {
  int get id => throw _privateConstructorUsedError;
  ItemInOrder get orderItem => throw _privateConstructorUsedError;
  String get description => throw _privateConstructorUsedError;
  DateTime? get dateAdded => throw _privateConstructorUsedError;
  double get numberOfStars => throw _privateConstructorUsedError;

  /// Serializes this ReviewForAdmin to a JSON map.
  Map<String, dynamic> toJson() => throw _privateConstructorUsedError;

  /// Create a copy of ReviewForAdmin
  /// with the given fields replaced by the non-null parameter values.
  @JsonKey(includeFromJson: false, includeToJson: false)
  $ReviewForAdminCopyWith<ReviewForAdmin> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $ReviewForAdminCopyWith<$Res> {
  factory $ReviewForAdminCopyWith(
          ReviewForAdmin value, $Res Function(ReviewForAdmin) then) =
      _$ReviewForAdminCopyWithImpl<$Res, ReviewForAdmin>;
  @useResult
  $Res call(
      {int id,
      ItemInOrder orderItem,
      String description,
      DateTime? dateAdded,
      double numberOfStars});

  $ItemInOrderCopyWith<$Res> get orderItem;
}

/// @nodoc
class _$ReviewForAdminCopyWithImpl<$Res, $Val extends ReviewForAdmin>
    implements $ReviewForAdminCopyWith<$Res> {
  _$ReviewForAdminCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;

  /// Create a copy of ReviewForAdmin
  /// with the given fields replaced by the non-null parameter values.
  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? orderItem = null,
    Object? description = null,
    Object? dateAdded = freezed,
    Object? numberOfStars = null,
  }) {
    return _then(_value.copyWith(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as int,
      orderItem: null == orderItem
          ? _value.orderItem
          : orderItem // ignore: cast_nullable_to_non_nullable
              as ItemInOrder,
      description: null == description
          ? _value.description
          : description // ignore: cast_nullable_to_non_nullable
              as String,
      dateAdded: freezed == dateAdded
          ? _value.dateAdded
          : dateAdded // ignore: cast_nullable_to_non_nullable
              as DateTime?,
      numberOfStars: null == numberOfStars
          ? _value.numberOfStars
          : numberOfStars // ignore: cast_nullable_to_non_nullable
              as double,
    ) as $Val);
  }

  /// Create a copy of ReviewForAdmin
  /// with the given fields replaced by the non-null parameter values.
  @override
  @pragma('vm:prefer-inline')
  $ItemInOrderCopyWith<$Res> get orderItem {
    return $ItemInOrderCopyWith<$Res>(_value.orderItem, (value) {
      return _then(_value.copyWith(orderItem: value) as $Val);
    });
  }
}

/// @nodoc
abstract class _$$ReviewForAdminImplCopyWith<$Res>
    implements $ReviewForAdminCopyWith<$Res> {
  factory _$$ReviewForAdminImplCopyWith(_$ReviewForAdminImpl value,
          $Res Function(_$ReviewForAdminImpl) then) =
      __$$ReviewForAdminImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call(
      {int id,
      ItemInOrder orderItem,
      String description,
      DateTime? dateAdded,
      double numberOfStars});

  @override
  $ItemInOrderCopyWith<$Res> get orderItem;
}

/// @nodoc
class __$$ReviewForAdminImplCopyWithImpl<$Res>
    extends _$ReviewForAdminCopyWithImpl<$Res, _$ReviewForAdminImpl>
    implements _$$ReviewForAdminImplCopyWith<$Res> {
  __$$ReviewForAdminImplCopyWithImpl(
      _$ReviewForAdminImpl _value, $Res Function(_$ReviewForAdminImpl) _then)
      : super(_value, _then);

  /// Create a copy of ReviewForAdmin
  /// with the given fields replaced by the non-null parameter values.
  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? orderItem = null,
    Object? description = null,
    Object? dateAdded = freezed,
    Object? numberOfStars = null,
  }) {
    return _then(_$ReviewForAdminImpl(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as int,
      orderItem: null == orderItem
          ? _value.orderItem
          : orderItem // ignore: cast_nullable_to_non_nullable
              as ItemInOrder,
      description: null == description
          ? _value.description
          : description // ignore: cast_nullable_to_non_nullable
              as String,
      dateAdded: freezed == dateAdded
          ? _value.dateAdded
          : dateAdded // ignore: cast_nullable_to_non_nullable
              as DateTime?,
      numberOfStars: null == numberOfStars
          ? _value.numberOfStars
          : numberOfStars // ignore: cast_nullable_to_non_nullable
              as double,
    ));
  }
}

/// @nodoc
@JsonSerializable()
class _$ReviewForAdminImpl implements _ReviewForAdmin {
  const _$ReviewForAdminImpl(
      {required this.id,
      required this.orderItem,
      this.description = '',
      this.dateAdded,
      required this.numberOfStars});

  factory _$ReviewForAdminImpl.fromJson(Map<String, dynamic> json) =>
      _$$ReviewForAdminImplFromJson(json);

  @override
  final int id;
  @override
  final ItemInOrder orderItem;
  @override
  @JsonKey()
  final String description;
  @override
  final DateTime? dateAdded;
  @override
  final double numberOfStars;

  @override
  String toString() {
    return 'ReviewForAdmin(id: $id, orderItem: $orderItem, description: $description, dateAdded: $dateAdded, numberOfStars: $numberOfStars)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$ReviewForAdminImpl &&
            (identical(other.id, id) || other.id == id) &&
            (identical(other.orderItem, orderItem) ||
                other.orderItem == orderItem) &&
            (identical(other.description, description) ||
                other.description == description) &&
            (identical(other.dateAdded, dateAdded) ||
                other.dateAdded == dateAdded) &&
            (identical(other.numberOfStars, numberOfStars) ||
                other.numberOfStars == numberOfStars));
  }

  @JsonKey(includeFromJson: false, includeToJson: false)
  @override
  int get hashCode => Object.hash(
      runtimeType, id, orderItem, description, dateAdded, numberOfStars);

  /// Create a copy of ReviewForAdmin
  /// with the given fields replaced by the non-null parameter values.
  @JsonKey(includeFromJson: false, includeToJson: false)
  @override
  @pragma('vm:prefer-inline')
  _$$ReviewForAdminImplCopyWith<_$ReviewForAdminImpl> get copyWith =>
      __$$ReviewForAdminImplCopyWithImpl<_$ReviewForAdminImpl>(
          this, _$identity);

  @override
  Map<String, dynamic> toJson() {
    return _$$ReviewForAdminImplToJson(
      this,
    );
  }
}

abstract class _ReviewForAdmin implements ReviewForAdmin {
  const factory _ReviewForAdmin(
      {required final int id,
      required final ItemInOrder orderItem,
      final String description,
      final DateTime? dateAdded,
      required final double numberOfStars}) = _$ReviewForAdminImpl;

  factory _ReviewForAdmin.fromJson(Map<String, dynamic> json) =
      _$ReviewForAdminImpl.fromJson;

  @override
  int get id;
  @override
  ItemInOrder get orderItem;
  @override
  String get description;
  @override
  DateTime? get dateAdded;
  @override
  double get numberOfStars;

  /// Create a copy of ReviewForAdmin
  /// with the given fields replaced by the non-null parameter values.
  @override
  @JsonKey(includeFromJson: false, includeToJson: false)
  _$$ReviewForAdminImplCopyWith<_$ReviewForAdminImpl> get copyWith =>
      throw _privateConstructorUsedError;
}
