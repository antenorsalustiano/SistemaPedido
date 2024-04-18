using Microsoft.EntityFrameworkCore;
using SistemaPedido.Data.Context;
using SistemaPedido.Domain.Entities;
using SistemaPedido.Domain.Entities.DTO;
using SistemaPedido.Domain.Interfaces;


namespace SistemaPedido.Data.Repository
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly DBSqlContext _context; // Use o namespace especificado

        public PedidoRepository(DBSqlContext context)
        {
            _context = context;
        }

        public async Task<List<PedidoLista>> GetAllAsync()
        {
            try
            {
                return await _context.Pedido
                    .Include(p => p.Produto)
                    .Include(p => p.Fornecedor)
                    .Select(pedido => new PedidoLista
                    {
                        PedidoId = pedido.PedidoId,
                        fornecedorId = pedido.FornecedorId,
                        produtoDescricao = pedido.Produto.Descricao,
                        produtoId = pedido.ProdutoId,
                        quantidadeProdutos = pedido.QuantidadeProdutos,
                        razaoSocial = pedido.Fornecedor.RazaoSocial,
                        valorTotalPedido = pedido.ValorTotalPedido,
                        dataPedido = pedido.DataPedido
                    })
                    .AsNoTracking()
                    .ToListAsync();
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public async Task<Pedido> GetByIdAsync(int id)
        {
            return await _context.Pedido.FindAsync(id);
        }

        public async Task AddAsync(Pedido pedido)
        {
            try
            {
                await _context.Pedido.AddAsync(pedido);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public async Task UpdateAsync(Pedido pedido)
        {
            _context.Entry(pedido).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var pedido = await _context.Pedido.FindAsync(id);
            if (pedido != null)
            {
                _context.Pedido.Remove(pedido);
                await _context.SaveChangesAsync();
            }
        }
    }
}
