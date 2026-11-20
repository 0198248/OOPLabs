namespace Lab11Models;

public class StatusReporter
{
    private string indicatorName;

    public StatusReporter(string indicatorName)
    {
        this.indicatorName = indicatorName;
    }

    public void PrintShort(int value)
    {
        Console.WriteLine($"Зареєстровано {value} {indicatorName}");
    }

    public void PrintDetailed(int value)
    {
        Console.WriteLine($"Поріг відвідуваності досягнуто: {value} {indicatorName}");
    }
}