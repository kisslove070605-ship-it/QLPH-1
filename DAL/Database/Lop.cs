namespace DAL.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Lop")]
    public partial class Lop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lop()
        {
            DangKyMuons = new HashSet<DangKyMuon>();
            LichHocs = new HashSet<LichHoc>();
            ThoiKhoaBieux = new HashSet<ThoiKhoaBieu>();
        }

        [Key]
        [StringLength(20)]
        public string MaLop { get; set; }

        [Required]
        [StringLength(100)]
        public string TenLop { get; set; }

        public int? SoLuongSV { get; set; }

        [StringLength(10)]
        public string MaKhoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DangKyMuon> DangKyMuons { get; set; }

        public virtual Khoa Khoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichHoc> LichHocs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThoiKhoaBieu> ThoiKhoaBieux { get; set; }
    }
}
