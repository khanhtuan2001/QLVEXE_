namespace QLVX.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TuyenXe")]
    public partial class TuyenXe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TuyenXe()
        {
            ChuyenXe = new HashSet<ChuyenXe>();
        }

        [Key]
        [StringLength(50)]
        public string MaTuyen { get; set; }

        [Required]
        [StringLength(50)]
        public string DiaDiemDi { get; set; }

        [Required]
        [StringLength(50)]
        public string DiaDiemden { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChuyenXe> ChuyenXe { get; set; }

        public virtual DiaDiem DiaDiem { get; set; }

        public virtual DiaDiem DiaDiem1 { get; set; }
    }
}
