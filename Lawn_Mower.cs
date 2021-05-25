using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Burya_Inventory
{
    class Lawn_Mower : IShippable
    {
        public Lawn_Mower()
        {
            this.ShipCost = 25.00M;
            this.Product = "Lawn Mower";
        }
        public decimal ShipCost { get; }
        public string Product { get; }

    }
}
