namespace Lab11Models;

public class AuditReporter
{
    public static void PrintAudit(int value)
    {
        Console.WriteLine($"Аудит музею: зафіксовано порогове значення {value} відвідувачів");
    }
}