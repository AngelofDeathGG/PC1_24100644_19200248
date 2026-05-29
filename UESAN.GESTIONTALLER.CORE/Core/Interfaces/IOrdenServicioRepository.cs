using UESAN.GESTIONTALLER.CORE.Core.Entities;
using UESAN.GESTIONTALLER.CORE.Infrastructure.Data;

namespace UESAN.GESTIONTALLER.CORE.Core.Interfaces
{
    public interface IOrdenServicioRepository
    {
        Task<IEnumerable<OrdenServicio>> GetAll();
        Task<OrdenServicio> GetById(int id);
        Task<bool> Insert(OrdenServicio orden);
        Task<bool> Update(OrdenServicio orden);
        Task<bool> Delete(int id);
    }
}