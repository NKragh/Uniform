namespace UniformWebservice.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Batch")]
    public partial class Batch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Batch()
        {
            ProcessOrders = new HashSet<ProcessOrder>();
        }

        [Key]
        [StringLength(1)]
        public string BatchCode { get; set; }

        [Required]
        [StringLength(1)]
        public string BatchNo { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(1)]
        public string FluidCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcessOrder> ProcessOrders { get; set; }
    }
}
