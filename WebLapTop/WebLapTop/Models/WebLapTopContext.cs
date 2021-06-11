using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebLapTop.Models
{
    public partial class WebLapTopContext : DbContext
    {
        public WebLapTopContext()
        {
        }

        public WebLapTopContext(DbContextOptions<WebLapTopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Anh> Anhs { get; set; }
        public virtual DbSet<Binhluan> Binhluans { get; set; }
        public virtual DbSet<Chinhanh> Chinhanhs { get; set; }
        public virtual DbSet<Chitiethoadon> Chitiethoadons { get; set; }
        public virtual DbSet<Hoadon> Hoadons { get; set; }
        public virtual DbSet<Khachhang> Khachhangs { get; set; }
        public virtual DbSet<Kho> Khos { get; set; }
        public virtual DbSet<KhoSanpham> KhoSanphams { get; set; }
        public virtual DbSet<Khuyenmai> Khuyenmais { get; set; }
        public virtual DbSet<Nhacungcap> Nhacungcaps { get; set; }
        public virtual DbSet<Nhanvien> Nhanviens { get; set; }
        public virtual DbSet<Phieubaohanh> Phieubaohanhs { get; set; }
        public virtual DbSet<Phieunhap> Phieunhaps { get; set; }
        public virtual DbSet<Sanpham> Sanphams { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=WebLapTop;Trusted_Connection=True;UID=DESKTOP-N27KJ97\\1232;PWD=");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Anh>(entity =>
            {
                entity.HasKey(e => e.MaAnh);

                entity.ToTable("Anh");

                entity.Property(e => e.MaAnh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaSp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaSP");

                entity.Property(e => e.TenAnh).HasMaxLength(50);

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.Anhs)
                    .HasForeignKey(d => d.MaSp)
                    .HasConstraintName("FK_Anh_SP");
            });

            modelBuilder.Entity<Binhluan>(entity =>
            {
                entity.HasKey(e => new { e.MaBl, e.MaSp, e.MaKh })
                    .HasName("PK_BL");

                entity.ToTable("BINHLUAN");

                entity.Property(e => e.MaBl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaBL");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaSP");

                entity.Property(e => e.MaKh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaKH");

                entity.Property(e => e.Ngay).HasColumnType("datetime");

                entity.Property(e => e.NoiDung).HasColumnType("text");

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.Binhluans)
                    .HasForeignKey(d => d.MaKh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BL_KH");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.Binhluans)
                    .HasForeignKey(d => d.MaSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BL_SP");
            });

            modelBuilder.Entity<Chinhanh>(entity =>
            {
                entity.HasKey(e => e.MaCn)
                    .HasName("PK_CN");

                entity.ToTable("CHINHANH");

                entity.Property(e => e.MaCn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaCN");

                entity.Property(e => e.DiaChi).HasMaxLength(150);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Makho)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sdt)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("SDT");

                entity.Property(e => e.TenCn)
                    .HasMaxLength(50)
                    .HasColumnName("TenCN");

                entity.HasOne(d => d.MakhoNavigation)
                    .WithMany(p => p.Chinhanhs)
                    .HasForeignKey(d => d.Makho)
                    .HasConstraintName("FK_CN_KHO");
            });

            modelBuilder.Entity<Chitiethoadon>(entity =>
            {
                entity.HasKey(e => new { e.MaHd, e.MaSp })
                    .HasName("PK_CTHD");

                entity.ToTable("CHITIETHOADON");

                entity.Property(e => e.MaHd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaHD");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaSP");

                entity.Property(e => e.TienKm).HasColumnName("TienKM");

                entity.HasOne(d => d.MaHdNavigation)
                    .WithMany(p => p.Chitiethoadons)
                    .HasForeignKey(d => d.MaHd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CTHD_HD");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.Chitiethoadons)
                    .HasForeignKey(d => d.MaSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CTHD_SP");
            });

            modelBuilder.Entity<Hoadon>(entity =>
            {
                entity.HasKey(e => e.MaHd)
                    .HasName("PK_HD");

                entity.ToTable("HOADON");

                entity.Property(e => e.MaHd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaHD");

                entity.Property(e => e.DiaChi).HasMaxLength(150);

                entity.Property(e => e.MaKh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaKH");

                entity.Property(e => e.MaNv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaNV");

                entity.Property(e => e.NgayGiao).HasColumnType("datetime");

                entity.Property(e => e.NgayLap).HasColumnType("datetime");

                entity.Property(e => e.Sdtnn)
                    .HasMaxLength(11)
                    .HasColumnName("SDTNN");

                entity.Property(e => e.TenNn)
                    .HasMaxLength(50)
                    .HasColumnName("TenNN");

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.Hoadons)
                    .HasForeignKey(d => d.MaKh)
                    .HasConstraintName("FK_HD_KH");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.Hoadons)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK_HD_NV_Tao");
            });

            modelBuilder.Entity<Khachhang>(entity =>
            {
                entity.HasKey(e => e.MaKh)
                    .HasName("PK_KH");

                entity.ToTable("KHACHHANG");

                entity.Property(e => e.MaKh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaKH");

                entity.Property(e => e.DiaChi).HasMaxLength(150);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoaiKh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LoaiKH");

                entity.Property(e => e.MaKm).HasColumnName("MaKM");

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sdt)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("SDT");

                entity.Property(e => e.TenKh)
                    .HasMaxLength(50)
                    .HasColumnName("TenKH");

                entity.HasOne(d => d.MaKmNavigation)
                    .WithMany(p => p.Khachhangs)
                    .HasForeignKey(d => d.MaKm)
                    .HasConstraintName("FK_KH_KM");
            });

            modelBuilder.Entity<Kho>(entity =>
            {
                entity.HasKey(e => e.MaKho);

                entity.ToTable("KHO");

                entity.Property(e => e.MaKho)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DiaChi).HasMaxLength(150);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sdt)
                    .HasMaxLength(11)
                    .HasColumnName("SDT");

                entity.Property(e => e.TenKho).HasMaxLength(50);
            });

            modelBuilder.Entity<KhoSanpham>(entity =>
            {
                entity.HasKey(e => new { e.MaKho, e.MaSp })
                    .HasName("PK_KHO_SP");

                entity.ToTable("KHO_SANPHAM");

                entity.Property(e => e.MaKho)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaSp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaSP");

                entity.HasOne(d => d.MaKhoNavigation)
                    .WithMany(p => p.KhoSanphams)
                    .HasForeignKey(d => d.MaKho)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KHOSP_KHO");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.KhoSanphams)
                    .HasForeignKey(d => d.MaSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KHOSP_SP");
            });

            modelBuilder.Entity<Khuyenmai>(entity =>
            {
                entity.HasKey(e => e.MaKm)
                    .HasName("PK_KM");

                entity.ToTable("KHUYENMAI");

                entity.Property(e => e.MaKm)
                    .ValueGeneratedNever()
                    .HasColumnName("MaKM");

                entity.Property(e => e.LoaiKm).HasColumnName("LoaiKM");

                entity.Property(e => e.MoTa).HasMaxLength(255);

                entity.Property(e => e.NgayBd)
                    .HasColumnType("datetime")
                    .HasColumnName("NgayBD");

                entity.Property(e => e.NgayKt)
                    .HasColumnType("datetime")
                    .HasColumnName("NgayKT");

                entity.Property(e => e.TenKm)
                    .HasMaxLength(50)
                    .HasColumnName("TenKM");
            });

            modelBuilder.Entity<Nhacungcap>(entity =>
            {
                entity.HasKey(e => e.MaNcc)
                    .HasName("PK_NCC");

                entity.ToTable("NHACUNGCAP");

                entity.Property(e => e.MaNcc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaNCC");

                entity.Property(e => e.DiaChi).HasMaxLength(150);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sdt)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("SDT");

                entity.Property(e => e.TenNcc)
                    .HasMaxLength(50)
                    .HasColumnName("TenNCC");
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.HasKey(e => e.MaNv)
                    .HasName("PK_NV");

                entity.ToTable("NHANVIEN");

                entity.Property(e => e.MaNv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaNV");

                entity.Property(e => e.ChucVu)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DiaChi).HasMaxLength(150);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaCn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaCN");

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quyen)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Sdt)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("SDT");

                entity.Property(e => e.TenNv)
                    .HasMaxLength(50)
                    .HasColumnName("TenNV");

                entity.HasOne(d => d.MaCnNavigation)
                    .WithMany(p => p.Nhanviens)
                    .HasForeignKey(d => d.MaCn)
                    .HasConstraintName("FK_NV_CN");
            });

            modelBuilder.Entity<Phieubaohanh>(entity =>
            {
                entity.HasKey(e => e.MaBh)
                    .HasName("PK_PBH");

                entity.ToTable("PHIEUBAOHANH");

                entity.Property(e => e.MaBh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaBH");

                entity.Property(e => e.MaNv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaNV");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaSP");

                entity.Property(e => e.NgayBd)
                    .HasColumnType("datetime")
                    .HasColumnName("NgayBD");

                entity.Property(e => e.NgayKt)
                    .HasColumnType("datetime")
                    .HasColumnName("NgayKT");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.Phieubaohanhs)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK_PBH_NV");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.Phieubaohanhs)
                    .HasForeignKey(d => d.MaSp)
                    .HasConstraintName("FK_PBH_SP");
            });

            modelBuilder.Entity<Phieunhap>(entity =>
            {
                entity.HasKey(e => e.MaPn)
                    .HasName("PK_PN");

                entity.ToTable("PHIEUNHAP");

                entity.Property(e => e.MaPn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaPN");

                entity.Property(e => e.MaNv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaNV");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaSP");

                entity.Property(e => e.NgayNhap).HasColumnType("datetime");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.Phieunhaps)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK_PN_NV");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.Phieunhaps)
                    .HasForeignKey(d => d.MaSp)
                    .HasConstraintName("FK_PN_SP");
            });

            modelBuilder.Entity<Sanpham>(entity =>
            {
                entity.HasKey(e => e.MaSp)
                    .HasName("PK_SP");

                entity.ToTable("SANPHAM");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaSP");

                entity.Property(e => e.ChiTietSp)
                    .HasColumnType("text")
                    .HasColumnName("ChiTietSP");

                entity.Property(e => e.LoaiSp)
                    .HasMaxLength(50)
                    .HasColumnName("LoaiSP");

                entity.Property(e => e.MaKm).HasColumnName("MaKM");

                entity.Property(e => e.MaNcc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaNCC");

                entity.Property(e => e.MaNv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaNV");

                entity.Property(e => e.NgaySua).HasColumnType("datetime");

                entity.Property(e => e.NgayTao).HasColumnType("datetime");

                entity.Property(e => e.TenSp)
                    .HasMaxLength(50)
                    .HasColumnName("TenSP");

                entity.Property(e => e.ThuongHieu)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaKmNavigation)
                    .WithMany(p => p.Sanphams)
                    .HasForeignKey(d => d.MaKm)
                    .HasConstraintName("FK_SP_KM");

                entity.HasOne(d => d.MaNccNavigation)
                    .WithMany(p => p.Sanphams)
                    .HasForeignKey(d => d.MaNcc)
                    .HasConstraintName("FK_SP_NCC");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.Sanphams)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK_SP_NV_Tao");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
