namespace UniformWebservice.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PETCheck")]
    public partial class PETCheck
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProcessOrderNo { get; set; }

        [Key]
        [Column(Order = 1)]
        public TimeSpan CheckTime { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FormNo { get; set; }

        public double BottomValue { get; set; }

        public double MidValue { get; set; }

        public double TopValue { get; set; }

        [Required]
        [StringLength(140)]
        public string Comment { get; set; }

        public int? EmployeeNo { get; set; }

        public int? PreformNo { get; set; }
    }
}
