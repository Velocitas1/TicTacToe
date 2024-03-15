using Common;

namespace TicTacToe;

public class Game
{
    private Board Board { get; } = new();
    private Player Player1 { get; } = new();
    private Player Player2 { get; } = new();
    private const int Delay = 2;
    public void Start()
    {
        "Welcome to Tic-Tac-Toe!".DisplayLine(ConsoleColor.Blue);
        ConsoleFunctions.ClearAfter(Delay);
        EnterPlayerName(Player1, "Team X");
        EnterPlayerName(Player2, "Team O");
    }

    private static void EnterPlayerName(Player player, string playerId)
    {
        player.Name = $"Player {playerId} enter your name: ".Prompt(ConsoleColor.Yellow); 
        $"Welcome {player.Name}!".DisplayLine(ConsoleColor.Blue);
        ConsoleFunctions.ClearAfter(Delay);
    }
}