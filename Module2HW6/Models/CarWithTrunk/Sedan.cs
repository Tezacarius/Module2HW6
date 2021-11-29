using Module2HW6.Models.Enumerations;

namespace Module2HW6.Models.CarWithTrunk
{
    public abstract class Sedan : CarWithTrunk
    {
        public Sedan()
        {
            TrunkSize = TrunkSize.Medium;
        }
    }
}
