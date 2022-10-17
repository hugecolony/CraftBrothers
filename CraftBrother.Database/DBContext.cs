using CraftBrothers.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftBrother.Database
{
    public class DBContext : DbContext
    {
        public DBContext() : base("CraftBrother")
        {

        }
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Brand> Brands { get; set; }
    }
}
