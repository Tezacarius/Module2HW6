﻿using Module2HW6.Models;

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
