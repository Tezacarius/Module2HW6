using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Models;
using Module2HW6.Providers.Abstractions;
using Module2HW6.Services.Abstractions;

namespace Module2HW6.Services
{
    public class CabCompanyService : ICabCompanyService
    {
        private readonly ICarProvider _carProvider;
        private Car[] _cars;

        public CabCompanyService(ICarProvider carProvider)
        {
            _carProvider = carProvider;
            _cars = _carProvider.Get();
        }

        public bool Add(Car item)
        {
            if (_cars == null)
            {
                _cars = new Car[1];
                _cars[0] = item;
            }
            else
            {
                Array.Resize(ref _cars, _cars.Length + 1);
                _cars[_cars.Length - 1] = item;
            }

            return true;
        }

        public Car[] Get()
        {
            var plants = new Car[_cars.Length];

            for (var i = 0; i < _cars.Length; i++)
            {
                _cars[i] = _cars[i];
            }

            return _cars;
        }

        public void Clean()
        {
            _cars = new Car[0];
        }

        public int TotalCarsCost()
        {
            var cost = 0;

            for (var i = 0; i < _cars.Length; i++)
            {
                cost += _cars[i].Cost;
            }

            return cost;
        }

        public bool Sort()
        {
            if (_cars.Length <= 1)
            {
                return false;
            }

            Array.Sort(_cars, new CarComparer());

            return true;
        }
    }
}
