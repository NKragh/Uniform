namespace UniformWebservice.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TorqueCheck")]
    public partial class TorqueCheck
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProcessOrderNo { get; set; }

        [Key]
        [Column(Order = 1)]
        public TimeSpan CheckTime { get; set; }

        public double PreformTemp { get; set; }

        public double Torque { get; set; }

        public int? EmployeeNo { get; set; }

        public int? LidNo { get; set; }

        public int? PreformNo { get; set; }

        public virtual Lid Lid { get; set; }
    }
}
