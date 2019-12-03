using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Vidly.Models;

namespace Vidly.EntityConfigaration
{
    public class CustomerConfigaration:EntityTypeConfiguration<Customer>
    {
        public CustomerConfigaration()
        {
            Property(c => c.Name).IsRequired().HasMaxLength(255);
            HasIndex(c => c.Name).IsUnique();
            HasRequired(c => c.MembershipType).WithMany(m => m.Customers).HasForeignKey(c => c.MemberShipTypeId);
        }
    }
}