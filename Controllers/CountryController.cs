using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using CountryLibrary.Services;
using CountryLibrary.Models;

namespace CountryLibrary.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountryController : ControllerBase
    {
        private readonly ILogger<CountryController> _logger;
        private readonly CountryService _countryService;

        public CountryController(ILogger<CountryController> logger, CountryService countryService)
        {
            _logger = logger;
            _countryService = countryService;
        }

        // GET api/country/getcountrybyname
        [HttpPost("getcountrybyname")]
        public async Task<IActionResult> GetCountryByName([FromBody] string countryName)
        {
            // Implementation goes here
            return Ok(new CountryResponse());
        }

        // GET api/country/getcountrybyarea
        [HttpPost("getcountrybyarea")]
        public async Task<IActionResult> GetCountryByArea([FromBody] string areaInfoJson)
        {
            var countries = await _countryService.GetCountriesByAreaAsync(areaInfoJson);
            if (countries == null || countries.Count == 0)
            {
                return NotFound();
            }
            return Ok(countries);
        }
    }
}
