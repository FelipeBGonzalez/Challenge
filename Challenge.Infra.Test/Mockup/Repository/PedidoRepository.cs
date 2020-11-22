using Challenge.Domain.Interfaces;
using Challenge.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge.Infra.Test.Mockup.Repository
{
    internal class PedidoRepositoryTest : IPedidoRepository
    {
        public PedidoDomain Atualizar(PedidoDomain pedido)
        {
            throw new NotImplementedException();
        }

        public void Deletar(string pedid)
        {
            throw new NotImplementedException();
        }

        public void Inserir(PedidoDomain pedido)
        {
            throw new NotImplementedException();
        }

        public PedidoDomain Selecionar(string pedido)
        {
            throw new NotImplementedException();
        }
    }
}
