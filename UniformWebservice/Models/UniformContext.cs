using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace UniformWebservice.Models
{
    public partial class UniformContext : DbContext
    {
        public UniformContext() : base("name=UniformContext")
        {
            base.Configuration.ProxyCreationEnabled = false;
        }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Preform> Preform { get; set; }
        public virtual DbSet<PressureCheck> PressureCheck { get; set; }
        public virtual DbSet<ProcessOrder> ProcessOrder { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ShiftCheck> ShiftCheck { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<WeightCheck> WeightCheck { get; set; }
        public virtual DbSet<TasteCheck> TasteChecks { get; set; }
        public virtual DbSet<LabelCheck> LabelChecks { get; set; }
        public virtual DbSet<Label> Labels { get; set; }
        public virtual DbSet<SampleCheck> SampleChecks { get; set; }
        public virtual DbSet<PETCheck> PETChecks { get; set; }
        public virtual DbSet<TorqueCheck> TorqueChecks { get; set; }
        public virtual DbSet<Lid> Lids { get; set; }
        public virtual DbSet<CompleteCheckView> CompleteCheckViews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.Initials)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.ShiftCheck)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PressureCheck>()
                .Property(e => e.BreakPoint)
                .IsUnicode(false);

            modelBuilder.Entity<ProcessOrder>()
                .Property(e => e.BatchCode)
                .IsUnicode(false);

            modelBuilder.Entity<ProcessOrder>()
                .HasMany(e => e.PressureCheck)
                .WithRequired(e => e.ProcessOrder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProcessOrder>()
                .HasMany(e => e.ShiftCheck)
                .WithRequired(e => e.ProcessOrder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProcessOrder>()
                .HasMany(e => e.WeightCheck)
                .WithRequired(e => e.ProcessOrder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.FluidCode)
                .IsUnicode(false);
        }
    }
}
