namespace TicTacToe.Cli;

internal class Program
{
    private static void Main(string[] args)
    {
        var textColor = Console.ForegroundColor;
        var backgroundColor = Console.BackgroundColor;
        var game = new Game();
        game.Start();
        Console.ForegroundColor = textColor;
        Console.BackgroundColor = backgroundColor;
    }
}