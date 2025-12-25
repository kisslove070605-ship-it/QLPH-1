using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.Database
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=QuanLyPhongHoc")
        {
        }

        public virtual DbSet<DangKyMuon> DangKyMuons { get; set; }
        public virtual DbSet<GiangVien> GiangViens { get; set; }
        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<LichHoc> LichHocs { get; set; }
        public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<MonHoc> MonHocs { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<PhongHoc> PhongHocs { get; set; }
        public virtual DbSet<ThietBi> ThietBis { get; set; }
        public virtual DbSet<ThoiKhoaBieu> ThoiKhoaBieux { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DangKyMuon>()
                .Property(e => e.MaPhong)
                .IsUnicode(false);

            modelBuilder.Entity<DangKyMuon>()
                .Property(e => e.MaND)
                .IsUnicode(false);

            modelBuilder.Entity<DangKyMuon>()
                .Property(e => e.MaLop)
                .IsUnicode(false);

            modelBuilder.Entity<GiangVien>()
                .Property(e => e.MaGV)
                .IsUnicode(false);

            modelBuilder.Entity<GiangVien>()
                .Property(e => e.MaKhoa)
                .IsUnicode(false);

            modelBuilder.Entity<GiangVien>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<GiangVien>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Khoa>()
                .Property(e => e.MaKhoa)
                .IsUnicode(false);

            modelBuilder.Entity<LichHoc>()
                .Property(e => e.MaLop)
                .IsUnicode(false);

            modelBuilder.Entity<LichHoc>()
                .Property(e => e.MaMon)
                .IsUnicode(false);

            modelBuilder.Entity<LichHoc>()
                .Property(e => e.MaPhong)
                .IsUnicode(false);

            modelBuilder.Entity<LichHoc>()
                .Property(e => e.TietHoc)
                .IsUnicode(false);

            modelBuilder.Entity<Lop>()
                .Property(e => e.MaLop)
                .IsUnicode(false);

            modelBuilder.Entity<Lop>()
                .Property(e => e.MaKhoa)
                .IsUnicode(false);

            modelBuilder.Entity<MonHoc>()
                .Property(e => e.MaMon)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.MaND)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.TaiKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<PhongHoc>()
                .Property(e => e.MaPhong)
                .IsUnicode(false);

            modelBuilder.Entity<ThietBi>()
                .Property(e => e.MaThietBi)
                .IsUnicode(false);

            modelBuilder.Entity<ThietBi>()
                .Property(e => e.MaPhong)
                .IsUnicode(false);

            modelBuilder.Entity<ThoiKhoaBieu>()
                .Property(e => e.MaTKB)
                .IsUnicode(false);

            modelBuilder.Entity<ThoiKhoaBieu>()
                .Property(e => e.MaMon)
                .IsUnicode(false);

            modelBuilder.Entity<ThoiKhoaBieu>()
                .Property(e => e.MaLop)
                .IsUnicode(false);

            modelBuilder.Entity<ThoiKhoaBieu>()
                .Property(e => e.MaPhong)
                .IsUnicode(false);

            modelBuilder.Entity<ThoiKhoaBieu>()
                .Property(e => e.Tiet)
                .IsUnicode(false);
        }
    }
}
