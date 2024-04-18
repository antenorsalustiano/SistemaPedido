using SistemaPedido.Domain.Entities;
using SistemaPedido.Domain.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPedido.Service.Interface
{
    public interface IProdutoService
    {
        Task<List<Produto>> GetAllProdutoAsync();
        Task<Produto> GetProdutoByIdAsync(int id);
        Task AddProdutoAsync(ProdutoDto produto);
        Task UpdateProdutoAsync(ProdutoDto produto);
        Task DeleteProdutoAsync(int id);
    }
}
