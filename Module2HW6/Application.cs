using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Services.Abstractions;
using Module2HW6.Helpers;

namespace Module2HW6
{
    public class Application
    {
        private readonly ICabCompanyService _cabCompanyService;
        public Application(ICabCompanyService cabCompanyService)
        {
            _cabCompanyService = cabCompanyService;
        }

        public void Run()
        {
            var totalCarsCost = _cabCompanyService.TotalCarsCost();
            _cabCompanyService.Sort();
            var filteredCars = _cabCompanyService.Get().Find(200000);
        }
    }
}
