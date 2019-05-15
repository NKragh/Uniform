namespace UniformWebservice.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WeightCheck")]
    public partial class WeightCheck
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProcessOrderNo { get; set; }

        [Key]
        [Column(Order = 1)]
        public TimeSpan CheckTime { get; set; }

        public double Weight1 { get; set; }

        public double Weight2 { get; set; }

        public double Weight3 { get; set; }

        public double Weight4 { get; set; }

        public double Weight5 { get; set; }

        public double Weight6 { get; set; }

        public bool Droptest { get; set; }

        [Required]
        [StringLength(140)]
        public string Comment { get; set; }

        public int? EmployeeNo { get; set; }

        public int? ProductNo { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual ProcessOrder ProcessOrder { get; set; }

        public virtual Product Product { get; set; }
    }
}
