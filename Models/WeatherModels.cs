using Newtonsoft.Json;
using System;

public class Location
{
    // From AccuWeather
    public string Key { get; set; }
    public string LocalizedName { get; set; }
    public Country Country { get; set; }
    public AdministrativeArea AdministrativeArea { get; set; }

    public Address Address { get; set; }

    // From OpenStreetMap
    public string DisplayName { get; set; }
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
    public string Type { get; set; } // barangay/city/etc
}


public class OSMResult
{
    public decimal lat { get; set; }
    public decimal lon { get; set; }
    public string display_name { get; set; }
    public Address address { get; set; }
}

public class Address
{
    public string village { get; set; }  // Barangay
    public string city { get; set; }
    public string town { get; set; }
    public string state { get; set; }    // Province
    public string region { get; set; }   // Region (e.g., Central Luzon)
    public string country { get; set; }
    public string country_code { get; set; }
}

public class AdministrativeArea
{
    public string LocalizedName { get; set; }
}

public class Country
{
    public string ID { get; set; }  
    public string LocalizedName { get; set; }
}
public class CurrentWeather
{
    [JsonProperty("LocalObservationDateTime")]
    public DateTimeOffset LocalObservationDateTime { get; set; }

    [JsonProperty("Temperature")]

    public Temperature Temperature { get; set; }

    [JsonProperty("RealFeelTemperature")]
    public Temperature RealFeelTemperature { get; set; }

    [JsonProperty("WeatherText")]
    public string WeatherText { get; set; }

    [JsonProperty("RelativeHumidity")]
    public int RelativeHumidity { get; set; }

    [JsonProperty("Wind")]
    public Wind Wind { get; set; }

    [JsonProperty("Visibility")]
    public Visibility Visibility { get; set; }

    [JsonProperty("HasPrecipitation")]
    public bool HasPrecipitation { get; set; }

    [JsonProperty("PrecipitationType")]
    public string PrecipitationType { get; set; }

    [JsonProperty("WeatherIcon")]
    public int WeatherIcon { get; set; }

    [JsonProperty("DewPoint")]
    public Temperature DewPoint { get; set; }

    [JsonProperty("PrecipitationSummary")]
    public PrecipitationSummary Precipitation { get; set; }

    public class PrecipitationSummary
    {
        [JsonProperty("Past12Hours")]
        public PrecipitationMeasurement Past12Hours { get; set; }

        [JsonProperty("Past24Hours")]
        public PrecipitationMeasurement Past24Hours { get; set; }
    }

    public class PrecipitationMeasurement
    {
        [JsonProperty("Metric")]
        public Metric Metric { get; set; }

        [JsonProperty("Imperial")]
        public Metric Imperial { get; set; }
    }

}

public class HourlyForecast
{
    [JsonProperty("DateTime")]
    public DateTime DateTime { get; set; }

    [JsonProperty("WeatherIcon")]
    public int WeatherIcon { get; set; }

    [JsonProperty("IconPhrase")]
    public string WeatherText { get; set; }  // Use IconPhrase for weather description

    [JsonProperty("Temperature")]
    public TemperatureValue Temperature { get; set; }

    [JsonProperty("PrecipitationProbability")]
    public int PrecipitationProbability { get; set; }
}

public class TemperatureValue
{
    [JsonProperty("Value")]
    public double Value { get; set; }

    [JsonProperty("Unit")]
    public string Unit { get; set; }
}

public class Temperature
{
    [JsonProperty("Metric")]
    public Metric Metric { get; set; }
}

public class DailyForecast
{
    [JsonProperty("Date")]
    public DateTime Date { get; set; }

    [JsonProperty("Temperature")]
    public DailyTemperature Temperature { get; set; }

    [JsonProperty("Day")]
    public DayNightInfo Day { get; set; }
}

public class DailyTemperature
{
    [JsonProperty("Minimum")]
    public TemperatureValue Minimum { get; set; }

    [JsonProperty("Maximum")]
    public TemperatureValue Maximum { get; set; }
}

public class DayNightInfo
{
    [JsonProperty("Icon")]
    public int Icon { get; set; }

    [JsonProperty("IconPhrase")]
    public string WeatherText { get; set; }

    [JsonProperty("PrecipitationProbability")]
    public int RainProbability { get; set; }
}

public class Metric
{
    [JsonProperty("Value")]
    public double Value { get; set; }

    [JsonProperty("Unit")]
    public string Unit { get; set; }

    [JsonProperty("UnitType")]
    public int UnitType { get; set; }
}

public class Wind
{
    [JsonProperty("Speed")]
    public WindSpeed Speed { get; set; }
}

public class WindSpeed
{
    [JsonProperty("Metric")]
    public Metric Metric { get; set; }  
}

public class Visibility
{
    [JsonProperty("Metric")]
    public Metric Metric { get; set; }
}