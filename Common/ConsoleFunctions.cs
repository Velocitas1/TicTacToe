using System.Runtime.CompilerServices;

namespace Common;

public static class ConsoleFunctions
{
    public static string Prompt(this string prompt, ConsoleColor textColor = ConsoleColor.White, ConsoleColor backgroundColor = ConsoleColor.Black)
    {
        Display(prompt, textColor, backgroundColor);
        Console.ForegroundColor = ConsoleColor.Green;
        var input = Console.ReadLine();
        Console.Clear();
        return input;
    }

    public static void Display(this string message, ConsoleColor textColor = ConsoleColor.White, ConsoleColor backgroundColor = ConsoleColor.Black)
    {
        Console.Clear();
        Console.ForegroundColor = textColor;
        Console.BackgroundColor = backgroundColor;
        Console.Write(message);
    }

    public static void DisplayLine(this string message, ConsoleColor textColor = ConsoleColor.White, ConsoleColor backgroundColor = ConsoleColor.Black)
    {
        Display(message, textColor, backgroundColor);
        Console.WriteLine();
    }

    public static void ClearAfter(int seconds)
    {
        Thread.Sleep(seconds * 1000 /* milliseconds */);
        Console.Clear();
    }
}