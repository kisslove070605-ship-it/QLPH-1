namespace DAL.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiangVien")]
    public partial class GiangVien
    {
        [Key]
        [StringLength(20)]
        public string MaGV { get; set; }

        [StringLength(10)]
        public string MaKhoa { get; set; }

        [Required]
        [StringLength(100)]
        public string TenGV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(255)]
        public string DiaChi { get; set; }

        [StringLength(15)]
        public string SDT { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public virtual Khoa Khoa { get; set; }
    }
}
