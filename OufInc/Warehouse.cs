namespace OufInc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Warehouse")]
    public partial class Warehouse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Warehouse()
        {
            Invoices = new HashSet<Invoice>();
            ToTransfers = new HashSet<Transfer>();
            FromTransfers = new HashSet<Transfer>();
        }

        [Required]
        [StringLength(300)]
        public string Warehouse_Address { get; set; }

        [Required]
        [StringLength(50)]
        public string Manager { get; set; }

        [Key]
        public int Warehouse_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Warehouse_Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transfer> ToTransfers { get; set; }//to

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transfer> FromTransfers { get; set; } //from
    }
}
