using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Models.Enumerations;

namespace Module2HW6.Models.CarWithoutTrunk
{
    public class AudiR8 : Supercar
    {
        public AudiR8()
        {
            Name = "R8";
            Manufacturer = "Audi";
            Cost = 250000;
            Currency = Currency.USD;
        }
    }
}
