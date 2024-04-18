using SistemaPedido.Domain.Entities;
using SistemaPedido.Domain.Entities.DTO;

namespace SistemaPedido.Domain.Interfaces
{
    public interface IPedidoRepository
    {
        Task<List<PedidoLista>> GetAllAsync();
        Task<Pedido> GetByIdAsync(int id);
        Task AddAsync(Pedido fornecedor);
        Task UpdateAsync(Pedido fornecedor);
        Task DeleteAsync(int id);
    }
}
