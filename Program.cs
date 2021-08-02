using ObjectOrientedProgram.InventoryManagement;
using System;

namespace ObjectOrientedProgram
{
    class Program
    {
        const string Inventoryjson = @"C:\Users\saura\source\repos\ObjectOrientedProgram\ObjectOrientedProgram\InventoryManagement\Inventory.json";
        static void Main(string[] args)
        {
            string choice = "start";
            InventoryMain inventorymain = new InventoryMain();
            Console.WriteLine("***************-----------------******************");
            Console.WriteLine("\nSelect the Option..\n1.Add\n2.Edit\n3.Delete\n4.Display\n5.Stop");
            while (choice != "5")
            {
                choice = Console.ReadLine().ToLower();
                switch (choice)
                {
                    case "1":
                        inventorymain.Additems(Inventoryjson);
                        break;

                    case "2":
                        inventorymain.Edit(Inventoryjson);
                        break;

                    case "3":
                        inventorymain.Deleteitems(Inventoryjson);
                        break;

                    case "4":
                        inventorymain.DisplayData(Inventoryjson);
                        break;
                }
            }
        }
    }
}









