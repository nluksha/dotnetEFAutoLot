using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using DotNetEFAutoLot.DAL.Models;

namespace DotNetEFAutoLot.DAL.EF
{
    public partial class AutoLotEntities : DbContext
    {
        public AutoLotEntities()
            : base("name=AutoLotEntities")
        {
        }

        public virtual DbSet<CreditRisk> CreditRisks { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inventory>()
                .Property(e => e.Make)
                .IsFixedLength();

            modelBuilder.Entity<Inventory>()
                .Property(e => e.Color)
                .IsFixedLength();

            modelBuilder.Entity<Inventory>()
                .Property(e => e.PetName)
                .IsFixedLength();
        }
    }
}
