using RealEstates.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstates.Services
{
    public interface IPropertiesService
    {
        void Add(string district, int price, int floor, int maxFloor, int size, int yardSize, int year, string propertyType, string buildingType);

        decimal AveragePricePerSquareMeter();

        IEnumerable<PropertyInfoDto> Search(int minPrice, int maxPrice, int minSize, int maxSize);
        IEnumerable<PropertyInfoDto> SearchByDistrictName(string district);

        public IEnumerable<PropertyInfoFullData> GetFullData(int count);

        public decimal AveragePricePerSquareMeter(int districtId);

        public double AverageSize(int districtId);
    }
}
