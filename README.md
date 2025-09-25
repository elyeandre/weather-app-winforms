# 🌤️ Weather App WinForms

[![Made With C#][made-with-csharp]][forthebadge-url]
[![Built With Love][built-with-love]][forthebadge-url]

[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-issues-url]

A modern **desktop weather application** built with C# Windows Forms that provides comprehensive weather information with a beautiful glassmorphic UI design. This application demonstrates modern software development practices including API integration, MVP architecture pattern, and custom UI controls with real-time weather data from AccuWeather API.

## 📋 Table of Contents
- [🎯 Project Overview](#-project-overview)
- [✨ Key Features](#-key-features)
- [🛠️ Tech Stack](#️-tech-stack)
- [🏗️ Architecture](#️-architecture)
- [📁 Project Structure](#-project-structure)
- [🚀 Quick Start](#-quick-start)
- [⚙️ Configuration](#️-configuration)
- [📱 Usage Guide](#-usage-guide)
- [🔒 Security Notes](#-security-notes)
- [🚀 Deployment](#-deployment)
- [🤝 Contributing](#-contributing)
- [📄 License](#-license)
- [📸 Screenshots](#-screenshots)

## 🎯 Project Overview

**Weather App WinForms** is a sophisticated Windows Forms desktop application that provides real-time weather information with an elegant glassmorphic design. Built using C# and integrated with AccuWeather API and OpenStreetMap, it demonstrates modern software development principles while delivering accurate weather forecasts and current conditions.

### 🎯 Target Users
- **🌍 General Users**: Anyone needing accurate weather information
- **🏃‍♂️ Outdoor Enthusiasts**: Planning activities based on weather conditions
- **📱 Developers**: Learning modern WinForms development patterns

### 🌟 Problem Statement
Deliver a visually appealing and user-friendly weather application that provides comprehensive weather data including current conditions, hourly forecasts, and 5-day predictions with intelligent location search and beautiful UI design.

## ✨ Key Features

### 🌡️ **Weather Information**
- **Current Conditions**: Real-time temperature, weather description, and conditions
- **Detailed Metrics**: Humidity, wind speed, visibility, dew point, and precipitation
- **Feels Like Temperature**: Apparent temperature based on weather conditions
- **Weather Icons**: Dynamic weather icons that change based on conditions and time

### 📊 **Forecast System**
- **Hourly Forecast**: 12-hour detailed weather predictions
- **Daily Forecast**: 5-day weather outlook with min/max temperatures
- **Precipitation Probability**: Rain/snow chances for informed planning
- **Weather Descriptions**: Detailed weather condition explanations

### 🔍 **Location Search**
- **Intelligent Search**: OpenStreetMap integration for accurate location search
- **Search Suggestions**: Auto-complete dropdown with multiple location options
- **Location Details**: Comprehensive address information (Barangay, City, Province)
- **Default Location**: Automatic loading of preset location on startup

### 🎨 **Modern UI Design**
- **Glassmorphic Interface**: Beautiful frosted glass effect panels
- **Custom Controls**: Handcrafted `GlassmorphicPanel` with transparency effects
- **Responsive Design**: Adaptive layout that works on different screen sizes
- **Smooth Animations**: Elegant hover effects and transitions

## 🛠️ Tech Stack

### **Core Technologies**
- **Language**: C# .NET Framework 4.7.2
- **GUI Framework**: Windows Forms with custom controls
- **APIs**: AccuWeather API, OpenStreetMap Nominatim API
- **JSON Processing**: Newtonsoft.Json 13.0.3
- **HTTP Client**: System.Net.Http for API calls

### **Development Tools**
- **IDE**: Visual Studio 2019/2022
- **Package Manager**: NuGet Package Manager
- **Version Control**: Git
- **API Testing**: Built-in HTTP client testing

### **Architecture Patterns**
- **MVP Pattern**: Model-View-Presenter architecture
- **Service Layer**: Abstracted weather service interfaces
- **Repository Pattern**: Data access abstraction
- **Observer Pattern**: UI updates through interface contracts

## 🏗️ Architecture

### **System Architecture**
```
┌─────────────────┐    ┌─────────────────┐    ┌─────────────────┐
│  Presentation   │    │   Business      │    │   External      │
│     Layer       │    │     Logic       │    │    Services     │
│                 │    │                 │    │                 │
│ ┌─────────────┐ │    │ ┌─────────────┐ │    │ ┌─────────────┐ │
│ │  MainForm   │ │    │ │ Weather     │ │    │ │ AccuWeather │ │
│ │ (IWeatherView)│◄├────┤►│ Presenter   │◄├────┤►│    API      │ │
│ └─────────────┘ │    │ └─────────────┘ │    │ └─────────────┘ │
│ ┌─────────────┐ │    │ ┌─────────────┐ │    │ ┌─────────────┐ │
│ │Glassmorphic │ │    │ │ Weather     │ │    │ │OpenStreetMap│ │
│ │   Panels    │ │    │ │  Service    │ │    │ │  Nominatim  │ │
│ └─────────────┘ │    │ └─────────────┘ │    │ └─────────────┘ │
└─────────────────┘    └─────────────────┘    └─────────────────┘
```

### **MVP Pattern Implementation**
```csharp
// Model: Weather data models
public class CurrentWeather { ... }
public class Location { ... }

// View: MainForm implements IWeatherView
public interface IWeatherView
{
    void DisplayCurrentWeather(CurrentWeather weather, Location location);
    void DisplayHourlyForecast(HourlyForecast[] forecasts);
    void DisplayDailyForecast(DailyForecast[] forecasts);
    void ShowLocations(IEnumerable<Location> locations);
}

// Presenter: WeatherPresenter coordinates between View and Service
public class WeatherPresenter
{
    private readonly IWeatherView _view;
    private readonly IWeatherService _service;
}
```

## 📁 Project Structure

```
weather-app-winforms/
├── 📄 weather-app-winforms.csproj     # Visual Studio project file
├── 📄 weather-app-winforms.sln       # Solution file
├── 📄 App.config                     # Application configuration
├── 📄 packages.config                # NuGet packages configuration
├── 📄 README.md                      # Project documentation
├── 📄 Program.cs                     # Application entry point
├── 📄 GlassmorphicPanel.cs           # Custom glassmorphic UI control
├── 📁 Forms/                         # Application forms
│   ├── 📄 MainForm.cs                # Main application window
│   ├── 📄 MainForm.Designer.cs       # Form designer code
│   └── 📄 MainForm.resx              # Form resources
├── 📁 Models/                        # Data models
│   └── 📄 WeatherModels.cs           # Weather data structures
├── 📁 Services/                      # Business logic services
│   ├── 📄 IWeatherView.cs            # View interface contract
│   ├── 📄 WeatherService.cs          # API service implementation
│   ├── 📄 WeatherPresenter.cs        # MVP presenter logic
│   └── 📄 WeatherIconMapper.cs       # Weather icon mapping
├── 📁 Properties/                    # Assembly and project properties
│   ├── 📄 AssemblyInfo.cs            # Assembly metadata
│   ├── 📄 Resources.Designer.cs      # Generated resources
│   ├── 📄 Resources.resx             # Application resources
│   ├── 📄 Settings.Designer.cs       # Generated settings
│   └── 📄 Settings.settings          # Application settings
└── 📁 Resources/                     # Weather icons and UI assets
    ├── 📄 Various weather icons      # 44+ weather condition icons
    ├── 📄 UI elements (search, etc.) # Interface icons
    └── 📄 bg2.jpg                    # Background image
```

## 🚀 Quick Start

### **Prerequisites**
- Windows 10/11
- .NET Framework 4.7.2 or higher
- Visual Studio 2019/2022 (Community Edition is fine)
- Internet connection for API calls
- AccuWeather API key (free tier available)

### **Installation**

1. **Clone the Repository**
   ```bash
   git clone https://github.com/elyeandre/weather-app-winforms.git
   cd weather-app-winforms
   ```

2. **API Key Setup**
   
   **Step 1: Get AccuWeather API Key**
   - Visit [AccuWeather Developer Portal](https://developer.accuweather.com/)
   - Create a free account
   - Create a new app to get your API key
   - Note down your API key
   
   **Step 2: Configure API Key**
   - Open `Services/WeatherService.cs`
   - Replace the API key in the AccuWeatherService class:
   ```csharp
   public class AccuWeatherService : IWeatherService
   {
       private const string ApiKey = "YOUR_API_KEY_HERE"; // Replace with your key
       private const string BaseUrl = "http://dataservice.accuweather.com";
   }
   ```

3. **Open and Build Project**
   - Open `weather-app-winforms.sln` in Visual Studio
   - Restore NuGet packages (should happen automatically)
   - Build the solution (Ctrl+Shift+B)

4. **Run the Application**
   - Press F5 or click "Start" in Visual Studio
   - The application will launch with default location (Tortugas, Balanga, PH)
   - Use the search box to find your desired location

## ⚙️ Configuration

### **API Configuration**
Update `WeatherService.cs` for your AccuWeather setup:

```csharp
public class AccuWeatherService : IWeatherService
{
    private readonly HttpClient _client = new HttpClient();
    private const string ApiKey = "YOUR_ACCUWEATHER_API_KEY"; // Required
    private const string BaseUrl = "http://dataservice.accuweather.com";
    
    // Optional: Customize default location
    public async Task SetDefaultLocation()
    {
        var locations = await _service.SearchLocationsAsync("Your City, Your Country");
        // ... rest of the method
    }
}
```

### **UI Customization**
Modify glassmorphic panel appearance in `GlassmorphicPanel.cs`:

```csharp
public class GlassmorphicPanel : Panel
{
    private int _cornerRadius = 20;        // Adjust corner roundness
    private Color _glassColor = Color.FromArgb(100, 255, 255, 255); // Glass tint
    private int _blurOpacity = 30;         // Blur intensity (0-100)
    private Color _borderColor = Color.FromArgb(150, 255, 255, 255); // Border color
}
```

## 📱 Usage Guide

### **Location Search**

1. **Finding Locations**
   - Click on the search textbox at the top
   - Type your desired location (city, address, landmark)
   - Press Enter or wait for suggestions to appear
   - Click on any suggestion to select that location

2. **Search Features**
   - **Smart Search**: Combines OpenStreetMap and AccuWeather data
   - **Multiple Results**: Shows various location matches
   - **Detailed Info**: Displays full address hierarchy
   - **Quick Selection**: One-click location selection

### **Weather Information**

1. **Current Weather Display**
   - **Main Panel**: Current temperature and weather description
   - **Feels Like**: Apparent temperature
   - **Date/Time**: Current observation time
   - **Location**: Selected location name

2. **Weather Details Panel**
   - **Humidity**: Current relative humidity percentage
   - **Wind Speed**: Wind velocity in km/h
   - **Visibility**: Atmospheric visibility distance
   - **Dew Point**: Dew point temperature
   - **Precipitation**: Rain/snow amounts (past 12 hours)

3. **Forecast Panels**
   - **Hourly**: Next 12 hours with temperature and conditions
   - **Daily**: 5-day forecast with high/low temps and rain probability

### **Application Controls**

- **Search Box**: Location search and selection
- **Refresh Button**: Updates weather data for current location
- **Weather Icons**: Visual representation of current and forecast conditions
- **Glassmorphic Panels**: Beautiful semi-transparent information containers

## 🔒 Security Notes

This application handles API keys and external data requests.

### Current Implementation
- API key stored in source code (development convenience)
- HTTPS API calls to AccuWeather and OpenStreetMap
- Basic error handling for API failures
- User-agent headers for API compliance

### Recommended Improvements for Production
- Store API keys in encrypted configuration files
- Implement API key rotation mechanisms
- Add request rate limiting and caching
- Implement comprehensive error logging
- Add offline mode with cached data
- Validate and sanitize all API responses

## 🚀 Deployment

### **Standalone Application Deployment**

1. **Build Release Version**
   ```bash
   # In Visual Studio
   Build → Configuration Manager → Set to "Release"
   Build → Build Solution
   ```

2. **Prepare Distribution Package**
   ```
   WeatherApp/
   ├── weather-app-winforms.exe
   ├── Newtonsoft.Json.dll
   ├── System.Text.Json.dll
   ├── Microsoft.Bcl.AsyncInterfaces.dll
   ├── Other required DLLs
   ├── App.config
   └── Resources/
       └── Weather icons and images
   ```

3. **Installation Requirements**
   - .NET Framework 4.7.2+ (usually pre-installed on Windows 10/11)
   - Internet connection for API calls
   - Minimum 4GB RAM, 50MB storage
   - Screen resolution: 1024x768 or higher

### **ClickOnce Deployment (Optional)**

1. **Setup ClickOnce in Visual Studio**
   ```bash
   Project → Properties → Publish
   Set Publishing Folder Location
   Configure Update Settings
   Click "Publish Now"
   ```

2. **Web Deployment**
   - Upload published files to web server
   - Users can install via web browser
   - Automatic updates support

## 🤝 Contributing

We welcome contributions to improve the Weather App!

### **Development Setup**

1. **Fork and Clone**
   ```bash
   git clone https://github.com/elyeandre/weather-app-winforms.git
   cd weather-app-winforms
   ```

2. **Development Environment**
   - Install Visual Studio 2019/2022
   - Get AccuWeather API key
   - Create feature branch: `git checkout -b feature/your-feature`

### **Contribution Guidelines**

- Follow C# coding conventions and naming standards
- Test all API integrations thoroughly
- Update documentation for new features
- Ensure UI responsiveness across different screen sizes
- Add appropriate error handling

### **Areas for Contribution**

- **🌐 Multiple Languages**: Internationalization support
- **📊 Weather Charts**: Graphical weather data visualization
- **🔔 Weather Alerts**: Severe weather notifications
- **📱 Responsive Design**: Better scaling for different screen sizes
- **🎨 Themes**: Dark mode and custom theme support
- **💾 Data Caching**: Offline mode with cached weather data
- **📍 GPS Integration**: Automatic location detection
- **⚙️ Settings Panel**: User preferences and configuration

## 📄 License

This project is licensed under the **MIT License** - see the [LICENSE](LICENSE) file for details.

## 📸 Screenshots

![Weather App Main Interface](https://github.com/user-attachments/assets/cef1c8c3-01be-4dad-9dfd-cdf1e00c717f)

### Main Weather Interface
*Beautiful glassmorphic design with comprehensive weather information*

### Location Search
*Intelligent location search with OpenStreetMap integration*

### Hourly Forecast
*12-hour detailed weather predictions with icons*

### Daily Forecast
*5-day weather outlook with temperature ranges*

---

**🌤️ Built with ❤️ for Weather Enthusiasts Everywhere**

*"Bringing beautiful weather information to your desktop"*

---

[made-with-csharp]: https://img.shields.io/badge/Made%20with-C%23-blue.svg?style=for-the-badge
[built-with-love]: https://img.shields.io/badge/Built%20with-❤️-red.svg?style=for-the-badge
[forthebadge-url]: http://forthebadge.com
[contributors-shield]: https://img.shields.io/github/contributors/elyeandre/weather-app-winforms.svg?style=for-the-badge
[contributors-url]: https://github.com/elyeandre/weather-app-winforms/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/elyeandre/weather-app-winforms.svg?style=for-the-badge
[forks-url]: https://github.com/elyeandre/weather-app-winforms/network/members
[stars-shield]: https://img.shields.io/github/stars/elyeandre/weather-app-winforms.svg?style=for-the-badge
[stars-url]: https://github.com/elyeandre/weather-app-winforms/stargazers
[issues-shield]: https://img.shields.io/github/issues/elyeandre/weather-app-winforms.svg?style=for-the-badge
[issues-issues-url]: https://github.com/elyeandre/weather-app-winforms/issues

*Last updated: September 25, 2025*