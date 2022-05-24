using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CakeHTShop.Models;

namespace CakeHTShop.Data
{
    public class CakeHTShopContext : DbContext
    {
        public CakeHTShopContext(DbContextOptions<CakeHTShopContext> options)
        : base(options)
        {
        }
        public DbSet<CakeHTShop.Models.Cake> Cake { get; set; }
    }
}