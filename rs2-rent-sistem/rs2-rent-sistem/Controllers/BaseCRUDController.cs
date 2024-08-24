using Microsoft.AspNetCore.Mvc;
using rs2_rent_sistem.Model.Models;
using rs2_rent_sistem.Model.SearchObjects;
using rs2_rent_sistem.Services.Interfaces;

namespace rs2_rent_sistem_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseCRUDController<T, TSearch, TInsert, Tupdate> : BaseController<T, TSearch> where T : class where TSearch : class where TInsert : class where Tupdate : class
    {
        protected new readonly ICRUDService<T, TSearch, TInsert, Tupdate> _service;
        protected readonly ILogger<BaseController<T, TSearch>> _logger;
        private ILogger<BaseController<EquipmentCategory, EquipmentCategorySearchObject>> logger;
        private IEquipmentService service;

        public BaseCRUDController(ILogger<BaseController<T, TSearch>> logger, ICRUDService<T, TSearch, TInsert, Tupdate> service)
            : base(logger, service)
        {
            _service = service;
            _logger = logger;
        }

        [HttpPost()]
        public virtual async Task<T> Insert([FromBody] TInsert insert)
        {
            return await _service.Insert(insert);
        }

        [HttpPut("{id}")]
        public virtual async Task<T> Update(int id, [FromBody] Tupdate update)
        {
            return await _service.Update(id, update);
        }
    }
}
