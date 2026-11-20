using System;

namespace WeatherFileApp
{
    public class SavedWeatherReading
    {
        public int Id { get; set; }
        public string City { get; set; } = "";
        public double TemperatureC { get; set; }
        public int HumidityPercent { get; set; }

        public string ObservationTime { get; set; } = "";
        public string SourceUrl { get; set; } = "";
        public DateTime SavedAtUtc { get; set; }
        public string Notes { get; set; } = "";
        public bool IsFavorite { get; set; }
    }
}