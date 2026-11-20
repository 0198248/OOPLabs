namespace WeatherFileApp
{
    public class WeatherSnapshot
    {
        public string DataSource { get; set; } = "";
        public string SourceUrl { get; set; } = "";
        public DateTimeOffset SavedAt { get; set; }
        public WeatherReading? Reading { get; set; }
    }
}