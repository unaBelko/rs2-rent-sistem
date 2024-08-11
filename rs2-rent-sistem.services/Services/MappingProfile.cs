using AutoMapper;
using rs2_rent_sistem.models.Models;
using rs2_rent_sistem.models.Requests;
using rs2_rent_sistem.Models.Models;

namespace rs2_rent_sistem.Services.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Database.Cart, Cart>();

            CreateMap<Database.CartItem, CartItem>();

            CreateMap<Database.Equipment, Equipment>();

            CreateMap<Database.EquipmentCategory, EquipmentCategory>();
            CreateMap<EquipmentCategoryUpsertObject, Database.EquipmentCategory>();

            CreateMap<Database.Manufacturer, Manufacturer>();

            CreateMap<Database.Order, Order>();

            CreateMap<Database.OrderItem, OrderItem>();

            CreateMap<Database.Review, Review>();

            CreateMap<Database.Role, Role>();

            CreateMap<Database.User, User>();

        }
    }
}
