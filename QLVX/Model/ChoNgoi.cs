namespace QLVX.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChoNgoi")]
    public partial class ChoNgoi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChoNgoi()
        {
            VeXe = new HashSet<VeXe>();
        }

        [Key]
        [StringLength(50)]
        public string MaSoGhe { get; set; }

        [Required]
        [StringLength(50)]
        public string TenGhe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VeXe> VeXe { get; set; }
    }
}
