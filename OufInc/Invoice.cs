namespace OufInc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Invoice")]
    public partial class Invoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Invoice()
        {
            Invoice_Items = new HashSet<Invoice_Items>();
        }

        [Column(TypeName = "date")]
        public DateTime Invoice_Date { get; set; }

        [Key]
        public int Invoice_ID { get; set; }

        public bool In_Out { get; set; }

        public int Warehouse_ID { get; set; }

        public int Trader_ID { get; set; }

        public virtual Trader Trader { get; set; }

        public virtual Warehouse Warehouse { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice_Items> Invoice_Items { get; set; }
    }
}
