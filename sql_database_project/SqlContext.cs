using Microsoft.EntityFrameworkCore;
using sql_database_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sql_database_project
{
    public class SqlContext : DbContext
    {

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        { 
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<User> Users { get; set; }


    }
}
