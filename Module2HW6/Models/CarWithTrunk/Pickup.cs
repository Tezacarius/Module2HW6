using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Models.Enumerations;

namespace Module2HW6.Models.CarWithTrunk
{
    public abstract class Pickup : CarWithTrunk
    {
        public Pickup()
        {
            TrunkSize = TrunkSize.Big;
        }
    }
}
