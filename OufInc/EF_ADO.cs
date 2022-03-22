using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace OufInc
{
    public partial class EF_ADO : DbContext
    {
        public EF_ADO()
            : base("name=localDB")
        {
        }

        public virtual DbSet<Good> Goods { get; set; }
        public virtual DbSet<Goods_Goods_Dimensions> Goods_Dimensions { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Invoice_Items> Invoice_Items { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Trader> Traders { get; set; }
        public virtual DbSet<Transefer_Items> Transefer_Items { get; set; }
        public virtual DbSet<Transfer> Transfers { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Good>()
                .Property(e => e.Goods_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Good>()
                .HasMany(e => e.Goods_Goods_Dimensions)
                .WithRequired(e => e.Good)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Good>()
                .HasMany(e => e.Invoice_Items)
                .WithRequired(e => e.Good)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Good>()
                .HasMany(e => e.Transefer_Items)
                .WithRequired(e => e.Good)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Goods_Goods_Dimensions>()
                .Property(e => e.Goods_Dimensions)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .HasMany(e => e.Invoice_Items)
                .WithRequired(e => e.Invoice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Trader>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Trader>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<Trader>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Trader>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Trader>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Trader>()
                .Property(e => e.Website)
                .IsUnicode(false);

            modelBuilder.Entity<Trader>()
                .HasMany(e => e.Invoices)
                .WithRequired(e => e.Trader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Trader>()
                .HasMany(e => e.Transfers)
                .WithRequired(e => e.Trader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transfer>()
                .HasMany(e => e.Transefer_Items)
                .WithRequired(e => e.Transfer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Warehouse>()
                .Property(e => e.Warehouse_Address)
                .IsUnicode(false);

            modelBuilder.Entity<Warehouse>()
                .Property(e => e.Manager)
                .IsUnicode(false);

            modelBuilder.Entity<Warehouse>()
                .Property(e => e.Warehouse_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.Invoices)
                .WithRequired(e => e.Warehouse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.Transfers)
                .WithRequired(e => e.Warehouse)
                .HasForeignKey(e => e.ToWarehouse_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.Transfers1)
                .WithRequired(e => e.Warehouse1)
                .HasForeignKey(e => e.FromWarehouse_ID)
                .WillCascadeOnDelete(false);
        }
    }
}
