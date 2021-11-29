using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Models.Enumerations;

namespace Module2HW6.Models
{
    public abstract class Car
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Cost { get; set; }
        public Currency Currency { get; set; }
        public int FuelConsumption { get; set; }
        public bool HasTrunk { get; set; }
    }
}
