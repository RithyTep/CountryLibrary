using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CountryLibrary.Models;
using Newtonsoft.Json;

namespace CountryLibrary.Services
{
    public class CountryService
    {
        private readonly HttpClient _httpClient;

        public CountryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<CountryInfo>> GetCountriesByAreaAsync(string areaInfoJson)
        {
            var content = new StringContent(areaInfoJson, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("https://restcountries.com/v2/all", content);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<CountryInfo>>(result); // Using Newtonsoft.Json
            }
            return null;
        }

    }
}
