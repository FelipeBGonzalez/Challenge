using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Challenge.Domain.Interfaces;
using Challenge.Domain.Models;
using Challenge.Domain.Service;
using Xunit;
using Challenge.Domain.Test;
using System.Linq;
namespace Challenge.Domain.Test
{
	public class PedidoTest: DomainTestBase
	{
		[Theory]
		[ClassData(typeof(ObterPedidoDomain))]
		public void TestPEDIDOINVALIDO(FiltroPedidoDomain filtro, PedidoDomain pedido)
		{	
			var domain = provider.GetService<ISelecionarStatusDomain>();
			var retorno  =domain.RegraStatus(pedido, filtro);
			Assert.Equal("CODIGO_PEDIDO_INVALIDO", retorno.status.First().status);
		}

		[Theory]
		[InlineData()] //Retorna 3 tabelas
		public void TestAPROVADO()
		{
			//Aprovado
			FiltroPedidoDomain filtro = new FiltroPedidoDomain();

			filtro.pedido = "123456";
			filtro.status = "APROVADO";
			filtro.valorAprovado = 20;
			filtro.itensAprovados = 3;

			PedidoDomain pedido = new PedidoDomain();
			ItemDomain item = new ItemDomain();
			pedido.itens = new List<ItemDomain>();
			pedido.pedido = "123456";

			item.descricao = "Item A";
			item.precoUnitario = 10;
			item.qtd = 1;
			pedido.itens.Add(item);
			item = new ItemDomain();
			item.descricao = "Item B";
			item.precoUnitario = 5;
			item.qtd = 2;
			pedido.itens.Add(item);

			var domain = provider.GetService<ISelecionarStatusDomain>();
			var retorno = domain.RegraStatus(pedido, filtro);
			Assert.Equal("APROVADO", retorno.status.First().status);
		}

		[Theory]
		[InlineData()] //Retorna 3 tabelas
		public void TestVALORAMENOR()
		{
			FiltroPedidoDomain filtro = new FiltroPedidoDomain();
			filtro.pedido = "123456";
			filtro.status = "APROVADO";
			filtro.valorAprovado = 10;
			filtro.itensAprovados = 3;

			PedidoDomain pedido = new PedidoDomain();
			ItemDomain item = new ItemDomain();
			pedido.itens = new List<ItemDomain>();
			pedido.pedido = "123456";

			item.descricao = "Item A";
			item.precoUnitario = 10;
			item.qtd = 1;
			pedido.itens.Add(item);
			item = new ItemDomain();
			item.descricao = "Item B";
			item.precoUnitario = 5;
			item.qtd = 2;
			pedido.itens.Add(item);

			var domain = provider.GetService<ISelecionarStatusDomain>();
			var retorno = domain.RegraStatus(pedido, filtro);
			Assert.Equal("APROVADO_VALOR_A_MENOR", retorno.status.First().status);
		}
		[Theory]
		[InlineData()] //Retorna 3 tabelas
		public void TestQTDAMENOR()
		{
			FiltroPedidoDomain filtro = new FiltroPedidoDomain();
			filtro.pedido = "123456";
			filtro.status = "APROVADO";
			filtro.valorAprovado = 20;
			filtro.itensAprovados = 2;

			PedidoDomain pedido = new PedidoDomain();
			ItemDomain item = new ItemDomain();
			pedido.itens = new List<ItemDomain>();
			pedido.pedido = "123456";

			item.descricao = "Item A";
			item.precoUnitario = 10;
			item.qtd = 1;
			pedido.itens.Add(item);
			item = new ItemDomain();
			item.descricao = "Item B";
			item.precoUnitario = 5;
			item.qtd = 2;
			pedido.itens.Add(item);

			var domain = provider.GetService<ISelecionarStatusDomain>();
			var retorno = domain.RegraStatus(pedido, filtro);
			Assert.Equal("APROVADO_QTD_A_MENOR", retorno.status.First().status);
		}

		[Theory]
		[InlineData()] //Retorna 3 tabelas
		public void TestVALORAMAIOR()
		{
			FiltroPedidoDomain filtro = new FiltroPedidoDomain();
			filtro.pedido = "123456";
			filtro.status = "APROVADO";
			filtro.valorAprovado = 30;
			filtro.itensAprovados = 3;

			PedidoDomain pedido = new PedidoDomain();
			ItemDomain item = new ItemDomain();
			pedido.itens = new List<ItemDomain>();
			pedido.pedido = "123456";

			item.descricao = "Item A";
			item.precoUnitario = 10;
			item.qtd = 1;
			pedido.itens.Add(item);
			item = new ItemDomain();
			item.descricao = "Item B";
			item.precoUnitario = 5;
			item.qtd = 2;
			pedido.itens.Add(item);

			var domain = provider.GetService<ISelecionarStatusDomain>();
			var retorno = domain.RegraStatus(pedido, filtro);
			Assert.Equal("APROVADO_VALOR_A_MAIOR", retorno.status.First().status);
		}

		[Theory]
		[InlineData()] //Retorna 3 tabelas
		public void TestQTDAMAIOR()
		{
			FiltroPedidoDomain filtro = new FiltroPedidoDomain();
			filtro.pedido = "123456";
			filtro.status = "APROVADO";
			filtro.valorAprovado = 20;
			filtro.itensAprovados = 4;

			PedidoDomain pedido = new PedidoDomain();
			ItemDomain item = new ItemDomain();
			pedido.itens = new List<ItemDomain>();
			pedido.pedido = "123456";

			item.descricao = "Item A";
			item.precoUnitario = 10;
			item.qtd = 1;
			pedido.itens.Add(item);
			item = new ItemDomain();
			item.descricao = "Item B";
			item.precoUnitario = 5;
			item.qtd = 2;
			pedido.itens.Add(item);

			var domain = provider.GetService<ISelecionarStatusDomain>();
			var retorno = domain.RegraStatus(pedido, filtro);
			Assert.Equal("APROVADO_QTD_A_MAIOR", retorno.status.First().status);
		}


		[Theory]
		[InlineData()] //Retorna 3 tabelas
		public void TestQTDEVALORAMAIOR()
		{
			FiltroPedidoDomain filtro = new FiltroPedidoDomain();
			filtro.pedido = "123456";
			filtro.status = "APROVADO";
			filtro.valorAprovado = 30;
			filtro.itensAprovados = 4;

			PedidoDomain pedido = new PedidoDomain();
			ItemDomain item = new ItemDomain();
			pedido.itens = new List<ItemDomain>();
			pedido.pedido = "123456";

			item.descricao = "Item A";
			item.precoUnitario = 10;
			item.qtd = 1;
			pedido.itens.Add(item);
			item = new ItemDomain();
			item.descricao = "Item B";
			item.precoUnitario = 5;
			item.qtd = 2;
			pedido.itens.Add(item);

			var domain = provider.GetService<ISelecionarStatusDomain>();
			var retorno = domain.RegraStatus(pedido, filtro);
	

			Assert.Equal("APROVADO_QTD_A_MAIOR", retorno.status.First(x=>x.status == "APROVADO_QTD_A_MAIOR").status);
			Assert.Equal("APROVADO_VALOR_A_MAIOR", retorno.status.First(x => x.status == "APROVADO_VALOR_A_MAIOR").status);
		}

		[Theory]
		[InlineData()] //Retorna 3 tabelas
		public void TestQTDEVALORAMENOR()
		{
			FiltroPedidoDomain filtro = new FiltroPedidoDomain();
			filtro.pedido = "123456";
			filtro.status = "APROVADO";
			filtro.valorAprovado = 10;
			filtro.itensAprovados = 1;

			PedidoDomain pedido = new PedidoDomain();
			ItemDomain item = new ItemDomain();
			pedido.itens = new List<ItemDomain>();
			pedido.pedido = "123456";

			item.descricao = "Item A";
			item.precoUnitario = 10;
			item.qtd = 1;
			pedido.itens.Add(item);
			item = new ItemDomain();
			item.descricao = "Item B";
			item.precoUnitario = 5;
			item.qtd = 2;
			pedido.itens.Add(item);

			var domain = provider.GetService<ISelecionarStatusDomain>();
			var retorno = domain.RegraStatus(pedido, filtro);


			Assert.Equal("APROVADO_QTD_A_MENOR", retorno.status.First(x => x.status == "APROVADO_QTD_A_MENOR").status);
			Assert.Equal("APROVADO_VALOR_A_MENOR", retorno.status.First(x => x.status == "APROVADO_VALOR_A_MENOR").status);
		}


		public class ObterPedidoDomain : IEnumerable<object[]>
		{
			public IEnumerator<object[]> GetEnumerator()
			{
				//Invalido
				FiltroPedidoDomain filtroPedidoInvalido = new FiltroPedidoDomain();
				filtroPedidoInvalido.pedido = "123456";
				filtroPedidoInvalido.status = "APROVADO";
				filtroPedidoInvalido.valorAprovado = 0;
				filtroPedidoInvalido.itensAprovados = 0;
				PedidoDomain pedidoInvalido = new PedidoDomain();
				


				yield return new object[] { filtroPedidoInvalido, pedidoInvalido };
				


			}

			IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
		}


	}
}
