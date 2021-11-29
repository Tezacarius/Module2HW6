using Module2HW6.Models.Enumerations;

namespace Module2HW6.Models.CarWithTrunk
{
    public abstract class CarWithTrunk : Car
    {
        public CarWithTrunk()
        {
            HasTrunk = true;
        }

        public TrunkSize TrunkSize { get; set; }
    }
}
