using Microsoft.EntityFrameworkCore;
using UESAN.GESTIONTALLER.CORE.Core.Entities;
using UESAN.GESTIONTALLER.CORE.Core.Interfaces;
using UESAN.GESTIONTALLER.CORE.Infrastructure.Data;

namespace UESAN.GESTIONTALLER.CORE.Infrastructure.Repositories
{
    public class OrdenServicioRepository : IOrdenServicioRepository
    {
        private readonly TallerDbContext _context;

        public OrdenServicioRepository(TallerDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<OrdenServicio>> GetAll() => await _context.OrdenServicio.ToListAsync();

        public async Task<OrdenServicio> GetById(int id) => await _context.OrdenServicio.FindAsync(id);

        public async Task<bool> Insert(OrdenServicio orden)
        {
            _context.OrdenServicio.Add(orden);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Update(OrdenServicio orden)
        {
            _context.OrdenServicio.Update(orden);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Delete(int id)
        {
            var orden = await _context.OrdenServicio.FindAsync(id);
            if (orden == null) return false;
            _context.OrdenServicio.Remove(orden);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}