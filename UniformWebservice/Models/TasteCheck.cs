namespace UniformWebservice
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TasteCheck")]
    public partial class TasteCheck
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProcessOrderNo { get; set; }

        [Key]
        [Column(Order = 1)]
        public TimeSpan CheckTime { get; set; }

        public int TankNo { get; set; }

        public bool TasteOk { get; set; }

        public int? EmployeeNo { get; set; }
    }
}
