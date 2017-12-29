using System.Xml.Serialization;

namespace MvcCountries.Core.Countries.Models
{
    [XmlRoot("rows")] 
    public class CountryFile
    {
        [XmlElement("row")]
        public Country[] Countries { get; set; }
    }
}
