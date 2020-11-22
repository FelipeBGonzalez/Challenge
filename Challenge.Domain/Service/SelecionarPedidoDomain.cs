using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Challenge.Domain.Interfaces;
using Challenge.Domain.Models;


namespace Challenge.Domain.Service
{
    public class SelecionarPedidoDomain : ISelecionarPedidoDomain
    {
        public PedidoDomain Execute(string pedido)
        {
            var result = DomainBase.provider.GetService<IPedidoRepository>().Selecionar(pedido);                         
            return result;
        }
    }
}
