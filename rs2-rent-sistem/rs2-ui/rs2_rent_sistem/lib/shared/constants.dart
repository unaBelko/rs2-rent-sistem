import 'dart:io';

class Constants {
  static final String apiUrl = String.fromEnvironment(
    'API_BASE_URL',
    defaultValue: _getDefaultApiUrl(),
  );

  static String _getDefaultApiUrl() {
    if (Platform.isWindows || Platform.isMacOS || Platform.isLinux) {
      return 'http://localhost:5119/api/';
    } else if (Platform.isAndroid) {
      return 'http://10.0.2.2:5119/api/';
    } else {
      return '';
    }
  }
}

class Endpoints {
  //user
  static const String login = 'User/Login';
  static const String user = 'User';
  static const String userRegistration = 'User/Register';
  static const String userWithParams = 'User/{1}';

  //cart
  static const String addItemToCart = 'Cart/AddItem';
  static const String removeItemFromCart = 'Cart/RemoveItem';
  static const String emptyCart = 'Cart/Empty/{id}';
  static const String getCart = 'Cart/GetUsersCart';
  static const String getCartDetails = 'Cart/{1}';

  //equipment
  static const String getRecommendedEquipment = 'Equipment/{1}/recommend';
  static const String equipment = 'Equipment';
  static const String equipmentWithParam = 'Equipment/{1}';

  //equipment categories
  static const String equipmentCategory = 'EquipmentCategory';
  static const String equipmentCategoryWithParams = 'EquipmentCategory/{1}';

  //manufacturer
  static const String manufacturer = 'Manufacturer';
  static const String manufacturerWithParams = 'Manufacturer/{1}';

  //order
  static const String createOrder = 'Order/CreateOrder';
  static const String order = 'Order';
  static const String orderWithParams = 'Order/{1}';

  //order items
  static const String orderItems = 'OrderItems';

  //reviews
  static const String review = 'Review';

  //damage
  static const String damage = 'Damage';
}
