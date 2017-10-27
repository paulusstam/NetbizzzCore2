using Microsoft.EntityFrameworkCore;
using NetbizzzCore2.Repos.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetbizzzCore2.Repos
{
    public class NetbizzzDbContext : DbContext
    {
        public NetbizzzDbContext(DbContextOptions options) : base(options)
        {

        }

        //DB SETS
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }

        //DB OVERRIDES
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NetBizzzCore2;Integrated Security=True");
            }
        }
    }
}
