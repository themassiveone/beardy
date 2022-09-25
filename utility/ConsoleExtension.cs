public static class Terminal
{
    public static void WriteLine(object subject, ConsoleColor consoleColor = ConsoleColor.Gray)
    {
        Console.ForegroundColor = consoleColor;
        Console.WriteLine(subject);
        Console.ForegroundColor = ConsoleColor.Gray;

    }

    public static void Write(object subject, ConsoleColor consoleColor = ConsoleColor.Gray)
    {
        Console.ForegroundColor = consoleColor;
        Console.Write(subject);
        Console.ForegroundColor = ConsoleColor.Gray;

    }


}