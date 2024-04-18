using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPedido.Domain.Entities
{
    public class Fornecedor
    {
        [Key]
        public int FornecedorId { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string UF { get; set; }
        public string EmailContato { get; set; }
        public string NomeContato { get; set; }
        // Relacionamento com os pedidos

        public int pedidoId { get; set; }
        public ICollection<Pedido> Pedido { get; set; }
    }
}
