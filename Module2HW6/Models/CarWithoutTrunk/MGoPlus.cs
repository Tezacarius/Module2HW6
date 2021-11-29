using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Models.Enumerations;

namespace Module2HW6.Models.CarWithoutTrunk
{
    public class MGoPlus : Micro
    {
        public MGoPlus()
        {
            Name = "Plus";
            Manufacturer = "M.Go";
            Cost = 13000;
            Currency = Currency.USD;
        }
    }
}
