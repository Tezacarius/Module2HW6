using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Models.Enumerations;

namespace Module2HW6.Models.CarWithoutTrunk
{
    public class FerrariPortofino : Supercar
    {
        public FerrariPortofino()
        {
            Name = "Portofino";
            Manufacturer = "Ferrari";
            Cost = 200000;
            Currency = Currency.USD;
        }
    }
}
