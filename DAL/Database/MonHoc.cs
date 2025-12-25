namespace DAL.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MonHoc")]
    public partial class MonHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MonHoc()
        {
            LichHocs = new HashSet<LichHoc>();
            ThoiKhoaBieux = new HashSet<ThoiKhoaBieu>();
        }

        [Key]
        [StringLength(20)]
        public string MaMon { get; set; }

        [Required]
        [StringLength(100)]
        public string TenMon { get; set; }

        public int? SoTinChi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichHoc> LichHocs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThoiKhoaBieu> ThoiKhoaBieux { get; set; }
    }
}
