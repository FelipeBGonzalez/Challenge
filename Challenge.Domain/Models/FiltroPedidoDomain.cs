using System;
using System.Collections.Generic;

namespace Challenge.Domain.Models
{
	public class PedidoDomain
	{
		public PedidoDomain()
		{
			itens = new List<ItemDomain>();
		}
		public string Id { get; set; }
		public string pedido { get; set; }
		public List<ItemDomain> itens { get; set; }
		public List<StatusDomain> status { get; set; }
	}
}
