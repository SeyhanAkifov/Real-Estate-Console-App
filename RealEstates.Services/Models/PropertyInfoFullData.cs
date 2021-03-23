using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RealEstates.Services
{
    [XmlType("Property")]
    public class PropertyInfoFullData
    {
        [XmlAttribute("Id")]
        public int Id { get; set; }
        [XmlElement("District")]
        public string DistrictName { get; set; }
        [XmlElement("Size")]
        public int Size { get; set; }
        [XmlElement("Price")]
        public int Price { get; set; }
        [XmlElement("ProprtyType")]
        public string PropertyType { get; set; }
        [XmlElement("BuildingType")]
        public string BuildingType { get; set; }
        [XmlElement("Year")]
        public int Year { get; set; }
        [XmlElement("Tags")]
        public string Tags { get; set; }
    }
}
