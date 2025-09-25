using System.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Windows.Forms;

public interface IWeatherService
{
    Task<Location[]> SearchLocationsAsync(string query);
    Task<CurrentWeather> GetCurrentWeatherAsync(string locationKey);
    Task<DailyForecast[]> GetDailyForecastAsync(string locationKey);
    Task<HourlyForecast[]> GetHourlyForecastAsync(string locationKey);

}

public class DailyForecastWrapper
{
    [JsonProperty("DailyForecasts")]
    public DailyForecast[] DailyForecasts { get; set; }
}

public class AccuWeatherService : IWeatherService
{
    private readonly HttpClient _client = new HttpClient();
    private const string ApiKey = "OSyZJOEKqN6MMTN4Tc5GVRkgduPGl3dL";
    private const string BaseUrl = "http://dataservice.accuweather.com";

    public async Task<Location[]> SearchLocationsAsync(string query)
    {
        try
        {
            // 1. Geocode with OpenStreetMap
            _client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:138.0) Gecko/20100101 Firefox/138.0");
            var nominatimResponse = await _client.GetStringAsync(
                $"https://nominatim.openstreetmap.org/search?q={Uri.EscapeDataString(query)}&format=json&addressdetails=1");

            var osmResults = JsonConvert.DeserializeObject<OSMResult[]>(nominatimResponse);
            if (!osmResults.Any()) return Array.Empty<Location>();

            // 2. Get AccuWeather locations for all found coordinates
            var locations = new List<Location>();
            foreach (var osm in osmResults.Take(10)) // Limit to top 3 results
            {
                var accuWeather = await GetAccuWeatherLocation(osm.lat, osm.lon);
                if (accuWeather != null)
                {
                    locations.Add(new Location
                    {
                        Key = accuWeather.Key,
                        LocalizedName = accuWeather.LocalizedName,
                        Country = accuWeather.Country,
                        AdministrativeArea = accuWeather.AdministrativeArea,
                        Address = osm.address,
                        DisplayName = osm.display_name,
                        Latitude = osm.lat,
                        Longitude = osm.lon,
                        Type = GetLocationType(osm)
                    });
                }
            }

            return locations.ToArray();
        }
        catch (Exception ex)
        {
            
            MessageBox.Show($"Search failed: {ex.Message}");
            return Array.Empty<Location>();
        }
    }

    private async Task<Location> GetAccuWeatherLocation(decimal lat, decimal lon)
    {
        var response = await _client.GetStringAsync(
            $"http://dataservice.accuweather.com/locations/v1/cities/geoposition/search?" +
            $"apikey={ApiKey}&q={lat},{lon}");

        return JsonConvert.DeserializeObject<Location>(response);
    }
    private string GetLocationType(OSMResult osm)
    {
        if (!string.IsNullOrEmpty(osm.address.village)) return "Barangay";
        if (!string.IsNullOrEmpty(osm.address.city)) return "City";
        if (!string.IsNullOrEmpty(osm.address.town)) return "Municipality";
        return "Unknown";
    }

    public async Task<HourlyForecast[]> GetHourlyForecastAsync(string locationKey)
    {
        var response = await _client.GetStringAsync(
            $"{BaseUrl}/forecasts/v1/hourly/12hour/{locationKey}?apikey={ApiKey}&metric=true");
        
        return JsonConvert.DeserializeObject<HourlyForecast[]>(response);

    }

    public async Task<DailyForecast[]> GetDailyForecastAsync(string locationKey)
    {
        var response = await _client.GetStringAsync(
            $"{BaseUrl}/forecasts/v1/daily/5day/{locationKey}?apikey={ApiKey}&metric=true");

        // Deserialize the wrapper object
        var wrapper = JsonConvert.DeserializeObject<DailyForecastWrapper>(response);
        return wrapper?.DailyForecasts ?? Array.Empty<DailyForecast>();
    }



    public async Task<CurrentWeather> GetCurrentWeatherAsync(string locationKey)
    {
        var response = await _client.GetStringAsync(
            $"{BaseUrl}/currentconditions/v1/{locationKey}?apikey={ApiKey}&details=true");

        var conditions = JsonConvert.DeserializeObject<CurrentWeather[]>(response);
        return conditions.FirstOrDefault();
    }

}