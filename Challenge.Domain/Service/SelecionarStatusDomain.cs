using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Challenge.Domain.Interfaces;
using Challenge.Domain.Models;

namespace Challenge.Domain.Service
{
    public class SelecionarStatusDomain : ISelecionarStatusDomain
    {
        public PedidoDomain Execute(FiltroPedidoDomain filtro)
        {
            PedidoDomain pedido = new PedidoDomain();
            SelecionarPedidoDomain domainPedido = new SelecionarPedidoDomain();
            pedido = domainPedido.Execute(filtro.pedido);            
            return this.RegraStatus(pedido, filtro);
        }

        public PedidoDomain RegraStatus(PedidoDomain pedido, FiltroPedidoDomain filtro)
        {
            PedidoDomain retorno = new PedidoDomain();
            retorno.status = new List<StatusDomain>();
            StatusDomain status;
            int qtdItens = 0;
            decimal valorTotal = 0;
            retorno.pedido = pedido.pedido;

            if (pedido.pedido == null)
            {
                status = new StatusDomain();
                status.status = "CODIGO_PEDIDO_INVALIDO";
                retorno.status.Add(status);
                return retorno;
            }           

            foreach (var item in pedido.itens)
            {
                qtdItens = qtdItens + item.qtd;
                valorTotal = valorTotal + (item.qtd * item.precoUnitario);
            }

            if (filtro.status == "REPROVADO" || qtdItens == 0 && valorTotal == 0)
            {
                status = new StatusDomain();
                status.status = "REPROVADO";
                retorno.status.Add(status);
                return retorno;
            }

            if (filtro.itensAprovados == qtdItens && filtro.valorAprovado == valorTotal &&
                filtro.status == "APROVADO")
            {
                status = new StatusDomain();
                status.status = "APROVADO";
                retorno.status.Add(status);
            }

            if (filtro.valorAprovado < valorTotal && filtro.status == "APROVADO")
            {
                status = new StatusDomain();
                status.status = "APROVADO_VALOR_A_MENOR";
                retorno.status.Add(status);
            }

            if (filtro.itensAprovados < qtdItens && filtro.status == "APROVADO")
            {
                status = new StatusDomain();
                status.status = "APROVADO_QTD_A_MENOR";
                retorno.status.Add(status);
            }

            if (filtro.valorAprovado > valorTotal && filtro.status == "APROVADO")
            {
                status = new StatusDomain();
                status.status = "APROVADO_VALOR_A_MAIOR";
                retorno.status.Add(status);
            }

            if (filtro.itensAprovados > qtdItens && filtro.status == "APROVADO")
            {
                status = new StatusDomain();
                status.status = "APROVADO_QTD_A_MAIOR";
                retorno.status.Add(status);
            }

            

            return retorno;
        }
    }
}
