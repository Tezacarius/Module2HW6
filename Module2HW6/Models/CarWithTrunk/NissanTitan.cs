﻿using Module2HW6.Models.Enumerations;

namespace Module2HW6.Models.CarWithTrunk
{
    public class NissanTitan : Pickup
    {
        public NissanTitan()
        {
            Name = "Titan";
            Manufacturer = "Nissan";
            Cost = 29000;
            Currency = Currency.USD;
            FuelConsumption = 13;
        }
    }
}
