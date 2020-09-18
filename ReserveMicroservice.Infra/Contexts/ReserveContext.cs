
using ReserveMicroservice.Domain.AggregatesModel.ReserveAggregate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Transactions;

namespace ReserveMicroservice.Infra.Contexts
{
    public class ReserveContext : DbContext
    {
        public DbSet<Reserve> Reserves { get; set; }
        public DbSet<MoneyValue> MoneyValues { get; set; }

        public ReserveContext(DbContextOptions<ReserveContext> options)
    : base(options)
        { }
  
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Reserve>(c =>
            //{
                //c.ToTable("Reserves");
                //c.HasKey(c => c.Id).HasName("Id");
                //c.Property(c => c.Id).HasColumnName("Id").HasMaxLength(450)
                // .HasConversion(
                // Id => Id.ToString(),
                // Id => Guid.Parse(Id))
                //.HasColumnName("Id");
                //c.Property(c => c.CarId).HasColumnName("CarId").HasMaxLength(450)
                //.HasConversion(
                // CarId => CarId.ToString(),
                // CarId => Guid.Parse(CarId))
                //.HasColumnName("CarId");
                //c.Property(c => c.ActionType).HasColumnName("ActionType");
                //c.Property(c => c.RentalDate).HasColumnName("RentalDate");
                //.HasConversion(
                // RentalDate => RentalDate.ToString(),
                // RentalDate => DateTime.Parse(RentalDate))
                //.HasColumnName("RentalDate");
                //c.Property(c => c.DevolutionDate).HasColumnName("DevolutionDate");
                //.HasConversion(
                //  DevolutionDate => DevolutionDate.ToString(),
                //  DevolutionDate => DateTime.Parse(DevolutionDate))
                // .HasColumnName("DevolutionDate");

                //c.Property(c => c.Value).HasColumnName("Value")
                //.HasConversion(
                // Value => Value.ToString(),
                // Value => MoneyValue.Parse(Value))
                //.HasColumnName("Value");

         //   });

        }
    }
}
