using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPedido.Domain.Entities.DTO
{
    public class PedidoLista
    {
        public int PedidoId { get; set; }
        public int produtoId { get; set; }
        public string produtoDescricao { get; set; }
        public int quantidadeProdutos { get; set;}
        public decimal valorTotalPedido { get; set; }
        public int fornecedorId { get; set; }
        public string razaoSocial { get; set; }
        public DateTime dataPedido { get; set; }

    }
}
