namespace weather_app_winforms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imgSearch = new System.Windows.Forms.PictureBox();
            this.imgWeatherNow = new System.Windows.Forms.PictureBox();
            this.lblWeatherNow = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPlace = new System.Windows.Forms.Label();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblFeelsLike = new System.Windows.Forms.Label();
            this.lblDegreeNow = new System.Windows.Forms.Label();
            this.gpSearchResult = new weather_app_winforms.GlassmorphicPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.searchListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tenDayWeatherForecastContainer = new weather_app_winforms.GlassmorphicPanel();
            this.imgWeather = new System.Windows.Forms.PictureBox();
            this.lblCelciusWeather = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblRainStatus = new System.Windows.Forms.Label();
            this.gpWeatherNow = new weather_app_winforms.GlassmorphicPanel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRain = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblDewPoint = new System.Windows.Forms.Label();
            this.lblVisibility = new System.Windows.Forms.Label();
            this.lblSnowFall = new System.Windows.Forms.Label();
            this.lblWindSpeed = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpDayWeather = new weather_app_winforms.GlassmorphicPanel();
            this.hourlyWeatherParentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.hourlyWeatherContainer = new weather_app_winforms.GlassmorphicPanel();
            this.hourlyWeatherForecast = new System.Windows.Forms.Label();
            this.imgHourlyWeather = new System.Windows.Forms.PictureBox();
            this.hourlyWeatherCelcius = new System.Windows.Forms.Label();
            this.hourlyWeatherTime = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gpSideBar = new weather_app_winforms.GlassmorphicPanel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.refreshPanelContainer = new weather_app_winforms.GlassmorphicPanel();
            this.imgRefresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgWeatherNow)).BeginInit();
            this.gpSearchResult.SuspendLayout();
            this.searchListPanel.SuspendLayout();
            this.tenDayWeatherForecastContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgWeather)).BeginInit();
            this.gpWeatherNow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpDayWeather.SuspendLayout();
            this.hourlyWeatherParentPanel.SuspendLayout();
            this.hourlyWeatherContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHourlyWeather)).BeginInit();
            this.gpSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.refreshPanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // imgSearch
            // 
            this.imgSearch.BackColor = System.Drawing.Color.Transparent;
            this.imgSearch.BackgroundImage = global::weather_app_winforms.Properties.Resources.search;
            this.imgSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgSearch.Location = new System.Drawing.Point(1082, 40);
            this.imgSearch.Name = "imgSearch";
            this.imgSearch.Size = new System.Drawing.Size(36, 39);
            this.imgSearch.TabIndex = 7;
            this.imgSearch.TabStop = false;
            // 
            // imgWeatherNow
            // 
            this.imgWeatherNow.BackColor = System.Drawing.Color.Transparent;
            this.imgWeatherNow.BackgroundImage = global::weather_app_winforms.Properties.Resources.Mostly_Cloudy_with_Snow2;
            this.imgWeatherNow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgWeatherNow.Location = new System.Drawing.Point(604, 119);
            this.imgWeatherNow.Name = "imgWeatherNow";
            this.imgWeatherNow.Size = new System.Drawing.Size(179, 104);
            this.imgWeatherNow.TabIndex = 1;
            this.imgWeatherNow.TabStop = false;
            // 
            // lblWeatherNow
            // 
            this.lblWeatherNow.BackColor = System.Drawing.Color.Transparent;
            this.lblWeatherNow.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeatherNow.ForeColor = System.Drawing.Color.Black;
            this.lblWeatherNow.Location = new System.Drawing.Point(643, 226);
            this.lblWeatherNow.Name = "lblWeatherNow";
            this.lblWeatherNow.Size = new System.Drawing.Size(164, 31);
            this.lblWeatherNow.TabIndex = 5;
            this.lblWeatherNow.Text = "No Data";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(114, 132);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(108, 20);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "May 24, 2025";
            // 
            // lblPlace
            // 
            this.lblPlace.BackColor = System.Drawing.Color.Transparent;
            this.lblPlace.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlace.ForeColor = System.Drawing.Color.Black;
            this.lblPlace.Location = new System.Drawing.Point(111, 79);
            this.lblPlace.Margin = new System.Windows.Forms.Padding(3, 0, 100, 0);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(672, 37);
            this.lblPlace.TabIndex = 2;
            this.lblPlace.Text = "Tortugas, Balanga City";
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.BackColor = System.Drawing.Color.White;
            this.txtSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBox.Location = new System.Drawing.Point(827, 47);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(246, 21);
            this.txtSearchBox.TabIndex = 8;
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            this.txtSearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchBox_KeyDown);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Location = new System.Drawing.Point(813, 40);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(263, 39);
            this.pnlSearch.TabIndex = 9;
            // 
            // lblFeelsLike
            // 
            this.lblFeelsLike.AutoSize = true;
            this.lblFeelsLike.BackColor = System.Drawing.Color.Transparent;
            this.lblFeelsLike.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeelsLike.ForeColor = System.Drawing.Color.Black;
            this.lblFeelsLike.Location = new System.Drawing.Point(333, 205);
            this.lblFeelsLike.Name = "lblFeelsLike";
            this.lblFeelsLike.Size = new System.Drawing.Size(94, 20);
            this.lblFeelsLike.TabIndex = 10;
            this.lblFeelsLike.Text = "Feels like 0";
            // 
            // lblDegreeNow
            // 
            this.lblDegreeNow.AutoSize = true;
            this.lblDegreeNow.BackColor = System.Drawing.Color.Transparent;
            this.lblDegreeNow.Font = new System.Drawing.Font("Segoe UI Semilight", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDegreeNow.ForeColor = System.Drawing.Color.Black;
            this.lblDegreeNow.Location = new System.Drawing.Point(101, 176);
            this.lblDegreeNow.Name = "lblDegreeNow";
            this.lblDegreeNow.Size = new System.Drawing.Size(127, 81);
            this.lblDegreeNow.TabIndex = 4;
            this.lblDegreeNow.Text = "0°C";
            this.lblDegreeNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpSearchResult
            // 
            this.gpSearchResult.BackColor = System.Drawing.Color.Transparent;
            this.gpSearchResult.BorderColor = System.Drawing.Color.Transparent;
            this.gpSearchResult.Controls.Add(this.label8);
            this.gpSearchResult.Controls.Add(this.searchListPanel);
            this.gpSearchResult.CornerRadius = 30;
            this.gpSearchResult.ForeColor = System.Drawing.Color.White;
            this.gpSearchResult.GlassColor = System.Drawing.Color.Transparent;
            this.gpSearchResult.Location = new System.Drawing.Point(813, 85);
            this.gpSearchResult.Name = "gpSearchResult";
            this.gpSearchResult.Size = new System.Drawing.Size(305, 605);
            this.gpSearchResult.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(24, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "5-Day Weather Forecast";
            // 
            // searchListPanel
            // 
            this.searchListPanel.AutoScroll = true;
            this.searchListPanel.AutoSize = true;
            this.searchListPanel.BackColor = System.Drawing.Color.Transparent;
            this.searchListPanel.Controls.Add(this.tenDayWeatherForecastContainer);
            this.searchListPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.searchListPanel.Location = new System.Drawing.Point(14, 34);
            this.searchListPanel.Name = "searchListPanel";
            this.searchListPanel.Padding = new System.Windows.Forms.Padding(3, 10, 5, 5);
            this.searchListPanel.Size = new System.Drawing.Size(279, 547);
            this.searchListPanel.TabIndex = 0;
            this.searchListPanel.WrapContents = false;
            // 
            // tenDayWeatherForecastContainer
            // 
            this.tenDayWeatherForecastContainer.BackColor = System.Drawing.Color.Transparent;
            this.tenDayWeatherForecastContainer.BorderColor = System.Drawing.Color.Transparent;
            this.tenDayWeatherForecastContainer.Controls.Add(this.imgWeather);
            this.tenDayWeatherForecastContainer.Controls.Add(this.lblCelciusWeather);
            this.tenDayWeatherForecastContainer.Controls.Add(this.lblDay);
            this.tenDayWeatherForecastContainer.Controls.Add(this.lblRainStatus);
            this.tenDayWeatherForecastContainer.CornerRadius = 10;
            this.tenDayWeatherForecastContainer.ForeColor = System.Drawing.Color.White;
            this.tenDayWeatherForecastContainer.GlassColor = System.Drawing.Color.Transparent;
            this.tenDayWeatherForecastContainer.Location = new System.Drawing.Point(6, 15);
            this.tenDayWeatherForecastContainer.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tenDayWeatherForecastContainer.Name = "tenDayWeatherForecastContainer";
            this.tenDayWeatherForecastContainer.Size = new System.Drawing.Size(265, 91);
            this.tenDayWeatherForecastContainer.TabIndex = 38;
            // 
            // imgWeather
            // 
            this.imgWeather.BackColor = System.Drawing.Color.Transparent;
            this.imgWeather.BackgroundImage = global::weather_app_winforms.Properties.Resources.night;
            this.imgWeather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgWeather.Location = new System.Drawing.Point(83, 11);
            this.imgWeather.Name = "imgWeather";
            this.imgWeather.Size = new System.Drawing.Size(74, 67);
            this.imgWeather.TabIndex = 21;
            this.imgWeather.TabStop = false;
            // 
            // lblCelciusWeather
            // 
            this.lblCelciusWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelciusWeather.ForeColor = System.Drawing.Color.Black;
            this.lblCelciusWeather.Location = new System.Drawing.Point(169, 53);
            this.lblCelciusWeather.Name = "lblCelciusWeather";
            this.lblCelciusWeather.Size = new System.Drawing.Size(93, 18);
            this.lblCelciusWeather.TabIndex = 25;
            this.lblCelciusWeather.Text = "90°C ";
            // 
            // lblDay
            // 
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.Black;
            this.lblDay.Location = new System.Drawing.Point(2, 33);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(83, 22);
            this.lblDay.TabIndex = 24;
            this.lblDay.Text = "Sun";
            this.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRainStatus
            // 
            this.lblRainStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRainStatus.ForeColor = System.Drawing.Color.Black;
            this.lblRainStatus.Location = new System.Drawing.Point(169, 14);
            this.lblRainStatus.Name = "lblRainStatus";
            this.lblRainStatus.Size = new System.Drawing.Size(93, 18);
            this.lblRainStatus.TabIndex = 21;
            this.lblRainStatus.Text = "Rain - 30";
            // 
            // gpWeatherNow
            // 
            this.gpWeatherNow.BackColor = System.Drawing.Color.Transparent;
            this.gpWeatherNow.BorderColor = System.Drawing.Color.Transparent;
            this.gpWeatherNow.Controls.Add(this.pictureBox7);
            this.gpWeatherNow.Controls.Add(this.pictureBox6);
            this.gpWeatherNow.Controls.Add(this.pictureBox5);
            this.gpWeatherNow.Controls.Add(this.pictureBox4);
            this.gpWeatherNow.Controls.Add(this.pictureBox3);
            this.gpWeatherNow.Controls.Add(this.pictureBox1);
            this.gpWeatherNow.Controls.Add(this.lblRain);
            this.gpWeatherNow.Controls.Add(this.lblHumidity);
            this.gpWeatherNow.Controls.Add(this.lblDewPoint);
            this.gpWeatherNow.Controls.Add(this.lblVisibility);
            this.gpWeatherNow.Controls.Add(this.lblSnowFall);
            this.gpWeatherNow.Controls.Add(this.lblWindSpeed);
            this.gpWeatherNow.Controls.Add(this.label6);
            this.gpWeatherNow.Controls.Add(this.label5);
            this.gpWeatherNow.Controls.Add(this.label4);
            this.gpWeatherNow.Controls.Add(this.label3);
            this.gpWeatherNow.Controls.Add(this.label2);
            this.gpWeatherNow.Controls.Add(this.label1);
            this.gpWeatherNow.CornerRadius = 30;
            this.gpWeatherNow.ForeColor = System.Drawing.Color.White;
            this.gpWeatherNow.GlassColor = System.Drawing.Color.Transparent;
            this.gpWeatherNow.Location = new System.Drawing.Point(98, 502);
            this.gpWeatherNow.Name = "gpWeatherNow";
            this.gpWeatherNow.Size = new System.Drawing.Size(709, 188);
            this.gpWeatherNow.TabIndex = 2;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::weather_app_winforms.Properties.Resources.icons8_visibility_48;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.Location = new System.Drawing.Point(478, 110);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(33, 27);
            this.pictureBox7.TabIndex = 23;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::weather_app_winforms.Properties.Resources.icons8_rain_48;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(478, 26);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(33, 27);
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::weather_app_winforms.Properties.Resources.icons8_winter_48;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(274, 110);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(33, 27);
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::weather_app_winforms.Properties.Resources.icons8_dew_point_48__1_;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(274, 26);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 27);
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::weather_app_winforms.Properties.Resources.icons8_wind_48;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(78, 110);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 27);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::weather_app_winforms.Properties.Resources.icons8_humidity_48;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(78, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 27);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lblRain
            // 
            this.lblRain.AutoSize = true;
            this.lblRain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRain.ForeColor = System.Drawing.Color.Black;
            this.lblRain.Location = new System.Drawing.Point(517, 61);
            this.lblRain.Name = "lblRain";
            this.lblRain.Size = new System.Drawing.Size(57, 22);
            this.lblRain.TabIndex = 17;
            this.lblRain.Text = "0 mm";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidity.ForeColor = System.Drawing.Color.Black;
            this.lblHumidity.Location = new System.Drawing.Point(117, 61);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(38, 22);
            this.lblHumidity.TabIndex = 16;
            this.lblHumidity.Text = "0%";
            // 
            // lblDewPoint
            // 
            this.lblDewPoint.AutoSize = true;
            this.lblDewPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDewPoint.ForeColor = System.Drawing.Color.Black;
            this.lblDewPoint.Location = new System.Drawing.Point(313, 61);
            this.lblDewPoint.Name = "lblDewPoint";
            this.lblDewPoint.Size = new System.Drawing.Size(43, 22);
            this.lblDewPoint.TabIndex = 15;
            this.lblDewPoint.Text = "0°C";
            // 
            // lblVisibility
            // 
            this.lblVisibility.AutoSize = true;
            this.lblVisibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisibility.ForeColor = System.Drawing.Color.Black;
            this.lblVisibility.Location = new System.Drawing.Point(518, 142);
            this.lblVisibility.Name = "lblVisibility";
            this.lblVisibility.Size = new System.Drawing.Size(42, 22);
            this.lblVisibility.TabIndex = 14;
            this.lblVisibility.Text = "0 m";
            // 
            // lblSnowFall
            // 
            this.lblSnowFall.AutoSize = true;
            this.lblSnowFall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnowFall.ForeColor = System.Drawing.Color.Black;
            this.lblSnowFall.Location = new System.Drawing.Point(314, 142);
            this.lblSnowFall.Name = "lblSnowFall";
            this.lblSnowFall.Size = new System.Drawing.Size(52, 22);
            this.lblSnowFall.TabIndex = 13;
            this.lblSnowFall.Text = "0 cm";
            // 
            // lblWindSpeed
            // 
            this.lblWindSpeed.AutoSize = true;
            this.lblWindSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindSpeed.ForeColor = System.Drawing.Color.Black;
            this.lblWindSpeed.Location = new System.Drawing.Point(118, 142);
            this.lblWindSpeed.Name = "lblWindSpeed";
            this.lblWindSpeed.Size = new System.Drawing.Size(69, 22);
            this.lblWindSpeed.TabIndex = 12;
            this.lblWindSpeed.Text = "0 km/h";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(314, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Snow Fall";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(518, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Visibilty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(118, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Wind Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(517, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rain";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(313, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dew Point";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(117, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Humidity";
            // 
            // gpDayWeather
            // 
            this.gpDayWeather.BackColor = System.Drawing.Color.Transparent;
            this.gpDayWeather.BorderColor = System.Drawing.Color.Transparent;
            this.gpDayWeather.Controls.Add(this.hourlyWeatherParentPanel);
            this.gpDayWeather.Controls.Add(this.label21);
            this.gpDayWeather.Controls.Add(this.label18);
            this.gpDayWeather.Controls.Add(this.label19);
            this.gpDayWeather.Controls.Add(this.label7);
            this.gpDayWeather.CornerRadius = 30;
            this.gpDayWeather.ForeColor = System.Drawing.Color.White;
            this.gpDayWeather.GlassColor = System.Drawing.Color.Transparent;
            this.gpDayWeather.Location = new System.Drawing.Point(98, 276);
            this.gpDayWeather.Name = "gpDayWeather";
            this.gpDayWeather.Size = new System.Drawing.Size(709, 220);
            this.gpDayWeather.TabIndex = 3;
            // 
            // hourlyWeatherParentPanel
            // 
            this.hourlyWeatherParentPanel.AutoScroll = true;
            this.hourlyWeatherParentPanel.AutoScrollMinSize = new System.Drawing.Size(900, 0);
            this.hourlyWeatherParentPanel.BackColor = System.Drawing.Color.Transparent;
            this.hourlyWeatherParentPanel.Controls.Add(this.hourlyWeatherContainer);
            this.hourlyWeatherParentPanel.Location = new System.Drawing.Point(24, 26);
            this.hourlyWeatherParentPanel.Name = "hourlyWeatherParentPanel";
            this.hourlyWeatherParentPanel.Padding = new System.Windows.Forms.Padding(3, 10, 0, 5);
            this.hourlyWeatherParentPanel.Size = new System.Drawing.Size(661, 190);
            this.hourlyWeatherParentPanel.TabIndex = 41;
            this.hourlyWeatherParentPanel.WrapContents = false;
            // 
            // hourlyWeatherContainer
            // 
            this.hourlyWeatherContainer.BackColor = System.Drawing.Color.Transparent;
            this.hourlyWeatherContainer.BorderColor = System.Drawing.Color.Transparent;
            this.hourlyWeatherContainer.Controls.Add(this.hourlyWeatherForecast);
            this.hourlyWeatherContainer.Controls.Add(this.imgHourlyWeather);
            this.hourlyWeatherContainer.Controls.Add(this.hourlyWeatherCelcius);
            this.hourlyWeatherContainer.Controls.Add(this.hourlyWeatherTime);
            this.hourlyWeatherContainer.CornerRadius = 10;
            this.hourlyWeatherContainer.ForeColor = System.Drawing.Color.White;
            this.hourlyWeatherContainer.GlassColor = System.Drawing.Color.Transparent;
            this.hourlyWeatherContainer.Location = new System.Drawing.Point(13, 15);
            this.hourlyWeatherContainer.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.hourlyWeatherContainer.Name = "hourlyWeatherContainer";
            this.hourlyWeatherContainer.Size = new System.Drawing.Size(121, 150);
            this.hourlyWeatherContainer.TabIndex = 38;
            // 
            // hourlyWeatherForecast
            // 
            this.hourlyWeatherForecast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourlyWeatherForecast.ForeColor = System.Drawing.Color.Black;
            this.hourlyWeatherForecast.Location = new System.Drawing.Point(3, 125);
            this.hourlyWeatherForecast.Name = "hourlyWeatherForecast";
            this.hourlyWeatherForecast.Size = new System.Drawing.Size(118, 18);
            this.hourlyWeatherForecast.TabIndex = 45;
            this.hourlyWeatherForecast.Text = "Light Rain";
            this.hourlyWeatherForecast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgHourlyWeather
            // 
            this.imgHourlyWeather.BackColor = System.Drawing.Color.Transparent;
            this.imgHourlyWeather.BackgroundImage = global::weather_app_winforms.Properties.Resources.night;
            this.imgHourlyWeather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgHourlyWeather.Location = new System.Drawing.Point(27, 27);
            this.imgHourlyWeather.Name = "imgHourlyWeather";
            this.imgHourlyWeather.Size = new System.Drawing.Size(71, 72);
            this.imgHourlyWeather.TabIndex = 43;
            this.imgHourlyWeather.TabStop = false;
            // 
            // hourlyWeatherCelcius
            // 
            this.hourlyWeatherCelcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourlyWeatherCelcius.ForeColor = System.Drawing.Color.Black;
            this.hourlyWeatherCelcius.Location = new System.Drawing.Point(3, 103);
            this.hourlyWeatherCelcius.Name = "hourlyWeatherCelcius";
            this.hourlyWeatherCelcius.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.hourlyWeatherCelcius.Size = new System.Drawing.Size(112, 18);
            this.hourlyWeatherCelcius.TabIndex = 44;
            this.hourlyWeatherCelcius.Text = "24°C";
            this.hourlyWeatherCelcius.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hourlyWeatherTime
            // 
            this.hourlyWeatherTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourlyWeatherTime.ForeColor = System.Drawing.Color.Black;
            this.hourlyWeatherTime.Location = new System.Drawing.Point(3, 5);
            this.hourlyWeatherTime.Name = "hourlyWeatherTime";
            this.hourlyWeatherTime.Size = new System.Drawing.Size(115, 18);
            this.hourlyWeatherTime.TabIndex = 42;
            this.hourlyWeatherTime.Text = "1 AM";
            this.hourlyWeatherTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(533, 157);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 18);
            this.label21.TabIndex = 31;
            this.label21.Text = "24°C";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(401, 184);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 18);
            this.label18.TabIndex = 29;
            this.label18.Text = "Light Rain";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(416, 157);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 18);
            this.label19.TabIndex = 28;
            this.label19.Text = "24°C";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(27, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Hourly Weather";
            // 
            // gpSideBar
            // 
            this.gpSideBar.BackColor = System.Drawing.Color.Transparent;
            this.gpSideBar.BorderColor = System.Drawing.Color.Transparent;
            this.gpSideBar.Controls.Add(this.pictureBox9);
            this.gpSideBar.Controls.Add(this.refreshPanelContainer);
            this.gpSideBar.CornerRadius = 30;
            this.gpSideBar.ForeColor = System.Drawing.Color.White;
            this.gpSideBar.GlassColor = System.Drawing.Color.Transparent;
            this.gpSideBar.Location = new System.Drawing.Point(12, 12);
            this.gpSideBar.Name = "gpSideBar";
            this.gpSideBar.Size = new System.Drawing.Size(80, 678);
            this.gpSideBar.TabIndex = 0;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = global::weather_app_winforms.Properties.Resources.Untitled_design_removebg_preview;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox9.Location = new System.Drawing.Point(8, 18);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(64, 59);
            this.pictureBox9.TabIndex = 1;
            this.pictureBox9.TabStop = false;
            // 
            // refreshPanelContainer
            // 
            this.refreshPanelContainer.AutoSize = true;
            this.refreshPanelContainer.BackColor = System.Drawing.Color.Transparent;
            this.refreshPanelContainer.BorderColor = System.Drawing.Color.Transparent;
            this.refreshPanelContainer.Controls.Add(this.imgRefresh);
            this.refreshPanelContainer.CornerRadius = 5;
            this.refreshPanelContainer.ForeColor = System.Drawing.Color.White;
            this.refreshPanelContainer.GlassColor = System.Drawing.Color.Transparent;
            this.refreshPanelContainer.Location = new System.Drawing.Point(20, 93);
            this.refreshPanelContainer.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.refreshPanelContainer.Name = "refreshPanelContainer";
            this.refreshPanelContainer.Padding = new System.Windows.Forms.Padding(5);
            this.refreshPanelContainer.Size = new System.Drawing.Size(33, 37);
            this.refreshPanelContainer.TabIndex = 39;
            // 
            // imgRefresh
            // 
            this.imgRefresh.BackColor = System.Drawing.Color.Transparent;
            this.imgRefresh.BackgroundImage = global::weather_app_winforms.Properties.Resources.icons8_refresh_48;
            this.imgRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgRefresh.Location = new System.Drawing.Point(5, 5);
            this.imgRefresh.Margin = new System.Windows.Forms.Padding(10);
            this.imgRefresh.Name = "imgRefresh";
            this.imgRefresh.Padding = new System.Windows.Forms.Padding(3);
            this.imgRefresh.Size = new System.Drawing.Size(23, 27);
            this.imgRefresh.TabIndex = 8;
            this.imgRefresh.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::weather_app_winforms.Properties.Resources.bg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 702);
            this.Controls.Add(this.lblFeelsLike);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.lblWeatherNow);
            this.Controls.Add(this.imgWeatherNow);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.lblDegreeNow);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.imgSearch);
            this.Controls.Add(this.gpSearchResult);
            this.Controls.Add(this.gpWeatherNow);
            this.Controls.Add(this.gpDayWeather);
            this.Controls.Add(this.gpSideBar);
            this.Controls.Add(this.lblPlace);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            ((System.ComponentModel.ISupportInitialize)(this.imgSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgWeatherNow)).EndInit();
            this.gpSearchResult.ResumeLayout(false);
            this.gpSearchResult.PerformLayout();
            this.searchListPanel.ResumeLayout(false);
            this.tenDayWeatherForecastContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgWeather)).EndInit();
            this.gpWeatherNow.ResumeLayout(false);
            this.gpWeatherNow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpDayWeather.ResumeLayout(false);
            this.gpDayWeather.PerformLayout();
            this.hourlyWeatherParentPanel.ResumeLayout(false);
            this.hourlyWeatherContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgHourlyWeather)).EndInit();
            this.gpSideBar.ResumeLayout(false);
            this.gpSideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.refreshPanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox imgWeatherNow;
        private GlassmorphicPanel gpWeatherNow;
        private GlassmorphicPanel gpDayWeather;
        private GlassmorphicPanel gpSearchResult;
        private System.Windows.Forms.PictureBox imgSearch;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label lblWeatherNow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDewPoint;
        private System.Windows.Forms.Label lblVisibility;
        private System.Windows.Forms.Label lblSnowFall;
        private System.Windows.Forms.Label lblWindSpeed;
        private System.Windows.Forms.Label lblRain;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblFeelsLike;
        private System.Windows.Forms.FlowLayoutPanel searchListPanel;
        private GlassmorphicPanel tenDayWeatherForecastContainer;
        private System.Windows.Forms.PictureBox imgWeather;
        private System.Windows.Forms.Label lblCelciusWeather;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblRainStatus;
        private GlassmorphicPanel gpSideBar;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label lblDegreeNow;
        private System.Windows.Forms.FlowLayoutPanel hourlyWeatherParentPanel;
        private GlassmorphicPanel hourlyWeatherContainer;
        private System.Windows.Forms.Label hourlyWeatherForecast;
        private System.Windows.Forms.PictureBox imgHourlyWeather;
        private System.Windows.Forms.Label hourlyWeatherCelcius;
        private System.Windows.Forms.Label hourlyWeatherTime;
        private System.Windows.Forms.Label label8;
        private GlassmorphicPanel refreshPanelContainer;
        private System.Windows.Forms.PictureBox imgRefresh;
    }
}

