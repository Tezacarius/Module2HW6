using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Models;

namespace Module2HW6.Helpers
{
    public static class CarExtension
    {
        public static Car[] Find(this Car[] items, int cost)
        {
            var cars = new Car[0];

            for (var i = 0; i < items.Length; i++)
            {
                if (items[i].Cost == cost)
                {
                    if (cars.Length == 0)
                    {
                        cars = new Car[1];
                        cars[0] = items[i];
                    }
                    else
                    {
                        Array.Resize(ref cars, cars.Length + 1);
                        cars[cars.Length - 1] = items[i];
                    }
                }
            }

            return cars;
        }
    }
}
