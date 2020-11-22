using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.Extensions.DependencyInjection;
using Challenge.Application.ViewModels;
using Challenge.Application.Interfaces;
using Challenge.Domain.Models;

namespace Challenge.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]    
    public class StatusController : WebApiControllerBase
    {        [HttpPost()]
        public IActionResult POST(vmFiltroPedido filtro)
        {            
            try
            {
                var service = Provider.GetService<IStatusApplication>();
                var data = service.Selecionar(filtro);

                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

       
    }
}
