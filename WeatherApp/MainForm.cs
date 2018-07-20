using System.Net;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class MainForm : Form
    {
        const string APPID = "";
        string cityName = "Bielsko";

        public MainForm()
        {
            InitializeComponent();
        }

        void getWeather(string city)
        {
            using(WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q=Bielsko-Biała&appid=401df202e10a68a5235956d31061bb5f&units=metric&cnt=6");
                var json = web.DownloadString(url);
            }
        }
    }
}