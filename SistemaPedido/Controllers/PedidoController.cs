using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaPedido.Domain.Entities;
using SistemaPedido.Domain.Entities.DTO;
using SistemaPedido.Service.Interface;

namespace SistemaPedido.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoService service;
        public PedidoController(IPedidoService pedido)
        {
            this.service = pedido;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pedido>>> GetPedido()
        {
            var pedido = await this.service.GetAllPedidoAsync();
            return Ok(pedido);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Pedido>> GetPedido(int id)
        {
            var Pedido = await this.service.GetPedidoByIdAsync(id);
            if (Pedido == null)
            {
                return NotFound();
            }
            return Ok(Pedido);
        }

        [HttpPost]
        public async Task<ActionResult<Pedido>> PostPedido(PeditoDto pedido)
        {
            await this.service.AddPedidoAsync(pedido);
            return CreatedAtAction(nameof(GetPedido), new { id = pedido.PedidoId }, pedido);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPedido(int id, PeditoDto pedido)
        {
            if (id != pedido.PedidoId)
            {
                return BadRequest();
            }

            try
            {
                await this.service.UpdatePedidoAsync(pedido);
            }
            catch (Exception)
            {
                if (await this.service.GetPedidoByIdAsync(id) == null)
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
        public async Task<IActionResult> DeletePedido(int id)
        {
            var pedido = await this.service.GetPedidoByIdAsync(id);
            if (pedido == null)
            {
                return NotFound();
            }

            await this.service.DeletePedidoAsync(id);
            return NoContent();
        }
    }
}
