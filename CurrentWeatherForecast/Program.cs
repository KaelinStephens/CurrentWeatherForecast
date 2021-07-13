using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace CurrentWeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var city = new City();
            Console.WriteLine("The current temperature in Dubai is:");
            Console.WriteLine();
            Console.WriteLine("..................................");
            Console.WriteLine();
            var forecastResponse = client.GetStringAsync("api.openweathermap.org/data/2.5/weather?q=Dubai&appid=8b5de2303eb9da834cb65d5ed38bd581").Result;
            
            var forcastCurrent = JObject.Parse(forecastResponse).GetValue("temp").ToString();

            city.Name = "Dubai";
            city.Temp = city.TempInF(double.Parse(forcastCurrent));
            Console.WriteLine($"{city.Temp} degrees F");
        }
    }
}
