namespace UniformWebservice.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PressureCheck")]
    public partial class PressureCheck
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

        public int Bar { get; set; }

        [Required]
        [StringLength(1)]
        public string BreakPoint { get; set; }

        public int? EmployeeNo { get; set; }

        public int? PreformNo { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Preform Preform { get; set; }

        public virtual ProcessOrder ProcessOrder { get; set; }
    }
}
