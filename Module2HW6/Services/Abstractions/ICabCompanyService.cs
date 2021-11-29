using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Models;

namespace Module2HW6.Services.Abstractions
{
    public interface ICabCompanyService
    {
        bool Add(Car item);
        Car[] Get();
        void Clean();
        int TotalCarsCost();
        bool Sort();
    }
}
