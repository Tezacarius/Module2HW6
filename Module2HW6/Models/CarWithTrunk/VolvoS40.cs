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
