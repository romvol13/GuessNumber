namespace GuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameGuessNumber newGame = new GameGuessNumber();
            newGame.LaunchGame();

            Console.WriteLine("Press R if you want to play again");
            string input = Console.ReadLine();

            if (newGame.RestartGame(input))
            {
                Console.Clear();
                newGame.LaunchGame();
            }
        }
    }
}