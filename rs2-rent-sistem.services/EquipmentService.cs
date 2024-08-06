using rs2_rent_sistem.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rs2_rent_sistem.services
{
    public class EquipmentService : IEquipmentService
    {
        List<EquipmentListItem> _equipments = new List<EquipmentListItem>() { new EquipmentListItem()
        {
            Id = 1,
            ImageUrl = "",
            ItemName = "Lopta za odbojku",
            Rating = 3.6,
            NumberOfReviews = 10,
            FormattedCostPerDay = "10,00 KM",
            IsInCart = false,

        }, };
        IList<EquipmentListItem> IEquipmentService.Get()
        {
            return _equipments;
        }
    }
}
