using Microsoft.EntityFrameworkCore;
using SistemaPedido.Data.Context;
using SistemaPedido.Domain.Entities;
using SistemaPedido.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPedido.Data.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly DBSqlContext _context; // Use o namespace especificado

        public ProdutoRepository(DBSqlContext context)
        {
            _context = context;
        }

        public async Task<List<Produto>> GetAllAsync()
        {
            return await _context.Produto.AsNoTracking().ToListAsync();
        }

        public async Task<Produto> GetByIdAsync(int id)
        {
            return await _context.Produto.FindAsync(id);
        }

        public async Task AddAsync(Produto pedido)
        {
            await _context.Produto.AddAsync(pedido);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Produto pedido)
        {
            _context.Entry(pedido).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var produto = await _context.Produto.FindAsync(id);
            if (produto != null)
            {
                _context.Produto.Remove(produto);
                await _context.SaveChangesAsync();
            }
        }
    }
}
