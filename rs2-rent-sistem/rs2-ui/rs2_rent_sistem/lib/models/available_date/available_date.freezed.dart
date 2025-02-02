// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'available_date.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

AvailableDate _$AvailableDateFromJson(Map<String, dynamic> json) {
  return _AvailableDate.fromJson(json);
}

/// @nodoc
mixin _$AvailableDate {
  DateTime get date => throw _privateConstructorUsedError;
  dynamic get quantity => throw _privateConstructorUsedError;

  /// Serializes this AvailableDate to a JSON map.
  Map<String, dynamic> toJson() => throw _privateConstructorUsedError;

  /// Create a copy of AvailableDate
  /// with the given fields replaced by the non-null parameter values.
  @JsonKey(includeFromJson: false, includeToJson: false)
  $AvailableDateCopyWith<AvailableDate> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $AvailableDateCopyWith<$Res> {
  factory $AvailableDateCopyWith(
          AvailableDate value, $Res Function(AvailableDate) then) =
      _$AvailableDateCopyWithImpl<$Res, AvailableDate>;
  @useResult
  $Res call({DateTime date, dynamic quantity});
}

/// @nodoc
class _$AvailableDateCopyWithImpl<$Res, $Val extends AvailableDate>
    implements $AvailableDateCopyWith<$Res> {
  _$AvailableDateCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;

  /// Create a copy of AvailableDate
  /// with the given fields replaced by the non-null parameter values.
  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? date = null,
    Object? quantity = freezed,
  }) {
    return _then(_value.copyWith(
      date: null == date
          ? _value.date
          : date // ignore: cast_nullable_to_non_nullable
              as DateTime,
      quantity: freezed == quantity
          ? _value.quantity
          : quantity // ignore: cast_nullable_to_non_nullable
              as dynamic,
    ) as $Val);
  }
}

/// @nodoc
abstract class _$$AvailableDateImplCopyWith<$Res>
    implements $AvailableDateCopyWith<$Res> {
  factory _$$AvailableDateImplCopyWith(
          _$AvailableDateImpl value, $Res Function(_$AvailableDateImpl) then) =
      __$$AvailableDateImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call({DateTime date, dynamic quantity});
}

/// @nodoc
class __$$AvailableDateImplCopyWithImpl<$Res>
    extends _$AvailableDateCopyWithImpl<$Res, _$AvailableDateImpl>
    implements _$$AvailableDateImplCopyWith<$Res> {
  __$$AvailableDateImplCopyWithImpl(
      _$AvailableDateImpl _value, $Res Function(_$AvailableDateImpl) _then)
      : super(_value, _then);

  /// Create a copy of AvailableDate
  /// with the given fields replaced by the non-null parameter values.
  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? date = null,
    Object? quantity = freezed,
  }) {
    return _then(_$AvailableDateImpl(
      date: null == date
          ? _value.date
          : date // ignore: cast_nullable_to_non_nullable
              as DateTime,
      quantity: freezed == quantity ? _value.quantity! : quantity,
    ));
  }
}

/// @nodoc
@JsonSerializable()
class _$AvailableDateImpl implements _AvailableDate {
  const _$AvailableDateImpl({required this.date, this.quantity = 0});

  factory _$AvailableDateImpl.fromJson(Map<String, dynamic> json) =>
      _$$AvailableDateImplFromJson(json);

  @override
  final DateTime date;
  @override
  @JsonKey()
  final dynamic quantity;

  @override
  String toString() {
    return 'AvailableDate(date: $date, quantity: $quantity)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$AvailableDateImpl &&
            (identical(other.date, date) || other.date == date) &&
            const DeepCollectionEquality().equals(other.quantity, quantity));
  }

  @JsonKey(includeFromJson: false, includeToJson: false)
  @override
  int get hashCode => Object.hash(
      runtimeType, date, const DeepCollectionEquality().hash(quantity));

  /// Create a copy of AvailableDate
  /// with the given fields replaced by the non-null parameter values.
  @JsonKey(includeFromJson: false, includeToJson: false)
  @override
  @pragma('vm:prefer-inline')
  _$$AvailableDateImplCopyWith<_$AvailableDateImpl> get copyWith =>
      __$$AvailableDateImplCopyWithImpl<_$AvailableDateImpl>(this, _$identity);

  @override
  Map<String, dynamic> toJson() {
    return _$$AvailableDateImplToJson(
      this,
    );
  }
}

abstract class _AvailableDate implements AvailableDate {
  const factory _AvailableDate(
      {required final DateTime date,
      final dynamic quantity}) = _$AvailableDateImpl;

  factory _AvailableDate.fromJson(Map<String, dynamic> json) =
      _$AvailableDateImpl.fromJson;

  @override
  DateTime get date;
  @override
  dynamic get quantity;

  /// Create a copy of AvailableDate
  /// with the given fields replaced by the non-null parameter values.
  @override
  @JsonKey(includeFromJson: false, includeToJson: false)
  _$$AvailableDateImplCopyWith<_$AvailableDateImpl> get copyWith =>
      throw _privateConstructorUsedError;
}
