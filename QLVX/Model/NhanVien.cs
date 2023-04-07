namespace QLVX.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            VeXe = new HashSet<VeXe>();
        }

        [Key]
        [StringLength(50)]
        public string MaNV { get; set; }

        [Required]
        [StringLength(200)]
        public string TenNV { get; set; }

        [StringLength(50)]
        public string Sdt { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        [StringLength(50)]
        public string PhanQuyen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VeXe> VeXe { get; set; }
    }
}
