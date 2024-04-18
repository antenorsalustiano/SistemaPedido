using Microsoft.EntityFrameworkCore;
using SistemaPedido.Domain.Entities;
using SistemaPedido.Domain.Interfaces;
using SistemaPedido.Data.Context;

namespace SistemaPedido.Data.Repository
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly DBSqlContext _context; // Use o namespace especificado

        public FornecedorRepository(DBSqlContext context)
        {
            _context = context;
        }


        public async Task<List<Fornecedor>> GetAllAsync()
        {
            return await _context.Fornecedor.AsNoTracking().ToListAsync();
        }

        public async Task<Fornecedor> GetByIdAsync(int id)
        {
            return await _context.Fornecedor.FindAsync(id);
        }

        public async Task AddAsync(Fornecedor fornecedor)
        {
            await _context.Fornecedor.AddAsync(fornecedor);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Fornecedor fornecedor)
        {
            _context.Entry(fornecedor).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var fornecedor = await _context.Fornecedor.FindAsync(id);
            if (fornecedor != null)
            {
                _context.Fornecedor.Remove(fornecedor);
                await _context.SaveChangesAsync();
            }
        }
    }
}
