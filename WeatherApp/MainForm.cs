using System;
using System.Drawing;
using System.Net;
using System.Text;
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

                byte[] bytes = Encoding.Default.GetBytes(outPut.name);
                outPut.name = Encoding.UTF8.GetString(bytes);

                labelCityName.Text = string.Format("{0}", outPut.name);
                labelCountryName.Text = string.Format("{0}", outPut.sys.country);
                labelScaleName.Text = string.Format("{0} \u00B0" + "C", outPut.main.temp);

                pictureMain.Image = setIcon(outPut.weather[0].icon);
            }
        }

        void getForecast(string city)
        {
            using(WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/forecast?q={0}&units=metric&APPID={1}", city, APPID);
                var json = web.DownloadString(url);
                var result = JsonConvert.DeserializeObject<WeatherForecast>(json);

                WeatherForecast forecast = result;

                labelDay.Text = string.Format("{0}", getDate(forecast.list[9].dt).DayOfWeek);
                labelCondition.Text = string.Format("{0}", forecast.list[9].weather[0].main);
                labelDescription.Text = string.Format("{0}", forecast.list[9].weather[0].description);
                labelTemp.Text = string.Format("{0} \u00B0" + "C", forecast.list[9].main.temp);
                labelWind.Text = string.Format("{0} km/h", forecast.list[9].wind.speed);
                pictureBox1.Image = setIcon(forecast.list[9].weather[0].icon);

                labelDay2.Text = string.Format("{0}", getDate(forecast.list[17].dt).DayOfWeek);
                labelCondition2.Text = string.Format("{0}", forecast.list[17].weather[0].main);
                labelDescription2.Text = string.Format("{0}", forecast.list[17].weather[0].description);
                labelTemp2.Text = string.Format("{0} \u00B0" + "C", forecast.list[17].main.temp);
                labelWind2.Text = string.Format("{0} km/h", forecast.list[17].wind.speed);
                pictureBox2.Image = setIcon(forecast.list[17].weather[0].icon);

                labelDay3.Text = string.Format("{0}", getDate(forecast.list[26].dt).DayOfWeek);
                labelCondition3.Text = string.Format("{0}", forecast.list[26].weather[0].main);
                labelDescription3.Text = string.Format("{0}", forecast.list[26].weather[0].description);
                labelTemp3.Text = string.Format("{0} \u00B0" + "C", forecast.list[26].main.temp);
                labelWind3.Text = string.Format("{0} km/h", forecast.list[26].wind.speed);
                pictureBox3.Image = setIcon(forecast.list[26].weather[0].icon);
            }
        }

        DateTime getDate(double milliseconds)
        {
            DateTime day = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(milliseconds).ToLocalTime();

            return day;
        }

        Image setIcon(string iconID)
        {
            string url = string.Format("http://openweathermap.org/img/w/{0}.png", iconID); // weather icon resource
            var request = WebRequest.Create(url);
            using(var response = request.GetResponse())
            using(var weatherIcon = response.GetResponseStream())
            {
                Image weatherImage = Bitmap.FromStream(weatherIcon);
                return weatherImage;
            }
        }
    }
}