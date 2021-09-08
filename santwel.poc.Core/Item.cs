﻿using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace santwel.poc
{
    public class Item:Entity
    {
        public int OrderId { get; set; }

        public int ItemId { get; set; }

        public string Name { get; set; }

        public decimal UnitPrice { get; set; }

        public int QuantityOrdered { get; set; }

        public Order Order { get; set; }
    }
}
