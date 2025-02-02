using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using rs2_rent_sistem.Model.Models.rs2_rent_sistem.Model.Reports;
using rs2_rent_sistem.Services.Interfaces;

namespace rs2_rent_sistem.Controllers
{
    [Authorize(Roles = "employee")]
    [ApiController]
    [Route("api/[controller]")]
    public class ReportsController : Controller
    {
        private readonly IOrderService _orderService;

        public ReportsController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("GenerateReport")]
        public async Task<IActionResult> GenerateReport([FromQuery] DateTime? startDate, [FromQuery] DateTime? endDate, [FromQuery] string reportType)
        {
            if (string.IsNullOrWhiteSpace(reportType))
            {
                return BadRequest(new { Message = "Report type is required." });
            }

            DateTime defaultStartDate = DateTime.Today.AddMonths(-12);
            DateTime defaultEndDate = DateTime.Today;

            DateTime finalStartDate = startDate ?? defaultStartDate;
            DateTime finalEndDate = endDate ?? defaultEndDate;

            if (finalEndDate < finalStartDate)
            {
                return BadRequest(new { Message = "End date cannot be before start date." });
            }

            var reportData = await _orderService.GetAll(finalStartDate, finalEndDate, reportType);

            var pdfDocument = GeneratePdfReport(reportType, reportData, finalStartDate, finalEndDate);

            var pdfBytes = pdfDocument.GeneratePdf();
            return File(pdfBytes, "application/pdf", $"{reportType}_Report.pdf");
        }


        private Document GeneratePdfReport(string reportType, List<object> reportData, DateTime? startDate, DateTime? endDate)
        {
            string formattedStartDate = startDate.HasValue ? startDate.Value.ToString("dd.MM.yyyy") : "N/A";
            string formattedEndDate = endDate.HasValue ? endDate.Value.ToString("dd.MM.yyyy") : "N/A";

            string reportTitle = reportType switch
            {
                "most_rented_equipment" => "Najviše iznajmljivana oprema",
                "most_active_users" => "Najaktivniji korisnici",
                "top_revenue_equipment" => "Najveća zarada po opremi",
                _ => "Nepoznat Izvještaj"
            };

            return Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(1, Unit.Centimetre);

                    page.Header().Column(column =>
                    {
                        column.Item().Text(reportTitle).FontSize(20).Bold();
                        column.Item().Text($"Period: {formattedStartDate} - {formattedEndDate}").FontSize(14).Italic();

                        column.Item().Text("");
                        column.Item().Text("");
                    });

                    page.Content().Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            switch (reportType)
                            {
                                case "most_rented_equipment":
                                    columns.RelativeColumn();
                                    columns.RelativeColumn();
                                    columns.RelativeColumn();
                                    break;
                                case "most_active_users":
                                    columns.RelativeColumn();
                                    columns.RelativeColumn();
                                    columns.RelativeColumn();
                                    break;
                                case "top_revenue_equipment":
                                    columns.RelativeColumn();
                                    columns.RelativeColumn();
                                    break;
                            }
                        });

                        table.Header(header =>
                        {
                            switch (reportType)
                            {
                                case "most_rented_equipment":
                                    header.Cell().Text("Naziv opreme").Bold();
                                    header.Cell().Text("Ukupno iznajmljeno (kol.)").Bold();
                                    header.Cell().Text("Ukupno dana iznajmljeno").Bold();
                                    break;
                                case "most_active_users":
                                    header.Cell().Text("Ime i prezime").Bold();
                                    header.Cell().Text("Ukupan broj stavki").Bold();
                                    header.Cell().Text("Ukupan broj narudžbi").Bold();
                                    break;
                                case "top_revenue_equipment":
                                    header.Cell().Text("Naziv").Bold();
                                    header.Cell().Text("Ukupna zarada").Bold();
                                    break;
                            }
                        });

                        foreach (var item in reportData)
                        {
                            switch (reportType)
                            {
                                case "most_rented_equipment":
                                    var equipment = item as MostRentedEquipmentReportModel;
                                    table.Cell().Text(equipment.Name);
                                    table.Cell().Text(equipment.TotalQuantity.ToString());
                                    table.Cell().Text(equipment.TotalRentalDays.ToString());
                                    break;

                                case "most_active_users":
                                    var user = item as MostActiveUsersReportModel;
                                    table.Cell().Text(user.UserNameSurname);
                                    table.Cell().Text(user.TotalOrderItems.ToString());
                                    table.Cell().Text(user.TotalOrders.ToString());
                                    break;

                                case "top_revenue_equipment":
                                    var revenue = item as TopRevenueEquipmentReportModel;
                                    table.Cell().Text(revenue.Name);
                                    table.Cell().Text(revenue.TotalRevenue.ToString());
                                    break;
                            }
                        }
                    });
                });
            });
        }

    }
}
