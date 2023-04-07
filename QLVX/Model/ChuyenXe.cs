namespace QLVX.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChuyenXe")]
    public partial class ChuyenXe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChuyenXe()
        {
            VeXe = new HashSet<VeXe>();
        }

        [Key]
        [StringLength(50)]
        public string MaChuyen { get; set; }

        [Required]
        [StringLength(50)]
        public string MaTuyen { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayDi { get; set; }

        public TimeSpan GioDi { get; set; }

        public int GiaVe { get; set; }

        public virtual TuyenXe TuyenXe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VeXe> VeXe { get; set; }
    }
}
