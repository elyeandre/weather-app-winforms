using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using weather_app_winforms.Services;


namespace weather_app_winforms
{
    public partial class MainForm: Form, IWeatherView
    {

        private readonly WeatherPresenter _presenter;
        private Panel pnlSearchSuggestions;

        public MainForm()
        {

            InitializeComponent();
            _presenter = new WeatherPresenter(this, new AccuWeatherService());
            InitializeSearchSuggestionsPanel();
            InitializeRefreshButton();
            
        }
        private async void txtSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                await _presenter.SearchLocations(txtSearchBox.Text);
            }
        }
        private async void txtSearchBox_TextChanged(object sender, EventArgs e)
        {

            pnlSearchSuggestions.Visible = false;
        }


        private void InitializeRefreshButton()
        {
            imgRefresh.MouseEnter += (s, e) => refreshPanelContainer.BlurOpacity = 100;
            imgRefresh.MouseLeave += (s, e) => refreshPanelContainer.BlurOpacity = 30;
            imgRefresh.Click += async (s, e) => await _presenter.RefreshWeather();
        }


        public void ShowLocations(IEnumerable<Location> locations)
        {
            Invoke((Action)(() =>
            {
                pnlSearchSuggestions.SuspendLayout();
                pnlSearchSuggestions.Controls.Clear();

                foreach (var loc in locations)
                {
                    var panel = new Panel
                    {
                        Width = pnlSearchSuggestions.Width - 25,
                        Height = 60,
                        Dock = DockStyle.Top,
                        Tag = loc,
                        BackColor = Color.White,
                        Cursor = Cursors.Hand,
                        Padding = new Padding(5)
                    };

                    // Change background color on hover
                    panel.MouseEnter += (s, e) => panel.BackColor = SystemColors.Control;
                    panel.MouseLeave += (s, e) => panel.BackColor = Color.White;

                    // Click event
                    panel.Click += async (s, e) =>
                    {
                        pnlSearchSuggestions.Visible = false;
                        await _presenter.LocationSelected(loc);
                        txtSearchBox.Text = loc.DisplayName;
                    };

                    // OSM Label
                    var lblOSM = new Label
                    {
                        Text = loc.DisplayName,
                        Font = new Font(Font, FontStyle.Bold),
                        AutoSize = false,
                        Dock = DockStyle.Top,
                        Height = 20,
                        BackColor = Color.Transparent
                    };

                    // AccuWeather Label
                    var lblAccuWeather = new Label
                    {
                        Text = $"{loc.LocalizedName}, {loc.AdministrativeArea?.LocalizedName}, {loc.Country.ID}",
                        ForeColor = Color.Gray,
                        AutoSize = false,
                        Dock = DockStyle.Top,
                        Height = 20,
                        BackColor = Color.Transparent
                    };

                    // Make labels also clickable and hoverable
                    foreach (Control ctrl in new Control[] { lblOSM, lblAccuWeather })
                    {
                        ctrl.Click += async (s, e) =>
                        {
                            pnlSearchSuggestions.Visible = false;
                            await _presenter.LocationSelected(loc);
                            txtSearchBox.Text = loc.DisplayName;
                        };

                        ctrl.MouseEnter += (s, e) => panel.BackColor = SystemColors.Control;
                        ctrl.MouseLeave += (s, e) => panel.BackColor = Color.White;
                    }

                    panel.Controls.Add(lblAccuWeather);
                    panel.Controls.Add(lblOSM);

                    pnlSearchSuggestions.Controls.Add(panel);
                }

                pnlSearchSuggestions.Visible = locations.Any();
                pnlSearchSuggestions.BringToFront();
                pnlSearchSuggestions.ResumeLayout(true);
            }));
        }




        private void InitializeSearchSuggestionsPanel()
        {
            pnlSearchSuggestions = new Panel
            {
                Visible = false,
                AutoScroll = true,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                MaximumSize = new Size(txtSearchBox.Width, 200),
                Location = new Point(txtSearchBox.Left, txtSearchBox.Bottom + 2),
                Parent = this  // Important for z-order
            };

            // Ensure panel stays on top
            pnlSearchSuggestions.BringToFront();

            // Handle click outside
            this.Click += (s, e) => pnlSearchSuggestions.Visible = false;
        }



        private Control CloneControl(Control original)
        {
            var clone = new GlassmorphicPanel();

         

            // Copy glassmorphic properties
            if (original is GlassmorphicPanel glassPanel)
            {
                clone.Size = original.Size;
                clone.Margin = original.Margin;
                clone.Padding = original.Padding;
                clone.Location = original.Location;
                clone.BackColor = original.BackColor;

                clone.BorderColor = glassPanel.BorderColor;
                clone.ForeColor = glassPanel.ForeColor;
                clone.GlassColor = glassPanel.GlassColor;
                clone.BlurOpacity = glassPanel.BlurOpacity;
                clone.CornerRadius = glassPanel.CornerRadius;
                // Add other properties
            }

            // Clone direct child controls (non-recursive)
            foreach (Control child in original.Controls)
            {
                Control childClone = Activator.CreateInstance(child.GetType()) as Control;
                childClone.Name = child.Name;
                childClone.Size = child.Size;
                childClone.Location = child.Location;
                childClone.Font = child.Font.Clone() as Font;

                if (child is Label lbl)
                {
                    (childClone as Label).Text = lbl.Text;
                    (childClone as Label).ForeColor = lbl.ForeColor;
                    (childClone as Label).Font = lbl.Font;
                    (childClone as Label).Location = lbl.Location;
                    (childClone as Label).AutoSize = lbl.AutoSize;
                    (childClone as Label).TextAlign = lbl.TextAlign;
                    (childClone as Label).Size = lbl.Size;

                }
                else if (child is PictureBox pb)
                {
                    (childClone as PictureBox).SizeMode = pb.SizeMode;
                    (childClone as PictureBox).Image = pb.Image;
                }

                clone.Controls.Add(childClone);
            }

            return clone;
        }




        public void DisplayCurrentWeather(CurrentWeather weather, Location location)
        {
            Invoke((Action)(() =>
            {
                lblPlace.Text = $"{location.DisplayName}";
                lblDate.Text = weather.LocalObservationDateTime.ToString("MMMM dd, yyyy");
                lblDegreeNow.Text = $"{weather.Temperature.Metric.Value}°{weather.Temperature.Metric.Unit}";
                lblWeatherNow.Text = weather.WeatherText;
                lblFeelsLike.Text = $"Feels like {weather.RealFeelTemperature.Metric.Value}°";

                imgWeatherNow.Image = WeatherIconMapper.GetIcon(weather.WeatherIcon);
                if (imgWeatherNow.Image != null)
                {
                    imgWeatherNow.Image = (Image)imgWeatherNow.Image.Clone();
                }
                lblHumidity.Text = $"{weather.RelativeHumidity}%";
                lblWindSpeed.Text = weather.Wind?.Speed?.Metric != null
                  ? $"{weather.Wind.Speed.Metric.Value} {weather.Wind.Speed.Metric.Unit}"
                  : "N/A";

                lblWindSpeed.Text = weather.Wind?.Speed?.Metric != null
                  ? $"{weather.Wind.Speed.Metric.Value} {weather.Wind.Speed.Metric.Unit}"
                  : "N/A";
                lblDewPoint.Text = weather.DewPoint?.Metric != null
                    ? $"{weather.DewPoint.Metric.Value}°{weather.DewPoint.Metric.Unit}"
                    : "N/A";
                lblRain.Text = weather.Precipitation?.Past12Hours?.Metric?.Value > 0
                && weather.PrecipitationType?.Equals("rain", StringComparison.OrdinalIgnoreCase) == true
                ? $"{weather.Precipitation.Past12Hours.Metric.Value} mm"
                : "0 mm";
                var tempBelowFreezing = weather.Temperature?.Metric?.Value < 0;
                lblSnowFall.Text = weather.Precipitation?.Past12Hours?.Metric?.Value > 0
                    && (weather.PrecipitationType?.Equals("snow", StringComparison.OrdinalIgnoreCase) == true || tempBelowFreezing)
                    ? $"{weather.Precipitation.Past12Hours.Metric.Value} mm"
                    : "0 mm";
                lblVisibility.Text = weather.Visibility?.Metric != null
            ? $"{weather.Visibility.Metric.Value} {weather.Visibility.Metric.Unit}"
            : "N/A";

            }));
        }

        public void DisplayHourlyForecast(HourlyForecast[] forecasts)
        {
            Invoke((Action)(() =>
            {
                hourlyWeatherParentPanel.SuspendLayout();
                hourlyWeatherParentPanel.Controls.Clear();

                foreach (var forecast in forecasts.Take(12))  // Show 12 hours (API returns 12)
                {
                    var panel = CloneControl(hourlyWeatherContainer);
                    panel.Tag = forecast;
                    panel.Visible = true;

                    var lblTime = panel.Controls.Find("hourlyWeatherTime", true).FirstOrDefault() as Label;
                    var imgWeather = panel.Controls.Find("imghourlyWeather", true).FirstOrDefault() as PictureBox;
                    var lblTemp = panel.Controls.Find("hourlyWeatherCelcius", true).FirstOrDefault() as Label;
                    var lblForecast = panel.Controls.Find("hourlyWeatherForecast", true).FirstOrDefault() as Label;

                    if (lblTime != null)
                        lblTime.Text = forecast.DateTime.ToString("htt");  // e.g., 3PM

                    if (imgWeather != null)
                        imgWeather.Image = WeatherIconMapper.GetIcon(forecast.WeatherIcon);

                    if (lblTemp != null)
                        lblTemp.Text = $"{forecast.Temperature.Value}°C";  // e.g., 30°C

                    if (lblForecast != null)
                    {
                        // Combine weather phrase and rain probability
                        lblForecast.Text = $"{forecast.WeatherText}";

                        // Add rain probability if > 0
                        if (forecast.PrecipitationProbability > 0)
                        {
                            lblForecast.Text += $" ({forecast.PrecipitationProbability}%)";
                        }
                    }

                    hourlyWeatherParentPanel.Controls.Add(panel);
                }
                hourlyWeatherParentPanel.ResumeLayout(true);
            }));
        }

        public void DisplayDailyForecast(DailyForecast[] forecasts)
        {
            Invoke((Action)(() =>
            {
                searchListPanel.SuspendLayout();
                searchListPanel.Controls.Clear();

                foreach (var forecast in forecasts.Take(10))
                {
                    var panel = CloneControl(tenDayWeatherForecastContainer);
                    panel.Tag = forecast;
                    panel.Visible = true;

                    var lblDay = panel.Controls.Find("lblDay", true).FirstOrDefault() as Label;
                    var imgWeather = panel.Controls.Find("imgWeather", true).FirstOrDefault() as PictureBox;
                    var lblTemp = panel.Controls.Find("lblCelciusWeather", true).FirstOrDefault() as Label;
                    var lblRain = panel.Controls.Find("lblRainStatus", true).FirstOrDefault() as Label;

                    if (lblDay != null)
                        lblDay.Text = forecast.Date.ToString("ddd");  // e.g., "Mon"

                    if (imgWeather != null)
                        imgWeather.Image = WeatherIconMapper.GetIcon(forecast.Day.Icon);

                    if (lblTemp != null)
                        lblTemp.Text = $"{forecast.Temperature.Maximum.Value}°/{forecast.Temperature.Minimum.Value}°";

                    if (lblRain != null)
                        lblRain.Text = forecast.Day.RainProbability > 0
                            ? $"{forecast.Day.RainProbability}%"
                            : "-";

                    searchListPanel.Controls.Add(panel);
                }
                searchListPanel.ResumeLayout(true);
            }));
        }
        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            await _presenter.SetDefaultLocation();
        }
    }
}
