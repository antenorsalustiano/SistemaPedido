using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaPedido.Domain.Entities;
using SistemaPedido.Domain.Entities.DTO;
using SistemaPedido.Domain.Interfaces;
using SistemaPedido.Service.Interface;

namespace SistemaPedido.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            this.produtoService = produtoService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> GetProduto()
        {
            var produto = await produtoService.GetAllProdutoAsync();
            return Ok(produto);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> GetProduto(int id)
        {
            var produto = await produtoService.GetProdutoByIdAsync(id);
            if (produto == null)
            {
                return NotFound();
            }
            return Ok(produto);
        }

        [HttpPost]
        public async Task<ActionResult<Produto>> PostProduto(ProdutoDto produto)
        {
            await produtoService.AddProdutoAsync(produto);
            return CreatedAtAction(nameof(GetProduto), new { id = produto.ProdutoId }, produto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduto(int id, ProdutoDto produto)
        {
            if (id != produto.ProdutoId)
            {
                return BadRequest();
            }

            try
            {
                await produtoService.UpdateProdutoAsync(produto);
            }
            catch (Exception)
            {
                if (await produtoService.GetProdutoByIdAsync(id) == null)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduto(int id)
        {
            var produto = await produtoService.GetProdutoByIdAsync(id);
            if (produto == null)
            {
                return NotFound();
            }

            await produtoService.DeleteProdutoAsync(id);
            return NoContent();
        }
    }
}

