namespace UniformWebservice.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LabelCheck")]
    public partial class LabelCheck
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProcessOrderNo { get; set; }

        [Key]
        [Column(Order = 1)]
        public TimeSpan CheckTime { get; set; }

        public DateTime ExpirationDate { get; set; }

        [Required]
        [StringLength(140)]
        public string Comment { get; set; }

        public int? EmployeeNo { get; set; }

        public int? LabelNo { get; set; }

        public virtual Label Label { get; set; }
    }
}
