using Challenge.Domain.Interfaces;
using Challenge.Domain.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Challenge.Infra.Data.Repository
{
    internal class PedidoRepository : IPedidoRepository
    {
        private readonly ApiContext3 _contexto;

        public PedidoRepository(ApiContext3 contexto)
        {
            _contexto = contexto;
        }
        public PedidoDomain Atualizar(PedidoDomain pedido)
        {
            this.Deletar(pedido.pedido);
            this.Inserir(pedido);            
            return pedido;
        }

        public void Deletar(string pedido)
        {
            var pedidoDomain = this.Selecionar(pedido);            
            
            if (pedidoDomain!= null)
            {
                foreach (var itemDelete in pedidoDomain.itens)
                {
                    var item2 = _contexto.Entry(itemDelete);
                    item2.State = EntityState.Deleted;                
                }

                var entry = _contexto.Entry(pedidoDomain);
                entry.State = EntityState.Deleted;
                _contexto.SaveChanges();
            }
        }

        public void Inserir(PedidoDomain pedido)
        {
            _contexto.Pedido.Add(pedido);
            _contexto.SaveChanges();
            
        }

        public  PedidoDomain Selecionar(string pedido)
        {
            var pedidoR = _contexto.Pedido.Include(u => u.itens).Include(y=>y.status)
                                .ToArray();
            if (_contexto.Pedido.Where(x => x.pedido == pedido).ToList().Count>0)
            {
                return _contexto.Pedido.Where(x => x.pedido == pedido).First();
            }
           
            return new PedidoDomain();
            
        }
     
    }
}
