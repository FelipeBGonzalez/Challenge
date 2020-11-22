using Challenge.Application.ViewModels;
using Challenge.Domain.Interfaces;
using Challenge.Domain.Models;
using System.Collections.Generic;
using Challenge.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Challenge.Application.Services
{
    public class PedidoApplication : ApplicationBase, IPedidoApplication
    {
        public vmPedido Selecionar(string pedido)
        {
            var domain = GetService<ISelecionarPedidoDomain>();
            var ret = domain.Execute(pedido);
            var result = ConvertToViewModel(ret);
            return result;
        }

        public void Deletar(string pedido)
        {
            var domain = GetService<IDeletarPedidoDomain>();
            domain.Execute(pedido);
        }

        public vmPedido Atualizar(vmPedido pedido)
        {
            var domain = GetService<IAtualizarPedidoDomain>();
            var ret = domain.Execute(ConvertToModelView(pedido));
            var result = ConvertToViewModel(ret);
            return result;
        }
        public void Inserir(vmPedido pedido)
        {
            var domain = GetService<IInserirPedidoDomain>();
            domain.Execute(ConvertToModelView(pedido));            
        }

        private static vmPedido ConvertToViewModel(PedidoDomain d)
        {
            vmPedido retorno = new vmPedido();
            vmItem vmItem;
            vmStatus vmStatus;
            retorno.pedido = d.pedido;
            
            foreach (var item in d.itens)
            {
                vmItem = new vmItem();
                
                vmItem.descricao = item.descricao;
                vmItem.precoUnitario = item.precoUnitario;
                vmItem.qtd = item.qtd;
                retorno.itens.Add(vmItem);
            }

            return retorno;
        }
        private static PedidoDomain ConvertToModelView(vmPedido v)
        {

            PedidoDomain retorno = new PedidoDomain();
            retorno.itens = new List<ItemDomain>();
            retorno.status = new List<StatusDomain>();
            ItemDomain itemDomain;
            StatusDomain statusDomain;
            retorno.pedido = v.pedido;
            retorno.Id = v.pedido;

            foreach (var item in v.itens)
            {
                itemDomain = new ItemDomain();
                itemDomain.Id = item.descricao;
                itemDomain.descricao = item.descricao;
                itemDomain.precoUnitario = item.precoUnitario;
                itemDomain.qtd = item.qtd;
                retorno.itens.Add(itemDomain);
            }        

            return retorno;
        }
    }
}
