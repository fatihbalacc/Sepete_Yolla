using Microsoft.EntityFrameworkCore;
using SepeteYolla.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepeteYolla.DataAccess
{
    public class SepeteYollaDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-UEA6853\\KOTALKAHN;Initial Catalog=SepeteYolla;Integrated Security=True");
        }

        public DbSet<Administator> Administators { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Product_Kind> Product_Kinds { get; set; }
        public DbSet<Purchased> Purchaseds { get; set; }
        public DbSet<Shopping_Cart> Shopping_Carts { get; set; }
    }
}
