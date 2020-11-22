using Challenge.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge.Domain.Interfaces
{
    public interface IPedidoRepository
    {
        PedidoDomain Selecionar(string pedido);
        void Deletar(string pedido);
        void Inserir(PedidoDomain pedido);
        PedidoDomain Atualizar(PedidoDomain pedido);
    }
}
