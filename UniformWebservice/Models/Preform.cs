namespace UniformWebservice.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Preform")]
    public partial class Preform
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Preform()
        {
            PressureCheck = new HashSet<PressureCheck>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PreformNo { get; set; }

        public int Size { get; set; }

        public double Weight { get; set; }

        public double MinValue { get; set; }

        public double MaxValue { get; set; }

        [StringLength(1)]
        public string SupplierName { get; set; }

        public virtual Supplier Supplier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PressureCheck> PressureCheck { get; set; }
    }
}
