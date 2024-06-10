public record DayTemperature(int Day, double HighestTemperature, double LowestTemperature);

class Program
{
    static void Main()
    {
        DayTemperature[] temperatures = new DayTemperature[]
        {
            new DayTemperature(1, 30.5, 15.2),
            new DayTemperature(2, 28.3, 14.8),
            new DayTemperature(3, 35.0, 20.0),
            new DayTemperature(4, 33.4, 22.1),
            new DayTemperature(5, 31.9, 16.4)
        };

        var dayWithMaxDifference = temperatures
            .Select(t => new { t.Day, Difference = t.HighestTemperature - t.LowestTemperature })
            .OrderByDescending(t => t.Difference)
            .First();

        Console.WriteLine($"The day with the maximum temperature difference is day {dayWithMaxDifference.Day} with a difference of {dayWithMaxDifference.Difference} degrees.");
    }
}
