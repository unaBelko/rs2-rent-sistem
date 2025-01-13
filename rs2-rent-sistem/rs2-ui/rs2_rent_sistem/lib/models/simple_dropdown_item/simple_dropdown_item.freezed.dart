// coverage:ignore-file
// GENERATED CODE - DO NOT MODIFY BY HAND
// ignore_for_file: type=lint
// ignore_for_file: unused_element, deprecated_member_use, deprecated_member_use_from_same_package, use_function_type_syntax_for_parameters, unnecessary_const, avoid_init_to_null, invalid_override_different_default_values_named, prefer_expression_function_bodies, annotate_overrides, invalid_annotation_target, unnecessary_question_mark

part of 'simple_dropdown_item.dart';

// **************************************************************************
// FreezedGenerator
// **************************************************************************

T _$identity<T>(T value) => value;

final _privateConstructorUsedError = UnsupportedError(
    'It seems like you constructed your class using `MyClass._()`. This constructor is only meant to be used by freezed and you are not supposed to need it nor use it.\nPlease check the documentation here for more information: https://github.com/rrousselGit/freezed#adding-getters-and-methods-to-our-models');

SimpleDropdownItem _$SimpleDropdownItemFromJson(Map<String, dynamic> json) {
  return _SimpleDropdownItem.fromJson(json);
}

/// @nodoc
mixin _$SimpleDropdownItem {
  int get id => throw _privateConstructorUsedError;
  String get name => throw _privateConstructorUsedError;
  String get description => throw _privateConstructorUsedError;

  /// Serializes this SimpleDropdownItem to a JSON map.
  Map<String, dynamic> toJson() => throw _privateConstructorUsedError;

  /// Create a copy of SimpleDropdownItem
  /// with the given fields replaced by the non-null parameter values.
  @JsonKey(includeFromJson: false, includeToJson: false)
  $SimpleDropdownItemCopyWith<SimpleDropdownItem> get copyWith =>
      throw _privateConstructorUsedError;
}

/// @nodoc
abstract class $SimpleDropdownItemCopyWith<$Res> {
  factory $SimpleDropdownItemCopyWith(
          SimpleDropdownItem value, $Res Function(SimpleDropdownItem) then) =
      _$SimpleDropdownItemCopyWithImpl<$Res, SimpleDropdownItem>;
  @useResult
  $Res call({int id, String name, String description});
}

/// @nodoc
class _$SimpleDropdownItemCopyWithImpl<$Res, $Val extends SimpleDropdownItem>
    implements $SimpleDropdownItemCopyWith<$Res> {
  _$SimpleDropdownItemCopyWithImpl(this._value, this._then);

  // ignore: unused_field
  final $Val _value;
  // ignore: unused_field
  final $Res Function($Val) _then;

  /// Create a copy of SimpleDropdownItem
  /// with the given fields replaced by the non-null parameter values.
  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? name = null,
    Object? description = null,
  }) {
    return _then(_value.copyWith(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as int,
      name: null == name
          ? _value.name
          : name // ignore: cast_nullable_to_non_nullable
              as String,
      description: null == description
          ? _value.description
          : description // ignore: cast_nullable_to_non_nullable
              as String,
    ) as $Val);
  }
}

/// @nodoc
abstract class _$$SimpleDropdownItemImplCopyWith<$Res>
    implements $SimpleDropdownItemCopyWith<$Res> {
  factory _$$SimpleDropdownItemImplCopyWith(_$SimpleDropdownItemImpl value,
          $Res Function(_$SimpleDropdownItemImpl) then) =
      __$$SimpleDropdownItemImplCopyWithImpl<$Res>;
  @override
  @useResult
  $Res call({int id, String name, String description});
}

/// @nodoc
class __$$SimpleDropdownItemImplCopyWithImpl<$Res>
    extends _$SimpleDropdownItemCopyWithImpl<$Res, _$SimpleDropdownItemImpl>
    implements _$$SimpleDropdownItemImplCopyWith<$Res> {
  __$$SimpleDropdownItemImplCopyWithImpl(_$SimpleDropdownItemImpl _value,
      $Res Function(_$SimpleDropdownItemImpl) _then)
      : super(_value, _then);

  /// Create a copy of SimpleDropdownItem
  /// with the given fields replaced by the non-null parameter values.
  @pragma('vm:prefer-inline')
  @override
  $Res call({
    Object? id = null,
    Object? name = null,
    Object? description = null,
  }) {
    return _then(_$SimpleDropdownItemImpl(
      id: null == id
          ? _value.id
          : id // ignore: cast_nullable_to_non_nullable
              as int,
      name: null == name
          ? _value.name
          : name // ignore: cast_nullable_to_non_nullable
              as String,
      description: null == description
          ? _value.description
          : description // ignore: cast_nullable_to_non_nullable
              as String,
    ));
  }
}

/// @nodoc
@JsonSerializable()
class _$SimpleDropdownItemImpl implements _SimpleDropdownItem {
  const _$SimpleDropdownItemImpl(
      {required this.id, this.name = '', this.description = ''});

  factory _$SimpleDropdownItemImpl.fromJson(Map<String, dynamic> json) =>
      _$$SimpleDropdownItemImplFromJson(json);

  @override
  final int id;
  @override
  @JsonKey()
  final String name;
  @override
  @JsonKey()
  final String description;

  @override
  String toString() {
    return 'SimpleDropdownItem(id: $id, name: $name, description: $description)';
  }

  @override
  bool operator ==(Object other) {
    return identical(this, other) ||
        (other.runtimeType == runtimeType &&
            other is _$SimpleDropdownItemImpl &&
            (identical(other.id, id) || other.id == id) &&
            (identical(other.name, name) || other.name == name) &&
            (identical(other.description, description) ||
                other.description == description));
  }

  @JsonKey(includeFromJson: false, includeToJson: false)
  @override
  int get hashCode => Object.hash(runtimeType, id, name, description);

  /// Create a copy of SimpleDropdownItem
  /// with the given fields replaced by the non-null parameter values.
  @JsonKey(includeFromJson: false, includeToJson: false)
  @override
  @pragma('vm:prefer-inline')
  _$$SimpleDropdownItemImplCopyWith<_$SimpleDropdownItemImpl> get copyWith =>
      __$$SimpleDropdownItemImplCopyWithImpl<_$SimpleDropdownItemImpl>(
          this, _$identity);

  @override
  Map<String, dynamic> toJson() {
    return _$$SimpleDropdownItemImplToJson(
      this,
    );
  }
}

abstract class _SimpleDropdownItem implements SimpleDropdownItem {
  const factory _SimpleDropdownItem(
      {required final int id,
      final String name,
      final String description}) = _$SimpleDropdownItemImpl;

  factory _SimpleDropdownItem.fromJson(Map<String, dynamic> json) =
      _$SimpleDropdownItemImpl.fromJson;

  @override
  int get id;
  @override
  String get name;
  @override
  String get description;

  /// Create a copy of SimpleDropdownItem
  /// with the given fields replaced by the non-null parameter values.
  @override
  @JsonKey(includeFromJson: false, includeToJson: false)
  _$$SimpleDropdownItemImplCopyWith<_$SimpleDropdownItemImpl> get copyWith =>
      throw _privateConstructorUsedError;
}
