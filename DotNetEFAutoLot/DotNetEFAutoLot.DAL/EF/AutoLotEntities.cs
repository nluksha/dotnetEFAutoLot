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
        static readonly DatabaseLogger Logger = new DatabaseLogger("sqllog.txt", true);

        public AutoLotEntities()
            : base("name=AutoLotEntities")
        {
            // My custom
            //DbInterception.Add(new ConsoleWriterInterceptor());

            Logger.StartLogging();
            DbInterception.Add(Logger);
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

        protected override void Dispose(bool disposing)
        {
            DbInterception.Remove(Logger);
            Logger.StopLogging();

            base.Dispose(disposing);
        }
    }
}
