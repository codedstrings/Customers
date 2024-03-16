using Newtonsoft.Json;
using System.Collections.Generic;
using WeatherApiTest.Helper;

namespace WeatherApiTest
{
    public class Program
    {
        //static async Task Main(string[] args)
        static async Task Main (string[] args)
        {
            #region HttpGet
            Console.WriteLine("Press any key to call API");
            Console.ReadLine();
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&daily=temperature_2m_max");
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                var weather = JsonConvert.DeserializeObject<Weather>(json);

                Console.WriteLine($"Latitude: {weather.latitude}, Longtitude: {weather.longitude}");
                Console.WriteLine($"Daily Max Temperatures:");

                for (int i = 0; i < weather.daily.time.Count; i++)
                {
                    Console.WriteLine($"{weather.daily.time[i]}: {weather.daily.temperature_2m_max[i]}°C");
                }
            }
            else
            {
                Console.WriteLine("Failed to fetch data. Status code: " + response.StatusCode);
            }
            #endregion
        }
    }
}
