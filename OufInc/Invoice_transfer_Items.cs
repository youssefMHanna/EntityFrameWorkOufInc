using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OufInc
{
    public interface Invoice_transfer_Items
    {
        int Number { get; set; }

        DateTime? Valid_Date { get; set; }

        DateTime? Production_Date { get; set; }

        //[Key]
        int Code { get; set; }

    }
}
