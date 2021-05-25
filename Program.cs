using System;
// Mark Burya
// IT112 
// NOTES: Notes the instructor should read
// BEHAVIORS NOT IMPLEMENTED AND WHY: I forgot to implement a 10 item cap to my list however, I believe everything else
// should work.
namespace Burya_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Shipper Shipments = new Shipper();
            do
            {
                Console.WriteLine("Choose from the following options:\n" +
                "1. Add a Bicycle to the shipment\n" +
                "2. Add a Lawn Mower to the shipment\n" +
                "3. Add a Baseball Glove to the shipment\n" +
                "4. Add Crackers to the shipment\n" +
                "5. List shipment Items\n" +
                "6. Compute Shipping Charges\n");

                string User_Input = Console.ReadLine();

                void Product_Added(string product)
                {
                    Console.WriteLine("1 " + product + " has been added\n" +
                        "Press any key to return to the menu");
                    Console.ReadKey();
                    Console.Clear();
                }

                void Show_Products(string product, int count)
                {
                    if (count == 1)
                        Console.WriteLine(" " + product);
                    else
                        Console.WriteLine(" " + product + "s");
                }

                switch (User_Input)
                {
                    case "1":
                        Shipments.Add(new Bicycle());
                        Product_Added("Bicycle");
                        break;

                    case "2":
                        Shipments.Add(new Lawn_Mower());
                        Product_Added("Lawn Mower");
                        break;

                    case "3":
                        Shipments.Add(new Baseball_Glove());
                        Product_Added("Baseball Glove");
                        break;

                    case "4":
                        Shipments.Add(new Crackers());
                        Product_Added("Crackers");
                        break;

                    case "5":
                        int[] Manifest = Shipments.Get_Products();
                        Console.Write("Shipment manifest:\n" + Manifest[0]);
                        Show_Products("Bicycle", Manifest[0]);

                        Console.Write(Manifest[1]);
                        Show_Products("Lawn Mower", Manifest[1]);

                        Console.Write(Manifest[2]);
                        Show_Products("Baseball Glove", Manifest[2]);

                        Console.WriteLine(Manifest[3] + " Crackers\n" +
                            "Press any key to return to the menu");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case "6":
                        Console.Clear();
                        Console.WriteLine("Total shipping cost for this order is $" + Shipments.Compute_Shipping()) ;
                        return;

                    default:
                        Console.WriteLine("Error, please start from the beginning.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            } while (true);
        }
    }
}
