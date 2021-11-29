using Module2HW6.Models.Enumerations;

namespace Module2HW6.Models.CarWithTrunk
{
    public class VolkswagenPassatB7 : Sedan
    {
        public VolkswagenPassatB7()
        {
            Name = "Passat B7";
            Manufacturer = "Volkswagen";
            Cost = 11000;
            Currency = Currency.USD;
            FuelConsumption = 10;
        }
    }
}
