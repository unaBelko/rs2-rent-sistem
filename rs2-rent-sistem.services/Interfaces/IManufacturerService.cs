using rs2_rent_sistem.Model.Requests;
using rs2_rent_sistem.Model.SearchObjects;

namespace rs2_rent_sistem.Services.Interfaces
{
    public interface IManufacturerService : ICRUDService<Model.Models.Manufacturer, ManufacturerSearchObject, ManufacturerUpsertObject, ManufacturerUpsertObject>
    {
    }
}
