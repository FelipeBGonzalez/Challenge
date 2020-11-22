using Challenge.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge.Domain.Interfaces
{ 
    public interface IAtualizarPedidoDomain
    {
        PedidoDomain Execute(PedidoDomain pedido);
    }
}
