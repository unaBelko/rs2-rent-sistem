using AutoMapper;
using rs2_rent_sistem.Model.Models;
using rs2_rent_sistem.Model.Requests;

namespace rs2_rent_sistem.Services.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Database.Cart, Cart>();
            CreateMap<Cart, Database.Cart>();

            CreateMap<Database.CartItem, CartItem>();
            CreateMap<CartItemUpsertObject, Database.CartItem>();

            CreateMap<Database.Equipment, Equipment>();
            CreateMap<EquipmentUpsertObject, Database.Equipment>()
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => false));


            CreateMap<Database.EquipmentCategory, EquipmentCategory>();
            CreateMap<EquipmentCategoryUpsertObject, Database.EquipmentCategory>();

            CreateMap<Database.Manufacturer, Manufacturer>();
            CreateMap<ManufacturerUpsertObject, Database.Manufacturer>();

            CreateMap<Database.Order, Order>();
            CreateMap<Order, Database.Order>();

            CreateMap<Database.OrderItem, OrderItem>();
            CreateMap<OrderItem, Database.OrderItem>();

            CreateMap<Database.Review, Review>();

            CreateMap<Database.Role, Role>();
            CreateMap<Role, Database.Role>();

            CreateMap<Database.User, User>();
            CreateMap<UserUpsertObject, Database.User>();

        }
    }
}
