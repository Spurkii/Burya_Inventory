using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burya_Inventory
{
    class Bicycle : IShippable
    {
        public Bicycle()
        {
            this.ShipCost = 9.50M;
            this.Product = "Bicycle";
        }
        public decimal ShipCost { get; }
        public string Product { get; }
    }
}
