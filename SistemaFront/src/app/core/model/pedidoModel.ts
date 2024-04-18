export interface PedidoModal{
    pedidoId: number;
    produtoId: number;
    produtoDescricao: string;
    quantidadeProdutos: number;
    dataPedido: Date;
    fornecedorId: number;
    razaoSocial: string;
    valorTotalPedido: number;
}