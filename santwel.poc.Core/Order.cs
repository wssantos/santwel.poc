using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace santwel.poc
{
    public class Order : Entity
    {

        private List<Item> _items;

        public Order()
        {


            
            this._items = new List<Item>();
        }

        public DateTime CreatedOn { get; set; }

        public IList<Item> Items { get => _items; protected set => this._items = (List<Item>)value; }


        public void AddItem(Item item)
        {

            this._items.Add(item);

        }


        public decimal GetTotalValue()
        {

            return this._items.Sum(i => i.UnitPrice);

        }
    }
}
