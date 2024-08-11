using rs2_rent_sistem.Models.SearchObjects;
using rs2_rent_sistem.Models.Requests;

namespace rs2_rent_sistem.Services.Interfaces
{
    public interface IManufacturerService: ICRUDService<Models.Models.Manufacturer, ManufacturerSearchObject, ManufacturerUpsertObject, ManufacturerUpsertObject>
    {
    }
}
