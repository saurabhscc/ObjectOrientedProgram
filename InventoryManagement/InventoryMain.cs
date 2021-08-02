using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOrientedProgram.InventoryManagement
{
    public class InventoryMain
    {
        public void DisplayData(string filepath)
        {
            try
            {
                if (File.Exists(filepath))
                {
                    string jsonData = File.ReadAllText(filepath);
                    InventoryModel jsonObjectArray = JsonConvert.DeserializeObject<InventoryModel>(jsonData);

                    Console.WriteLine("Name\tWeight\tRate\tAmount");

                    List<Rice> rice = jsonObjectArray.riceList;
                    foreach (var item in rice)
                    {
                        Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}" + "\t" + "{3}", item.Name, item.Weight, item.PricePerkg, item.Weight * item.PricePerkg);
                    }
                    List<Wheat> wheat = jsonObjectArray.wheatList;
                    foreach (var item in wheat)
                    {
                        Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}" + "\t" + "{3}", item.Name, item.Weight, item.PricePerkg, item.Weight * item.PricePerkg);
                    }
                    List<Pulses> pulses = jsonObjectArray.pulsesList;
                    foreach (var item in pulses)
                    {
                        Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}" + "\t" + "{3}", item.Name, item.Weight, item.PricePerkg, item.Weight * item.PricePerkg);
                    }
                }
                else
                {
                    Console.WriteLine("\nSpecified file path does not exist");
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
