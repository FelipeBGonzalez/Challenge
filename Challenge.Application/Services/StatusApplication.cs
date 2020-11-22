using Challenge.Application.ViewModels;
using Challenge.Domain.Interfaces;
using Challenge.Domain.Models;
using System.Collections.Generic;
using Challenge.Application.Interfaces;

namespace Challenge.Application.Services
{
    public class StatusApplication : ApplicationBase, IStatusApplication
    {
        public vmPedidoStatus Selecionar(vmFiltroPedido filtro)
        {
            var domain = GetService<ISelecionarStatusDomain>();
            var ret = domain.Execute(ConvertToModelView(filtro));
            var result = ConvertToViewModel(ret);
            return result;
        }

        private static vmPedidoStatus ConvertToViewModel(PedidoDomain d)
        {
            vmPedidoStatus item = new vmPedidoStatus();
            vmStatus vmStatus;
            item.pedido = d.pedido;
            foreach (var pedido in d.status)
            {
                vmStatus = new vmStatus();
                vmStatus.status = pedido.status;
                item.status.Add(vmStatus);
            }
            return item;
        }
        private static FiltroPedidoDomain ConvertToModelView(vmFiltroPedido v)
        {
            var item = new FiltroPedidoDomain
            {
                pedido = v.pedido,
                itensAprovados = v.itensAprovados,
                status = v.status,
                valorAprovado = v.valorAprovado,
            };
            return item;
        }
    }
}
