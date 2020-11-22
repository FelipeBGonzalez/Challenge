using Challenge.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge.Infra.Data
{
    public class ApiContext3 : DbContext
    {
        public ApiContext3(DbContextOptions<ApiContext3> options)
         : base(options)
        { }

        public DbSet<PedidoDomain> Pedido { get; set; }
        public DbSet<ItemDomain> Item { get; set; }

    }
}
