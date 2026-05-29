using UESAN.GESTIONTALLER.CORE.Core.Entities;
using UESAN.GESTIONTALLER.CORE.Core.Interfaces;
using UESAN.GESTIONTALLER.CORE.Infrastructure.Data;

namespace UESAN.GESTIONTALLER.CORE.Core.Services
{
    public class OrdenServicioService : IOrdenServicioService
    {
        private readonly IOrdenServicioRepository _repository;

        public OrdenServicioService(IOrdenServicioRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<OrdenServicio>> GetAllOrdenes() => await _repository.GetAll();
        public async Task<OrdenServicio> GetOrdenById(int id) => await _repository.GetById(id);
        public async Task<bool> InsertOrden(OrdenServicio orden) => await _repository.Insert(orden);
        public async Task<bool> UpdateOrden(int id, OrdenServicio orden)
        {
            if (id != orden.Id) return false;
            return await _repository.Update(orden);
        }
        public async Task<bool> DeleteOrden(int id) => await _repository.Delete(id);
    }
}