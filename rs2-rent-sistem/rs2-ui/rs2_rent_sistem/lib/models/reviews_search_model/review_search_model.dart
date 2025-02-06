import 'package:freezed_annotation/freezed_annotation.dart';

part 'review_search_model.freezed.dart';
part 'review_search_model.g.dart';

@Freezed()
class ReviewSearchModel with _$ReviewSearchModel {
  const factory ReviewSearchModel({
    @Default('') String searchForUserId,
    @Default('') String searchForEquipmentId,
  }) = _ReviewSearchModel;

  factory ReviewSearchModel.fromJson(Map<String, dynamic> json) => _$ReviewSearchModelFromJson(json);
}
