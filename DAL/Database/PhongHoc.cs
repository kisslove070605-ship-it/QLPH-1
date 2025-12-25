namespace DAL.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhongHoc")]
    public partial class PhongHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhongHoc()
        {
            DangKyMuons = new HashSet<DangKyMuon>();
            LichHocs = new HashSet<LichHoc>();
            ThietBis = new HashSet<ThietBi>();
            ThoiKhoaBieux = new HashSet<ThoiKhoaBieu>();
        }

        [Key]
        [StringLength(10)]
        public string MaPhong { get; set; }

        [Required]
        [StringLength(50)]
        public string TenPhong { get; set; }

        public int? MaLoai { get; set; }

        public int? SucChua { get; set; }

        [StringLength(100)]
        public string ViTri { get; set; }

        [StringLength(20)]
        public string TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DangKyMuon> DangKyMuons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichHoc> LichHocs { get; set; }

        public virtual LoaiPhong LoaiPhong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThietBi> ThietBis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThoiKhoaBieu> ThoiKhoaBieux { get; set; }
    }
}
