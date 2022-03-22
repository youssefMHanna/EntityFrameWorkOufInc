namespace OufInc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Good
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Good()
        {
            Goods_Goods_Dimensions = new HashSet<Goods_Goods_Dimensions>();
            Invoice_Items = new HashSet<Invoice_Items>();
            Transefer_Items = new HashSet<Transefer_Items>();
        }

        [Key]
        public int Code { get; set; }

        [Required]
        [StringLength(50)]
        public string Goods_Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Goods_Goods_Dimensions> Goods_Goods_Dimensions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice_Items> Invoice_Items { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transefer_Items> Transefer_Items { get; set; }
    }
}
