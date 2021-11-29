using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Models.Enumerations;

namespace Module2HW6.Models.CarWithTrunk
{
    public class VolvoS40 : Sedan
    {
        public VolvoS40()
        {
            Name = "V40";
            Manufacturer = "Volvlo";
            Cost = 10000;
            Currency = Currency.USD;
            FuelConsumption = 9;
        }
    }
}
