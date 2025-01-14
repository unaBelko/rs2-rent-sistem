import 'package:freezed_annotation/freezed_annotation.dart';

part 'user.freezed.dart';
part 'user.g.dart';

@Freezed()
class User with _$User {
  const factory User({
    required int id,
    @Default('') String firstName,
    @Default('') String lastName,
    @Default('') String email,
    @Default(0) int numberOfOrders,
    @Default(0) int numberOfReviews,
    @Default(true) bool isActive,
  }) = _User;

  factory User.fromJson(Map<String, dynamic> json) => _$UserFromJson(json);
}
