using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCountries.Core.Countries
{
    public interface ICountryRepository
    {
        Models.CountryFile GetCountries();
    }
}
