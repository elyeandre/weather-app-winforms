using System;
using System.Collections.Generic;
using System.Drawing;

namespace weather_app_winforms.Services
{
    public static class WeatherIconMapper
    {
        private static readonly Dictionary<int, Image> _iconMappings = new Dictionary<int, Image>
        {
            { 1, Properties.Resources.Sunny },                         // Sunny
            { 2, Properties.Resources.Mostly_Sunny },                  // Mostly Sunny
            { 3, Properties.Resources.Partly_Sunny },                  // Partly Sunny
            { 4, Properties.Resources.Intermittent_Clouds },           // Intermittent Clouds
            { 5, Properties.Resources.Hazy_Sunshine },                 // Hazy Sunshine
            { 6, Properties.Resources.Mostly_Cloudy },                 // Mostly Cloudy
            { 7, Properties.Resources.Cloudy },                        // Cloudy
            { 8, Properties.Resources.Dreary__Overcast_ },               // Dreary (Overcast)
            { 11, Properties.Resources.Fog },                          // Fog
            { 12, Properties.Resources.Showers },                      // Showers
            { 13, Properties.Resources.Mostly_Cloudy_with_Showers },   // Mostly Cloudy w/ Showers
            { 14, Properties.Resources.Partly_Sunny_with_Showers },    // Partly Sunny w/ Showers
            { 15, Properties.Resources.T_Storms },                     // T-Storms
            { 16, Properties.Resources.Mostly_Cloudy_with_T_Storms },  // Mostly Cloudy w/ T-Storms
            { 17, Properties.Resources.Partly_Sunny_with_T_Storms },   // Partly Sunny w/ T-Storms
            { 18, Properties.Resources.Rain },                         // Rain
            { 19, Properties.Resources.Flurries },                     // Flurries
            { 20, Properties.Resources.Mostly_Cloudy_with_Flurries },  // Mostly Cloudy w/ Flurries
            { 21, Properties.Resources.Partly_Sunny_with_Flurries },   // Partly Sunny w/ Flurries
            { 22, Properties.Resources.Snow },                         // Snow
            { 23, Properties.Resources.Mostly_Cloudy_with_Snow },      // Mostly Cloudy w/ Snow
            { 24, Properties.Resources.Ice },                          // Ice
            { 25, Properties.Resources.Sleet },                        // Sleet
            { 26, Properties.Resources.Freezing_Rain },                // Freezing Rain
            { 29, Properties.Resources.Rain_and_Snow },                // Rain and Snow
            { 30, Properties.Resources.Hot },                          // Hot
            { 31, Properties.Resources.Cold },                         // Cold
            { 32, Properties.Resources.Windy },                        // Windy
            { 33, Properties.Resources.Clear },                        // Clear (Night)
            { 34, Properties.Resources.Mostly_Clear       },           // Mostly Clear (Night)
            { 35, Properties.Resources.Partly_Cloudy },                // Partly Cloudy (Night)
            { 36, Properties.Resources.Intermittent_Clouds2 },          // Intermittent Clouds (Night)
            { 37, Properties.Resources.Hazy_Moonlight },               // Hazy Moonlight
            { 38, Properties.Resources.Mostly_Cloudy2  },               // Mostly Cloudy (Night)
            { 39, Properties.Resources.Partly_Cloudy_with_Showers },   // Partly Cloudy w/ Showers (Night)
            { 40, Properties.Resources.Mostly_Cloudy_with_Showers2 },   // Mostly Cloudy w/ Showers (Night)
            { 41, Properties.Resources.Partly_Cloudy_with_T_Storms2 }, // Partly Cloudy w/ T-Storms (Night)
            { 42, Properties.Resources.Mostly_Cloudy_with_T_Storms2 },   // Mostly Cloudy w/ T-Storms (Night)
            { 43, Properties.Resources.Mostly_Cloudy_with_Flurries2 }, // Mostly Cloudy w/ Flurries (Night)
            { 44, Properties.Resources.Mostly_Cloudy_with_Snow2 }     // Mostly Cloudy w/ Snow (Night)
        };

        public static Image GetIcon(int iconCode)
        {
            if (_iconMappings.TryGetValue(iconCode, out var image))
            {
                return image;
            }

            return null;
        }
    }
}

