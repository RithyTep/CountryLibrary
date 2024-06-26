using System.Collections.Generic;

namespace CountryLibrary.Models
{
    public class CountryInfo
    {
        public string Name { get; set; }
        public string Alpha2Code { get; set; }
        public string Capital { get; set; }
        public List<int> CallingCodes { get; set; } = new List<int>();
        public string FlagUrl { get; set; }
        public string Timezones { get; set; } = string.Empty; // Initialize to avoid null
    }

    public class CountryResponse
    {
        public CountryInfo CountryInfo { get; set; }
    }
}
