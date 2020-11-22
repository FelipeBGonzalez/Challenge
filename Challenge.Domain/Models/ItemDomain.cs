using System;
using System.Collections.Generic;

namespace Challenge.Domain.Models
{
	public class ItemDomain
	{
		public string Id { get; set; }
		public string descricao { get; set; }
		public decimal precoUnitario { get; set; }
		public int qtd { get; set; }		

		public PedidoDomain Pedido { get; set; }
	}
}
