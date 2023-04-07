namespace QLVX.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            VeXe = new HashSet<VeXe>();
        }

        [Key]
        [StringLength(50)]
        public string MaKH { get; set; }

        [Required]
        [StringLength(200)]
        public string TenKH { get; set; }

        [StringLength(50)]
        public string Sdt { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VeXe> VeXe { get; set; }
    }
}
