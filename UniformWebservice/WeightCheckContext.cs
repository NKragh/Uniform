namespace UniformWebservice
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WeightCheckContext : DbContext
    {
        public WeightCheckContext()
            : base("name=WeightCheckContext")
        {
            base.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<ProcessOrder> ProcessOrder { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<WeightCheck> WeightCheck { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.Initials)
                .IsUnicode(false);

            modelBuilder.Entity<ProcessOrder>()
                .Property(e => e.BatchCode)
                .IsUnicode(false);

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
