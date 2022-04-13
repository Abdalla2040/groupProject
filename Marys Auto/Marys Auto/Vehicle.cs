using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marys_Auto
{
    public class Vehicle
    {
        public int VehicleID { get; set; }
        public string VehicleMaker { get; set; }
        public string VehicleModel { get; set; }
        public string VehicleTrim { get; set; }
        public string VIN { get; set; }
        public List<Repair> Repairs { get; set; }
    }
}
