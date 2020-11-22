using System;
using System.Collections.Generic;

namespace Challenge.Domain.Models
{
    public class FiltroPedidoDomain
    {
        public string status { get; set; }

        public int itensAprovados { get; set; }

        public decimal valorAprovado { get; set; }

        public string pedido { get; set; }
    }
}
