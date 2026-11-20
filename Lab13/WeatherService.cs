using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Lab13;
public static class WeatherService
{

    private static readonly HttpClient Client = new()
    {
        Timeout = TimeSpan.FromSeconds(15)
    };

    public const string SourceName = "Open-Meteo";

    public const string SourceUrl =
        $"https://api.open-meteo.com/v1/forecast?latitude=50.7472&longitude=25.3254" +
        $"&current=temperature_2m,relative_humidity_2m&timezone=Europe%2FKyiv";

    public static async Task<WeatherReading> LoadLutskAsync()
    {

        string json = await Client.GetStringAsync(SourceUrl);

        using JsonDocument document = JsonDocument.Parse(json);
        JsonElement current = document.RootElement.GetProperty("current");

        double temperature = current.GetProperty("temperature_2m").GetDouble();
        int humidity = current.GetProperty("relative_humidity_2m").GetInt32();
        string time = current.GetProperty("time").GetString() ?? "Час невідомий";

        return new WeatherReading
        {
            City = "Луцьк",
            TemperatureC = temperature,
            HumidityPercent = humidity,
            ObservationTime = time
        };
    }
}