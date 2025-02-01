namespace rs2_rent_sistem.Model.Models
{
    namespace rs2_rent_sistem.Model.Reports
    {
        public class MostRentedEquipmentReportModel
        {
            public string Name { get; set; }
            public int TotalQuantity { get; set; }
            public int TotalRentalDays { get; set; }
        }

        public class MostActiveUsersReportModel
        {
            public string UserNameSurname { get; set; }
            public int TotalOrderItems { get; set; }
            public int TotalOrders { get; set; }
        }

        public class TopRevenueEquipmentReportModel
        {
            public string Name { get; set; }
            public decimal TotalRevenue { get; set; }
        }
    }

}
