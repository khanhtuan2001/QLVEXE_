namespace QLVX.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DiaDiem")]
    public partial class DiaDiem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DiaDiem()
        {
            TuyenXe = new HashSet<TuyenXe>();
            TuyenXe1 = new HashSet<TuyenXe>();
        }

        [Key]
        [StringLength(50)]
        public string MaDiaDiem { get; set; }

        [Required]
        [StringLength(200)]
        public string TenDiaDiem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TuyenXe> TuyenXe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TuyenXe> TuyenXe1 { get; set; }
    }
}
