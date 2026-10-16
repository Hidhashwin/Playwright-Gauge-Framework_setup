namespace PlaywrightGaugeFramework.Utilities;

public static class Logger
{
    public static void Info(string message)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"[INFO] {DateTime.Now:HH:mm:ss} - {message}");
        Console.ResetColor();
    }

    public static void Pass(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"[PASS] {DateTime.Now:HH:mm:ss} - {message}");
        Console.ResetColor();
    }

    public static void Fail(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"[FAIL] {DateTime.Now:HH:mm:ss} - {message}");
        Console.ResetColor();
    }

    public static void Warning(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"[WARN] {DateTime.Now:HH:mm:ss} - {message}");
        Console.ResetColor();
    }
}