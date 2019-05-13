namespace UniformWebservice
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            ProcessOrder = new HashSet<ProcessOrder>();
            WeightCheck = new HashSet<WeightCheck>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductNo { get; set; }

        [Required]
        [StringLength(1)]
        public string ProductName { get; set; }

        public bool Sugar { get; set; }

        public double MinValue { get; set; }

        public double MidValue { get; set; }

        public double MaxValue { get; set; }

        [Required]
        [StringLength(1)]
        public string FluidCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcessOrder> ProcessOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WeightCheck> WeightCheck { get; set; }
    }
}
