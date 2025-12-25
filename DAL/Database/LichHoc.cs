namespace DAL.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichHoc")]
    public partial class LichHoc
    {
        [Key]
        public int MaLich { get; set; }

        [StringLength(20)]
        public string MaLop { get; set; }

        [StringLength(20)]
        public string MaMon { get; set; }

        [StringLength(10)]
        public string MaPhong { get; set; }

        [StringLength(10)]
        public string Thu { get; set; }

        [StringLength(10)]
        public string TietHoc { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBatDau { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; }

        public virtual Lop Lop { get; set; }

        public virtual MonHoc MonHoc { get; set; }

        public virtual PhongHoc PhongHoc { get; set; }
    }
}
