namespace UniformWebservice.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProcessOrder")]
    public partial class ProcessOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProcessOrderNo { get; set; }

        public DateTime ProcessDate { get; set; }

        [Required]
        [StringLength(1)]
        public string BatchCode { get; set; }

        public bool IsComplete { get; set; }

        public int ColumnNo { get; set; }

        public int? ProductNo { get; set; }

        public int? EmployeeNo { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Product Product { get; set; }
    }
}
