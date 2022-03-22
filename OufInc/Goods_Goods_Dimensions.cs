namespace OufInc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Goods_Goods_Dimensions
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Goods_Dimensions { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Code { get; set; }

        public virtual Good Good { get; set; }
    }
}
