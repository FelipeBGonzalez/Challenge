using Challenge.Application.ViewModels;
using Challenge.Domain.Models;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace Challenge.Application.Interfaces
{
    public interface IPedidoApplication
    {
        vmPedido Selecionar(string pedido);
        void Deletar(string pedidot);
        vmPedido Atualizar(vmPedido pedido);
        void Inserir(vmPedido pedido);
    }
}