using System.Collections.Generic;

public interface IWeatherView
{
    void ShowLocations(IEnumerable<Location> locations);
    void DisplayCurrentWeather(CurrentWeather weather, Location location);
    void DisplayHourlyForecast(HourlyForecast[] forecasts);

    void DisplayDailyForecast(DailyForecast[] forecasts);


}   