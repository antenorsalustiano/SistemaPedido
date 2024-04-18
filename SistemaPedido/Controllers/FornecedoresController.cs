using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaPedido.Domain.Entities;
using SistemaPedido.Service.Interface;

namespace SistemaPedido.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedoresController : ControllerBase
    {
        private readonly IFornecedorService _fornecedorService;

        public FornecedoresController(IFornecedorService fornecedorService)
        {
            _fornecedorService = fornecedorService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fornecedor>>> GetFornecedores()
        {
            var fornecedores = await _fornecedorService.GetAllFornecedoresAsync();
            return Ok(fornecedores);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Fornecedor>> GetFornecedor(int id)
        {
            var fornecedor = await _fornecedorService.GetFornecedorByIdAsync(id);
            if (fornecedor == null)
            {
                return NotFound();
            }
            return Ok(fornecedor);
        }

        [HttpPost]
        public async Task<ActionResult<Fornecedor>> PostFornecedor(Fornecedor fornecedor)
        {
            await _fornecedorService.AddFornecedorAsync(fornecedor);
            return CreatedAtAction(nameof(GetFornecedor), new { id = fornecedor.FornecedorId }, fornecedor);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutFornecedor(int id, Fornecedor fornecedor)
        {
            if (id != fornecedor.FornecedorId)
            {
                return BadRequest();
            }

            try
            {
                await _fornecedorService.UpdateFornecedorAsync(fornecedor);
            }
            catch (Exception)
            {
                if (await _fornecedorService.GetFornecedorByIdAsync(id) == null)
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
        public async Task<IActionResult> DeleteFornecedor(int id)
        {
            var fornecedor = await _fornecedorService.GetFornecedorByIdAsync(id);
            if (fornecedor == null)
            {
                return NotFound();
            }

            await _fornecedorService.DeleteFornecedorAsync(id);
            return NoContent();
        }
    }
}
