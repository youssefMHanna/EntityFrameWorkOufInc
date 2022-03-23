namespace OufInc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transfer")]
    public partial class Transfer:IInvoice_Transfer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transfer()
        {
            Transefer_Items = new HashSet<Transefer_Items>();
        }
        
        [Key]
        public int Transfer_ID { get; set; }

        public int FromWarehouse_ID { get; set; }

        public int ToWarehouse_ID { get; set; }

        public int Trader_ID { get; set; }

        public virtual Trader Trader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transefer_Items> Transefer_Items { get; set; }

        public virtual Warehouse ToWarehouse { get; set; }

        public virtual Warehouse FromWarehouse { get; set; }
    }
}
