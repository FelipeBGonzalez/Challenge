using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Challenge.Domain.Interfaces;
using Challenge.Domain.Models;

namespace Challenge.Domain.Service
{
    public class InserirPedidoDomain : IInserirPedidoDomain
    {
        public void Execute(PedidoDomain pedido)
        {
            DomainBase.provider.GetService<IPedidoRepository>().Inserir(pedido);                                     
        }
    }
}
