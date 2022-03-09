namespace PTLCBaiThucHanh226.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Demo")]
    public partial class Demo
    {
        [Key]
        [StringLength(10)]
        public string StudentID { get; set; }

        [StringLength(10)]
        public string StudentName { get; set; }
    }
}
