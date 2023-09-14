using Microsoft.AspNetCore.Mvc;
using Countries.API.Core;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Countries.API.Rest.Controllers
{
    [ApiController]
    [Route("[controller]/api/")]
    public class CountryController : Controller
    {
        private readonly ILogger<CountryController> _logger;
        private readonly ICountryProvider _countryProvider;
        public CountryController(ILogger<CountryController> logger, ICountryProvider countryProvider)
        {
            _logger = logger;
            _countryProvider = countryProvider;
        }


        [HttpGet]
        public async Task<IActionResult> GetCountry(string name)
        {
            _logger.LogInformation("GetCountry called with name: {name}", name);

            var country = await _countryProvider.GetCountry(name);
            return Ok(country);
        }
    }
}
