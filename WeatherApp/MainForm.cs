using System;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WeatherApp
{
    public partial class MainForm : Form
    {
        const string APPID = "401df202e10a68a5235956d31061bb5f";
        string cityName = "Bielsko";

        public MainForm()
        {
            InitializeComponent();
            getWeather("Bielsko-Biała"); // one day weather
            getForecast("Bielsko-Biała"); // more than one day
        }

        void getWeather(string city)
        {
            using(WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric&cnt=6", city, APPID);
                var json = web.DownloadString(url);
                var result = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                WeatherInfo.root outPut = result;

                labelCityName.Text = string.Format("{0}", outPut.name);
                labelCountryName.Text = string.Format("{0}", outPut.sys.country);
                labelScaleName.Text = string.Format("{0} \u00B0" + "C", outPut.main.temp);
            }
        }

        void getForecast(string city)
        {
            using(WebClient web = new WebClient())
            {
                int day = 5;
                string url = string.Format("http://api.openweathermap.org/data/2.5/forecast?q={0}&units=metric&cnt={1}&APPID={2}", city, day, APPID);
                var json = web.DownloadString(url);
                var result = JsonConvert.DeserializeObject<WeatherForecast>(json);

                WeatherForecast forecast = result;

                labelDay.Text = string.Format("{0}", getDate(forecast.list[1].dt).DayOfWeek);
                labelCondition.Text = string.Format("{0}", forecast.list[1].weather[0].main);
                labelDescription.Text = string.Format("{0}", forecast.list[1].weather[0].description);
                labelTemp.Text = string.Format("{0} \u00B0" + "C", forecast.list[1].temp);
                labelWind.Text = string.Format("{0} km/h", forecast.list[1].speed);

                labelDay2.Text = string.Format("{0}", getDate(forecast.list[2].dt).DayOfWeek);
                labelCondition2.Text = string.Format("{0}", forecast.list[2].weather[0].main);
                labelDescription2.Text = string.Format("{0}", forecast.list[2].weather[0].description);
                labelTemp2.Text = string.Format("{0} \u00B0" + "C", forecast.list[2].temp);
                labelWind2.Text = string.Format("{0} km/h", forecast.list[2].speed);
            }
        }

        DateTime getDate(double milliseconds)
        {
            DateTime day = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(milliseconds).ToLocalTime();

            return day;
        }
    }
}