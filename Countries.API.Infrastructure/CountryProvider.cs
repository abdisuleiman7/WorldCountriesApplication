using Countries.API.Core;
using Newtonsoft.Json;
namespace Countries.API.Infrastructure
{
    public class CountryProvider: ICountryProvider
    {
         private readonly HttpClient _httpClient;
        public CountryProvider(HttpClient httpClient)
        {

            _httpClient = httpClient;

        }

        public async Task<Country[]> GetCountry(string name)
        {
            
            Country[] country;
            try
            {
                var response = await _httpClient.GetAsync($"https://restcountries.com/v3.1/name/{name}");
                var content = await response.Content.ReadAsStringAsync();
                country = JsonConvert.DeserializeObject<Country[]>(content);
            }
            catch (Exception)
            {

                throw;
            }
                return country;
        }
    }
}
