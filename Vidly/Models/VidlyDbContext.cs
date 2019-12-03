using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Vidly.EntityConfigaration;

namespace Vidly.Models
{
    public class VidlyDbContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerConfigaration());
        }

        public VidlyDbContext():base("DefaultConnection")
        {
            
        }
    }
}