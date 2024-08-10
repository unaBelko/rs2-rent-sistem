using AutoMapper;
using rs2_rent_sistem.Models.Models;

namespace rs2_rent_sistem.Services.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Database.EquipmentCategory, EquipmentCategory>();
            CreateMap<EquipmentCategory, Database.EquipmentCategory>();
        }
    }
}
