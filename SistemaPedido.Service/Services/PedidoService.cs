using SistemaPedido.Domain.Entities;
using SistemaPedido.Domain.Entities.DTO;
using SistemaPedido.Domain.Interfaces;
using SistemaPedido.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPedido.Service.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;

        public PedidoService(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public async Task<List<PedidoLista>> GetAllPedidoAsync()
        {
            return await _pedidoRepository.GetAllAsync();
        }

        public async Task<Pedido> GetPedidoByIdAsync(int id)
        {
            return await _pedidoRepository.GetByIdAsync(id);
        }

        public async Task AddPedidoAsync(PeditoDto pedidodto)
        {
            Pedido pedido = new Pedido();
            pedido.ProdutoId = pedidodto.ProdutoId;
            pedido.QuantidadeProdutos = pedidodto.QuantidadeProdutos;
            pedido.DataPedido = pedidodto.DataPedido;
            pedido.FornecedorId = pedidodto.FornecedorId;
            pedido.ValorTotalPedido = pedidodto.ValorTotalPedido;

            await _pedidoRepository.AddAsync(pedido);
        }

        public async Task UpdatePedidoAsync(PeditoDto pedidodto)
        {
            Pedido pedido = new Pedido();
            pedido.PedidoId = pedido.PedidoId;
            pedido.ProdutoId = pedidodto.ProdutoId;
            pedido.QuantidadeProdutos = pedidodto.QuantidadeProdutos;
            pedido.DataPedido = pedidodto.DataPedido;
            pedido.FornecedorId = pedidodto.FornecedorId;
            pedido.ValorTotalPedido = pedidodto.ValorTotalPedido;

            await _pedidoRepository.UpdateAsync(pedido);
        }

        public async Task DeletePedidoAsync(int id)
        {
            await _pedidoRepository.DeleteAsync(id);
        }
    }
}
