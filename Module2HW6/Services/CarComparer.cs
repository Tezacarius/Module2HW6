using System.Collections.Generic;
using Module2HW6.Models;

namespace Module2HW6.Services
{
    public class CarComparer : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            if (x.FuelConsumption > y.FuelConsumption)
            {
                return 1;
            }
            else if (x.FuelConsumption < y.FuelConsumption)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
