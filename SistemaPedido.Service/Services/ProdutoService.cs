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
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }

        public async Task<List<Produto>> GetAllProdutoAsync()
        {
            return await this.produtoRepository.GetAllAsync();
        }

        public async Task<Produto> GetProdutoByIdAsync(int id)
        {
            return await this.produtoRepository.GetByIdAsync(id);
        }

        public async Task AddProdutoAsync(ProdutoDto produtodto)
        {
            Produto produto = new Produto();
            produto.Descricao = produtodto.Descricao;
            produto.DataCadastro = produtodto.DataCadastro;
            produto.Codigo =  produtodto.Codigo;
            produto.Valor = produtodto.Valor;

            await this.produtoRepository.AddAsync(produto);
        }

        public async Task UpdateProdutoAsync(ProdutoDto produtodto)
        {
            Produto produto = new Produto();
            produto.ProdutoId = produtodto.ProdutoId;
            produto.Descricao = produtodto.Descricao;
            produto.DataCadastro = produtodto.DataCadastro;
            produto.Codigo = produtodto.Codigo;
            produto.Valor = produtodto.Valor;

            await this.produtoRepository.UpdateAsync(produto);
        }

        public async Task DeleteProdutoAsync(int id)
        {
            await this.produtoRepository.DeleteAsync(id);
        }
    }
}
