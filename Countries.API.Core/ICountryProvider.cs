using Countries.API.Core;

namespace Countries.API.Core
{
    public interface ICountryProvider
    {
        public Task<Country[]> GetCountry(string name);
    }
}