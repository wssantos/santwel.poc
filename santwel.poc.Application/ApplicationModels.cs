using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace santwel.poc
{
    public class GetProductsOutPut
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        
        public decimal UnitPrice { get; set; }

        public int QtyReserverdForSale { get; set; }
        
        public int QtyAvailable { get; set; }


    }

    public class PlaceOrderInput
    {
        public int ItemId { get; set; }

        public string Name { get; set; }

        public decimal UnitPrice { get; set; }

        public int QuantityOrdered { get; set; }

    }





}
