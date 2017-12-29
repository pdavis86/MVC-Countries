namespace MvcCountries.Core.Factories
{
    public class RepoFactory
    {
        public static Countries.ICountryRepository CountryRepository
        {
            get { return new Countries.CountryRepository(); }
        }
    }
}
