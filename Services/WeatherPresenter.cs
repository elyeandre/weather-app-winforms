
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

public class WeatherPresenter
{
    private readonly IWeatherView _view;
    private readonly IWeatherService _service;
    private Location[] _locations;
    private Location _currentLocation;

    public WeatherPresenter(IWeatherView view, IWeatherService service)
    {
        _view = view;
        _service = service;
    }

    public async Task SearchLocations(string query)
    {
        if (string.IsNullOrWhiteSpace(query)) return;

        _locations = await _service.SearchLocationsAsync(query);
        _view.ShowLocations(_locations);
    }

    public async Task LocationSelected(Location location)
    {
        _currentLocation = location;
        await UpdateWeatherData();
        await UpdateHourlyForecast();
        await UpdateDailyForecast();
    }

    public async Task RefreshWeather()
    {
        if (_currentLocation != null)

            await UpdateWeatherData();
            await UpdateHourlyForecast();
            await UpdateDailyForecast();

    }


    public async Task SetDefaultLocation()
    {
        try
        {
            // Search for the default location
            var locations = await _service.SearchLocationsAsync("Tortugas, Balanga, PH");

            if (locations != null && locations.Length > 0)
            {
                // Select the first matching location
                _currentLocation = locations[0];
                await UpdateWeatherData();
                await UpdateHourlyForecast();
                await UpdateDailyForecast();
            }
        }
        catch (Exception ex)
        {
            // Handle error (log or show message)
           
        }
    }

    private async Task UpdateWeatherData()
    {
        var weather = await _service.GetCurrentWeatherAsync(_currentLocation.Key);
        _view.DisplayCurrentWeather(weather, _currentLocation);
    }
    private async Task UpdateHourlyForecast()
    {
        var forecast = await _service.GetHourlyForecastAsync(_currentLocation.Key);
        _view.DisplayHourlyForecast(forecast);
    
    }
    private async Task UpdateDailyForecast()
    {
        var forecast = await _service.GetDailyForecastAsync(_currentLocation.Key);
        _view.DisplayDailyForecast(forecast);

    }
}