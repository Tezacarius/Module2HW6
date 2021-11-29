using Module2HW6.Models.Enumerations;

namespace Module2HW6.Models.CarWithTrunk
{
    public class FordF150 : Pickup
    {
        public FordF150()
        {
            Name = "F-150";
            Manufacturer = "Ford";
            Cost = 50000;
            Currency = Currency.USD;
            FuelConsumption = 15;
        }
    }
}
