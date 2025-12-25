namespace DAL.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DangKyMuon")]
    public partial class DangKyMuon
    {
        [Key]
        public int MaDK { get; set; }

        [StringLength(10)]
        public string MaPhong { get; set; }

        [StringLength(20)]
        public string MaND { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayMuon { get; set; }

        public TimeSpan GioBatDau { get; set; }

        public TimeSpan GioKetThuc { get; set; }

        [StringLength(255)]
        public string MucDich { get; set; }

        public DateTime? NgayTao { get; set; }

        [StringLength(20)]
        public string TrangThaiDuyet { get; set; }

        [StringLength(20)]
        public string MaLop { get; set; }

        public virtual PhongHoc PhongHoc { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }

        public virtual Lop Lop { get; set; }
    }
}
