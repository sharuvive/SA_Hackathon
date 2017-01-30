using SA_Hackathon.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SA_Hackathon.DAL
{
    public class SLIITContext : DbContext
    {
        public SLIITContext() : base("SLIITContext")
        {
        }

        public DbSet<Food> Foods { get; set; }
        public DbSet<Order> Orders { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Food>()
                .HasMany(c => c.Orders).WithMany(i => i.Foods)
                .Map(t => t.MapLeftKey("fid")
                    .MapRightKey("oid")
                    .ToTable("FoodOrder"));
        }


    }
}