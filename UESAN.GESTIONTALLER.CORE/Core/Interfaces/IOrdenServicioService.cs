using UESAN.GESTIONTALLER.CORE.Core.Entities;
using UESAN.GESTIONTALLER.CORE.Infrastructure.Data;

namespace UESAN.GESTIONTALLER.CORE.Core.Interfaces
{
    public interface IOrdenServicioService
    {
        Task<IEnumerable<OrdenServicio>> GetAllOrdenes();
        Task<OrdenServicio> GetOrdenById(int id);
        Task<bool> InsertOrden(OrdenServicio orden);
        Task<bool> UpdateOrden(int id, OrdenServicio orden);
        Task<bool> DeleteOrden(int id);
    }
}