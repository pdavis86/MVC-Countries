using System.IO;
using System.Xml.Serialization;

namespace MvcCountries.Core.Countries
{
    public class CountryRepository : ICountryRepository
    {
        public Models.CountryFile GetCountries()
        {
            XmlSerializer xmlserializer = new XmlSerializer(typeof(Models.CountryFile));
            var xmlFilePath = System.Configuration.ConfigurationManager.AppSettings["countriesXmlFilePath"];
            StreamReader reader = new StreamReader(xmlFilePath);
            return (Models.CountryFile)xmlserializer.Deserialize(reader);
        }

    }
}
