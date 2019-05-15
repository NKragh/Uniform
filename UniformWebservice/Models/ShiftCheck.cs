namespace UniformWebservice.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShiftCheck")]
    public partial class ShiftCheck
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProcessOrderNo { get; set; }

        [Key]
        [Column(Order = 1)]
        public TimeSpan CheckTime { get; set; }

        public bool TopLabel { get; set; }

        public bool TapPipe { get; set; }

        public bool Sugar { get; set; }

        public int PalletNo { get; set; }

        public int EmployeeNo { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual ProcessOrder ProcessOrder { get; set; }
    }
}
