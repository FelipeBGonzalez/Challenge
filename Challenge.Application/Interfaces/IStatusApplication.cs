using Challenge.Application.ViewModels;
using Challenge.Domain.Models;
using System.Collections.Generic;

namespace Challenge.Application.Interfaces
{
    public interface IStatusApplication
    {
        vmPedidoStatus Selecionar(vmFiltroPedido filtro);
    }
}