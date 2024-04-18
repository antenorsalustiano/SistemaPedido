namespace SistemaPedido.Domain.Entities
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public DateTime DataPedido { get; set; }
        public int QuantidadeProdutos { get; set; }
        public decimal ValorTotalPedido { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; }
        
    }
}
