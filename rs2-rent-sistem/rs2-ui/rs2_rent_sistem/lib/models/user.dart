import 'package:freezed_annotation/freezed_annotation.dart';

part 'user.freezed.dart';
part 'user.g.dart';

@Freezed()
class User with _$User {
  const factory User({
    @Default('') String id,
    @Default('') String name,
    @Default('') String surname,
    @Default('') String email,
    @Default(0) int numberOfOrders,
    @Default(0) int numberOfReviews,
    @Default(true) bool isActive,
  }) = _User;

  factory User.fromJson(Map<String, dynamic> json) => _$UserFromJson(json);
}
