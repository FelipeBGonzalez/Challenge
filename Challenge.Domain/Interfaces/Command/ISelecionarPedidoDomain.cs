using Challenge.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge.Domain.Interfaces
{ 
    public interface ISelecionarPedidoDomain
    {
        PedidoDomain Execute(string pedido);
    }
}
