using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherAPI
{
    public partial class Form1 : Form
    {
        WeatherData.RootObject weatherData;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public string GetWeather(string url)
        {
            string html = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }
            return html;
        }

        private void Button_request_Click(object sender, EventArgs e)
        {
            string url = @"https://data.tmd.go.th/api/WeatherToday/V1/?type=json";
            string rawData = GetWeather(url);
            richTextBox_data.Text = rawData;
            weatherData = JsonConvert.DeserializeObject<WeatherData.RootObject>(rawData);
            for(int i=0;i<weatherData.Stations.Count;i++)
            {
                listBox_station.Items.Add(string.Format("จังหวัด {0} สถาณี {1}", weatherData.Stations[i].Province, weatherData.Stations[i].StationNameTh));
            }
        }

        private void ListBox_station_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox_station.SelectedIndex;
            label_station.Text = weatherData.Stations[index].StationNameTh;
            label_province.Text = weatherData.Stations[index].Province;
            label_temperature.Text = weatherData.Stations[index].Observe.Temperature.Value.ToString();
            label_maxTemperature.Text = weatherData.Stations[index].Observe.MaxTemperature.Value.ToString();
            label_minTemperature.Text = weatherData.Stations[index].Observe.MinTemperature.Value.ToString();
        }
    }
}
