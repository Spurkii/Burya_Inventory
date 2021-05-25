using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burya_Inventory
{
    class Baseball_Glove : IShippable
    {
        public Baseball_Glove()
        {
            this.ShipCost = 3.23M;
            this.Product = "Baseball Glove";
        }
        public decimal ShipCost { get; }
        public string Product { get; }
    }
}
