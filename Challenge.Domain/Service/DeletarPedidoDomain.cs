using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Challenge.Domain.Interfaces;
using Challenge.Domain.Models;

namespace Challenge.Domain.Service
{
    public class DeletarPedidoDomain : IDeletarPedidoDomain
    {
        public void Execute(string pedido)
        {           
            DomainBase.provider.GetService<IPedidoRepository>().Deletar(pedido);          
        }
    }
}
