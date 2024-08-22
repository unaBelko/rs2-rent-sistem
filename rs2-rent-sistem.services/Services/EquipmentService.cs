using AutoMapper;
using rs2_rent_sistem.Model.Requests;
using rs2_rent_sistem.Model.SearchObjects;
using rs2_rent_sistem.Services.Data;
using rs2_rent_sistem.Services.Interfaces;
using Equipment = rs2_rent_sistem.Model.Models.Equipment;

namespace rs2_rent_sistem.Services.Services
{
    public class EquipmentService : CRUDService<Equipment, Database.Equipment, EquipmentSearchObject, EquipmentUpsertObject, EquipmentUpsertObject>, IEquipmentService
    {
        public EquipmentService(RentSistemDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }
}
