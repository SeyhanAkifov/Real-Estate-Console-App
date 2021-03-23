﻿using RealEstates.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstates.Services
{
    public interface  IDistrictService
    {
        IEnumerable<DistrictInfoDto> GetMostExpensiveDistricts(int count);
    }
}
