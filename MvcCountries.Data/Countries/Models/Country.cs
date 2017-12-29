using System;
using System.Xml.Serialization;

namespace MvcCountries.Core.Countries.Models
{
    public class Country
    {
        public enum ShippingBand
        {
            A = 1,
            B = 2,
            C = 3
        }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("value")]
        public string Value { get; set; }

        [XmlIgnore]
        public ShippingBand? Shipping { get; set; }

        [XmlAttribute("shipping")]
        public string ShippingAsString
        {
            get { return Shipping.ToString(); }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Shipping = null;
                }
                else
                {
                    Shipping = (ShippingBand)Enum.Parse(typeof(ShippingBand), value);
                }
            }
        }

    }
}