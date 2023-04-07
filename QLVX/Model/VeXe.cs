namespace QLVX.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VeXe")]
    public partial class VeXe
    {
        [Key]
        [StringLength(50)]
        public string MaVe { get; set; }

        [Required]
        [StringLength(50)]
        public string MaChuyen { get; set; }

        [Required]
        [StringLength(50)]
        public string MaKH { get; set; }

        [Required]
        [StringLength(50)]
        public string MaNV { get; set; }

        [Required]
        [StringLength(50)]
        public string MaSoGhe { get; set; }

        [Column(TypeName = "date")]
        public DateTime ThoiGianDat { get; set; }

        public int? TongTien { get; set; }

        public virtual ChoNgoi ChoNgoi { get; set; }

        public virtual ChuyenXe ChuyenXe { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
