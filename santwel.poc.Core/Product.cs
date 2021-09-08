using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace santwel.poc
{
    public class Product:Entity
    {

        public Product()
        {

        }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal UnitPrice { get; set; }

        public int QtyReserverdForSale { get; set; }

        public int QtyAvailable { get; set; }

    }
}
