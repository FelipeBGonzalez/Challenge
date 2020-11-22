using Challenge.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge.Domain.Interfaces
{ 
    public interface ISelecionarStatusDomain
    {
        PedidoDomain Execute(FiltroPedidoDomain filtro);
        PedidoDomain RegraStatus(PedidoDomain pedido, FiltroPedidoDomain filtro);
    }
}
