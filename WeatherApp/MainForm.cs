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
            string url = "";
            using(WebClient web = new WebClient())
            {
                var json = web.DownloadString(url);
                var result = JsonConvert.DeserializeObject<WeatherForecast>(json);

                WeatherForecast forecast = result;

                labelCondition.Text = string.Format("{0}", forecast.list[1].weather[0].main);
            }
        }
    }
}