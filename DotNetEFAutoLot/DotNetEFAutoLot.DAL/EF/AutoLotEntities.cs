using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;
using DotNetEFAutoLot.DAL.Models;
using DotNetEFAutoLot.DAL.Interception;

namespace DotNetEFAutoLot.DAL.EF
{
    public partial class AutoLotEntities : DbContext
    {
        public AutoLotEntities()
            : base("name=AutoLotEntities")
        {
            DbInterception.Add(new ConsoleWriterInterceptor());
        }

        public virtual DbSet<CreditRisk> CreditRisks { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<AutoLotEntities>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
