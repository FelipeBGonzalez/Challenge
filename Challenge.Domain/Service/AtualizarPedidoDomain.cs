using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Challenge.Domain.Interfaces;
using Challenge.Domain.Models;

namespace Challenge.Domain.Service
{
    public class AtualizarPedidoDomain : IAtualizarPedidoDomain
    {
        public PedidoDomain Execute(PedidoDomain pedido)
        {
            
            var result = DomainBase.provider.GetService<IPedidoRepository>().Atualizar(pedido);                         
            return result;
        }
    }
}
