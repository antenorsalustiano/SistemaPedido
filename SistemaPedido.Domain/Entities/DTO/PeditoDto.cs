using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPedido.Domain.Entities.DTO
{
    public  class PeditoDto
    {
        public int PedidoId { get; set; }
        public DateTime DataPedido { get; set; }
        public int ProdutoId { get; set; }
        public int QuantidadeProdutos { get; set; }
        public int FornecedorId { get; set; }
        public decimal ValorTotalPedido { get; set; }
    }
}
