using CountryLibrary.Services;

public class Startup
{
    void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<CountryService, CountryService>();
    }
}
