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
            FuelConsumption = 24;
        }
    }
}
