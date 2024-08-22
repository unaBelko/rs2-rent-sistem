using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rs2_rent_sistem.Model
{
    public class EquipmentListItem
    {
        public int Id {  get; set; }
        public string? ImageUrl { get; set; }
        public string ItemName { get; set; }
        public double Rating { get; set; }
        public int NumberOfReviews { get; set; }
        public string FormattedCostPerDay { get; set; }
        public bool IsInCart { get; set; }
    }
}
