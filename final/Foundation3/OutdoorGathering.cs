class OutdoorGathering : Event
{
    public OutdoorGathering(string title, string description, DateTime date, string time, Address address) : base(title, description, date, time, address)
    {
    }

    public override string FullDetails()
    {
        string weatherInfo = GetWeatherInfo();
        return $"{base.FullDetails()}\nWeather: {weatherInfo}";
    }
    private string GetWeatherInfo()
    {
        Random random = new Random();
        int temperature = random.Next(-10,120);
        int chanceOfRain = random.Next(0,101);

        return $"Temperature: {temperature}*C, Chance of Rain: {chanceOfRain}%";
    }
}