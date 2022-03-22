using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OufInc
{
    public class ItemEqualityComparator : IEqualityComparer<Invoice_transfer_Items>
    {
        public bool Equals(Invoice_transfer_Items x, Invoice_transfer_Items y)
        {
            return x.Code == y.Code;
        }

        public int GetHashCode(Invoice_transfer_Items obj)
        {
            throw new NotImplementedException();
        }
    }
    public class ItemEqualityDateComparator : IEqualityComparer<Invoice_transfer_Items>
    {
        public bool Equals(Invoice_transfer_Items x, Invoice_transfer_Items y)
        {
            return x.Code == y.Code && x.Production_Date == y.Production_Date;
        }

        public int GetHashCode(Invoice_transfer_Items obj)
        {
            throw new NotImplementedException();
        }
    }
    //public class DateSortComp : IComparable<Invoice_transfer_Items>
    //{
    //    public int CompareTo(Invoice_transfer_Items self, Invoice_transfer_Items other)
    //    {
    //        if (self.Code > other.Code)
    //            return -1;
    //        else if (self.Code > other.Code)
    //            return 1;
    //        else if (self.Production_Date > other.Production_Date)
    //            return -1;
    //        else if (self.Production_Date < other.Production_Date)
    //            return 1;
    //        else return 0;
    //    }

    //    public int CompareTo(Invoice_transfer_Items other)
    //    {
    //        return 1;
    //    }
    //}
}
