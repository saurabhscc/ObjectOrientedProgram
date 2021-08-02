using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgram.InventoryManagement
{
    public class InventoryModel
    {
        public List<Rice> RiceList { get; set; }
        public List<Wheat> WheatList { get; set; }
        public List<Pulses> PulsesList { get; set; }
    }
}
