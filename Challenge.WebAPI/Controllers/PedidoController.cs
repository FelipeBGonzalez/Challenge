using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.Extensions.DependencyInjection;
using Challenge.Application.ViewModels;
using Challenge.Application.Interfaces;
using Challenge.Domain.Models;
using Challenge.Infra.Data;

namespace Challenge.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]    
    public class PedidoController : WebApiControllerBase
    {

        [HttpGet()]
        public IActionResult GET(string pedido)
        {
            vmPedido retorno = new vmPedido();
            try
            {
                var service = Provider.GetService<IPedidoApplication>();

                retorno = service.Selecionar(pedido);

                return Ok(retorno);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete()]
        public IActionResult Delete(string pedido)
        {            
            try
            {
                var service = Provider.GetService<IPedidoApplication>();
                service.Deletar(pedido);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut()]
        public IActionResult PUT(vmPedido pedido)
        {            
            try
            {
                var service = Provider.GetService<IPedidoApplication>();
                var data = service.Atualizar(pedido);

                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpPost()]
        public IActionResult POST(vmPedido pedido)
        {            
            try
            {
                var service = Provider.GetService<IPedidoApplication>();
                service.Inserir(pedido);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
