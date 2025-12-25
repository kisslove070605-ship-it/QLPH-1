namespace DAL.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThoiKhoaBieu")]
    public partial class ThoiKhoaBieu
    {
        [Key]
        [StringLength(20)]
        public string MaTKB { get; set; }

        [StringLength(20)]
        public string MaMon { get; set; }

        [StringLength(20)]
        public string MaLop { get; set; }

        [StringLength(10)]
        public string MaPhong { get; set; }

        [StringLength(10)]
        public string Thu { get; set; }

        [StringLength(10)]
        public string Tiet { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngay { get; set; }

        public virtual Lop Lop { get; set; }

        public virtual MonHoc MonHoc { get; set; }

        public virtual PhongHoc PhongHoc { get; set; }
    }
}
