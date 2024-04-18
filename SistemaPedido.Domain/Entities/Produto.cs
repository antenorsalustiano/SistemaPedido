using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPedido.Domain.Entities
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public DateTime? DataCadastro { get; set; }
        public decimal? Valor { get; set; }

        public List<Pedido> Pedido { get; set; }

        
    }
}
