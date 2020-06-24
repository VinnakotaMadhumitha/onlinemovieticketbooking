using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ombtmvc1.Models
{
    public class OmbtContext : DbContext
    {
        public OmbtContext() :base("ombtmvc")
        {

        }
      public  DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        public DbSet <Movie> Movies { get; set; }
        public DbSet<Cart> Carts { get; set; }
     }
}