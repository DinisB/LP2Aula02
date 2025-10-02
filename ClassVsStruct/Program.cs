using System;

namespace ClassVsStruct
{
    public class Program
    {
        static Player player1, player2;
        private static void Main(string[] args)
        {
            player1 = new Player(100, 50);
            player2 = player1;
            Console.WriteLine($"Player 1. Health: {player1.Health} Armor: {player1.Armor}");
            Console.WriteLine($"Player 2. Health: {player2.Health} Armor: {player2.Armor}");
            player1.Health = 47;
            player1.Armor = 120;
            Console.WriteLine($"Player 1. Health: {player1.Health} Armor: {player1.Armor}");
            Console.WriteLine($"Player 2. Health: {player2.Health} Armor: {player2.Armor}");
        }
    }
}
