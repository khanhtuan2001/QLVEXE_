using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLVX.Model
{
    public partial class VXDbcontext : DbContext
    {
        public VXDbcontext()
            : base("name=VXDbcontext3")
        {
        }

        public virtual DbSet<ChoNgoi> ChoNgois { get; set; }
        public virtual DbSet<ChuyenXe> ChuyenXes { get; set; }
        public virtual DbSet<DiaDiem> DiaDiems { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<TuyenXe> TuyenXes { get; set; }
        public virtual DbSet<VeXe> VeXes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChoNgoi>()
                .HasMany(e => e.VeXe)
                .WithRequired(e => e.ChoNgoi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChuyenXe>()
                .Property(e => e.GioDi)
                .HasPrecision(4);

            modelBuilder.Entity<ChuyenXe>()
                .HasMany(e => e.VeXe)
                .WithRequired(e => e.ChuyenXe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DiaDiem>()
                .HasMany(e => e.TuyenXe)
                .WithRequired(e => e.DiaDiem)
                .HasForeignKey(e => e.DiaDiemDi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DiaDiem>()
                .HasMany(e => e.TuyenXe1)
                .WithRequired(e => e.DiaDiem1)
                .HasForeignKey(e => e.DiaDiemden)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.VeXe)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.VeXe)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TuyenXe>()
                .HasMany(e => e.ChuyenXe)
                .WithRequired(e => e.TuyenXe)
                .WillCascadeOnDelete(false);
        }
    }
}
