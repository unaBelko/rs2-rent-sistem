import 'package:freezed_annotation/freezed_annotation.dart';

part 'review_for_admin.freezed.dart';
part 'review_for_admin.g.dart';

@Freezed()
class ReviewForAdmin with _$ReviewForAdmin {
  const factory ReviewForAdmin({
    @Default('') String id,
    String? equipmentName,
    @Default('') String content,
    DateTime? dateOfCreation,
  }) = _ReviewForAdmin;

  factory ReviewForAdmin.fromJson(Map<String, dynamic> json) => _$ReviewForAdminFromJson(json);
}
