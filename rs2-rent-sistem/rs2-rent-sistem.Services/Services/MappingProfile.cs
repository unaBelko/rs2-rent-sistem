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

            CreateMap<Database.Equipment, Equipment>()
            .ForMember(dest => dest.Photo, opt => opt.MapFrom(src => src.Photo != null ? Convert.ToBase64String(src.Photo) : null));
            CreateMap<EquipmentUpsertObject, Database.Equipment>()
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => false));


            CreateMap<Database.EquipmentCategory, EquipmentCategory>();
            CreateMap<EquipmentCategoryUpsertObject, Database.EquipmentCategory>();

            CreateMap<Database.Manufacturer, Manufacturer>();
            CreateMap<ManufacturerUpsertObject, Database.Manufacturer>();

            CreateMap<Database.Order, Order>()
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.User.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.User.LastName));
            CreateMap<Order, Database.Order>();


            CreateMap<Database.OrderItem, OrderItem>();
            CreateMap<OrderItem, Database.OrderItem>();

            CreateMap<Database.Review, Review>();
            CreateMap<Review, Database.Review>();

            CreateMap<Database.Role, Role>();
            CreateMap<Role, Database.Role>();

            CreateMap<Database.User, User>().ForMember(dest => dest.Roles, opt => opt.MapFrom(src => src.UserRoles.Select(ur => ur.Role)));
            CreateMap<User, Database.User>().ForMember(dest => dest.UserRoles, opt => opt.Ignore());
            CreateMap<UserUpsertObject, Database.User>();
        }
    }
}
