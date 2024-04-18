using SistemaPedido.Domain.Entities;
using SistemaPedido.Domain.Interfaces;
using SistemaPedido.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPedido.Service.Services
{
    public class FornecedorService : IFornecedorService
    {
        private readonly IFornecedorRepository _fornecedorRepository;

        public FornecedorService(IFornecedorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }

        public async Task<List<Fornecedor>> GetAllFornecedoresAsync()
        {
            return await _fornecedorRepository.GetAllAsync();
        }

        public async Task<Fornecedor> GetFornecedorByIdAsync(int id)
        {
            return await _fornecedorRepository.GetByIdAsync(id);
        }

        public async Task AddFornecedorAsync(Fornecedor fornecedor)
        {
            await _fornecedorRepository.AddAsync(fornecedor);
        }

        public async Task UpdateFornecedorAsync(Fornecedor fornecedor)
        {
            await _fornecedorRepository.UpdateAsync(fornecedor);
        }

        public async Task DeleteFornecedorAsync(int id)
        {
            await _fornecedorRepository.DeleteAsync(id);
        }
    }
}
