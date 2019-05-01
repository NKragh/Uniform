namespace UniformWebservice.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
            base.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Batch> Batches { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<ProcessOrder> ProcessOrders { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Batch>()
                .Property(e => e.BatchCode)
                .IsUnicode(false);

            modelBuilder.Entity<Batch>()
                .Property(e => e.BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<Batch>()
                .Property(e => e.FluidCode)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Initials)
                .IsUnicode(false);

            modelBuilder.Entity<ProcessOrder>()
                .Property(e => e.BatchCode)
                .IsUnicode(false);
        }
    }
}
