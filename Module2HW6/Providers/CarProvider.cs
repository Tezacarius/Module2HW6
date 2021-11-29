using Module2HW6.Models;
using Module2HW6.Models.CarWithoutTrunk;
using Module2HW6.Models.CarWithTrunk;
using Module2HW6.Providers.Abstractions;

namespace Module2HW6.Providers
{
    public class CarProvider : ICarProvider
    {
        public Car[] Get()
        {
            return new Car[]
                {
                    new AudiR8(),
                    new FerrariPortofino(),
                    new MC1Aixam(),
                    new MGoPlus(),
                    new FordF150(),
                    new NissanTitan(),
                    new VolkswagenPassatB7(),
                    new VolvoS40()
                };
        }
    }
}
