import 'package:freezed_annotation/freezed_annotation.dart';

part 'add_to_cart_model.freezed.dart';
part 'add_to_cart_model.g.dart';

@Freezed()
class AddToCartModel with _$AddToCartModel {
  const factory AddToCartModel({
    required int quantity,
    required DateTime startDate,
    required DateTime endDate,
    required int equipmentID,
  }) = _AddToCartModel;

  factory AddToCartModel.fromJson(Map<String, dynamic> json) => _$AddToCartModelFromJson(json);
}
