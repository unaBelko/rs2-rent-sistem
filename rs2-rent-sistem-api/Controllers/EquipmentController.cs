using Microsoft.AspNetCore.Mvc;
using rs2_rent_sistem.models;
using rs2_rent_sistem.services;

namespace rs2_rent_sistem_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EquipmentController : ControllerBase
    {
        private readonly IEquipmentService _equipmentService;
        private readonly ILogger<EquipmentController> _logger;

        public EquipmentController(ILogger<EquipmentController> logger, IEquipmentService equipmentService)
        {
            _logger = logger;
            _equipmentService = equipmentService;
        }

        [HttpGet()]
        public IEnumerable<EquipmentListItem> Get()
        {
            return _equipmentService.Get();
        }
    }
}