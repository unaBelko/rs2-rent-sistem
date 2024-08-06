using rs2_rent_sistem.models;


namespace rs2_rent_sistem.services
{
    public interface IEquipmentService
    {
        IList<EquipmentListItem> Get();
    }
}
