using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Burya_Inventory
{
    class Shipper
    {
        private List<IShippable> Shipments = new List<IShippable>();

        public void Add(IShippable Product)
        {
            Shipments.Add(Product);
        }
        public string Compute_Shipping()
        {
            decimal Shipment_Total = 0;

            for (int i = 0; i < Shipments.Count; i++)
            {
                Shipment_Total += Shipments[i].ShipCost;
            }
            return Shipment_Total.ToString();
        }

        public int[] Get_Products()
        {
            int[] manifest = { 0, 0, 0, 0 };

            for (int i = 0; i < Shipments.Count; ++i)
            {
                switch (Shipments[i].Product)
                {
                    case "Bicycle":
                        manifest[0] += 1;
                        break;

                    case "Lawn Mower":
                        manifest[1] += 1;
                        break;

                    case "Baseball Glove":
                        manifest[2] += 1;
                        break;

                    case "Crackers":
                        manifest[3] += 1;
                        break;
                }
            }

            return manifest;
        }
    }
}
