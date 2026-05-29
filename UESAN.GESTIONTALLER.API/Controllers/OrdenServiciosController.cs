using Microsoft.AspNetCore.Mvc;
using UESAN.GESTIONTALLER.CORE.Core.Entities;
using UESAN.GESTIONTALLER.CORE.Core.Interfaces;
using UESAN.GESTIONTALLER.CORE.Infrastructure.Data;

namespace UESAN.GESTIONTALLER.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdenServiciosController : ControllerBase
    {
        private readonly IOrdenServicioService _service;

        public OrdenServiciosController(IOrdenServicioService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _service.GetAllOrdenes());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var orden = await _service.GetOrdenById(id);
            return orden == null ? NotFound() : Ok(orden);
        }

        [HttpPost]
        public async Task<IActionResult> Post(OrdenServicio orden) => Ok(await _service.InsertOrden(orden));

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, OrdenServicio orden) => Ok(await _service.UpdateOrden(id, orden));

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) => Ok(await _service.DeleteOrden(id));
    }
}