using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgram.InventoryManagement
{
    public class InventoryModel
    {
        public List<Rice> riceList { get; set; }
        public List<Wheat> wheatList { get; set; }
        public List<Pulses> pulsesList { get; set; }
    }
}
