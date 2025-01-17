using Microsoft.AspNetCore.Mvc;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using rs2_rent_sistem.Services.Interfaces;
namespace rs2_rent_sistem.Controllers
{
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
        public async Task<IActionResult> GenerateReport()
        {
            // Fetch all orders (no filtering by UserId)
            var orders = await _orderService.GetAll();

            // Generate the PDF document
            var pdfDocument = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(1, Unit.Centimetre);
                    page.Header().Text("Order Report").FontSize(20).Bold();
                    page.Content().Table(table =>
                    {

                        table.ColumnsDefinition(columns =>
                        {
                            columns.RelativeColumn();
                            columns.RelativeColumn();
                            columns.RelativeColumn();
                        });

                        table.Header(header =>
                        {
                            header.Cell().Text("Order ID").Bold();
                            header.Cell().Text("Date Placed").Bold();
                            header.Cell().Text("Total Price").Bold();
                        });

                        // Populate the table with order data
                        foreach (var order in orders)
                        {
                            table.Cell().Text(order.ID.ToString());
                            table.Cell().Text(order.DatePlaced);
                            table.Cell().Text(order.TotalPrice.ToString("C"));
                        }
                    });
                });
            });

            // Generate the PDF and return it
            var pdfBytes = pdfDocument.GeneratePdf();
            return File(pdfBytes, "application/pdf", "OrderReport.pdf");
        }
    }
}