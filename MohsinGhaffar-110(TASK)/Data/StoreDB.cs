using Microsoft.EntityFrameworkCore;
using MohsinGhaffar_110_TASK_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MohsinGhaffar_110_TASK_.Data
{
    public class StoreDB : DbContext
    {
        public StoreDB(DbContextOptions<StoreDB> options) : base(options) { }
        public DbSet<OrderModel> ordermodels { get; set; }
    }
}
