namespace DAL.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThietBi")]
    public partial class ThietBi
    {
        [Key]
        [StringLength(10)]
        public string MaThietBi { get; set; }

        [StringLength(100)]
        public string TenThietBi { get; set; }

        [StringLength(10)]
        public string MaPhong { get; set; }

        [StringLength(50)]
        public string TinhTrang { get; set; }

        public virtual PhongHoc PhongHoc { get; set; }
    }
}
