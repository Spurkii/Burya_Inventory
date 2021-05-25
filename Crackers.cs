using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burya_Inventory
{
    class Crackers : IShippable
    {
        public Crackers()
        {
            this.ShipCost = 0.57M;
            this.Product = "Crackers0";
        }
        public decimal ShipCost { get; }
        public string Product { get; }
    }
}
