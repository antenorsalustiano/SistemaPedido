using SistemaPedido.Domain.Entities;
using SistemaPedido.Domain.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPedido.Service.Interface
{
    public interface IPedidoService
    {
        Task<List<PedidoLista>> GetAllPedidoAsync();
        Task<Pedido> GetPedidoByIdAsync(int id);
        Task AddPedidoAsync(PeditoDto pedido);
        Task UpdatePedidoAsync(PeditoDto pedido);
        Task DeletePedidoAsync(int id);
    }
}
