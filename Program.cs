using ObjectOrientedProgram.InventoryManagement;
using System;

namespace ObjectOrientedProgram
{
    class Program
    {
        const string InventoryJson = @"C:\Users\saura\source\repos\ObjectOrientedProgram\ObjectOrientedProgram\InventoryManagement\Inventory.json";
        static void Main(string[] args)
        {
            InventoryMain main = new InventoryMain();
            main.DisplayData(InventoryJson);
        }
    }
}
