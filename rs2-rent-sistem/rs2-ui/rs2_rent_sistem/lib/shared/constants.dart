class Constants {
  static const String imageUrl = 'https://m.media-amazon.com/images/I/51YUGRwZUCL._AC_SL1500_.jpg';
  static const String apiUrl = 'https://02d2-46-36-161-80.ngrok-free.app/';
}

class Endpoints {
  //user
  static const String login = 'User/Login';
  static const String user = 'User';
  static const String userRegistration = 'User/Register';
  static const String userWithParams = 'User/{1}';

  //cart
  static const String addItemToCart = 'api/Cart/AddItem';
  static const String removeItemFromCart = 'api/Cart/RemoveItem';
  static const String emptyCart = 'api/Cart/Empty/{id}';
  static const String getCart = 'api/Cart/GetUsersCart';
  static const String getCartDetails = 'api/Cart/{1}';

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
  static const String createOrder = 'api/Order/CreateOrder';
  static const String order = 'api/Order';
  static const String orderWithParams = 'Order/{1}';
}
