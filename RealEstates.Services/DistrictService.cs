using AutoMapper.QueryableExtensions;
using RealEstates.Data;
using RealEstates.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstates.Services
{
    public class DistrictService :BaseService,  IDistrictService
    {
        private readonly ApplicationDbContext dbContext;
        public DistrictService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IEnumerable<DistrictInfoDto> GetMostExpensiveDistricts(int count)
        {

            var properties = dbContext.Districts
                .ProjectTo<DistrictInfoDto>(this.Mapper.ConfigurationProvider)
                //.Select(x => new DistrictInfoDto
                //{
                //    Name = x.Name,
                //    Count = x.Properties.Count(),
                //    AveragePricePerSquareMeter = Math.Floor(x.Properties
                //                                .Where(x => x.Price.HasValue)
                //                                .Average(p => (p.Price / (decimal)p.Size)) ?? 0)
                .OrderByDescending(x => x.AveragePricePerSquareMeter).Take(count)
                .ToList();

            return properties;
        }
    }
}
