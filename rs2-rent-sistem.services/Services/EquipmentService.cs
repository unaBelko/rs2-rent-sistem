using rs2_rent_sistem.Models.SearchObjects;
using rs2_rent_sistem.Services.Interfaces;
using AutoMapper;
using rs2_rent_sistem.Services.Data;
using rs2_rent_sistem.Models.Requests;
using Equipment = rs2_rent_sistem.Models.Models.Equipment;

namespace rs2_rent_sistem.Services.Services
{
    public class EquipmentService: CRUDService<Equipment, Database.Equipment, EquipmentSearchObject, EquipmentUpsertObject, EquipmentUpsertObject>, IEquipmentService    
    {
        public EquipmentService(RentSistemDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }
}
