using SistemaPedido.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPedido.Domain.Interfaces
{
    public interface IFornecedorRepository
    {
        Task<List<Fornecedor>> GetAllAsync();
        Task<Fornecedor> GetByIdAsync(int id);
        Task AddAsync(Fornecedor fornecedor);
        Task UpdateAsync(Fornecedor fornecedor);
        Task DeleteAsync(int id);
    }
}
