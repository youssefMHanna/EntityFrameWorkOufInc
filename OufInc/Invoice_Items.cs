namespace OufInc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Invoice_Items:Invoice_transfer_Items
    {
        public int Number { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Valid_Date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Production_Date { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Code { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Invoice_ID { get; set; }

        public virtual Good Good { get; set; }

        public virtual Invoice Invoice { get; set; }
    }
}
