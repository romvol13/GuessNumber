using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    public class GameGuessNumber
    {
        private int _input = 0;
        private int _luckyNumber = new Random().Next(0, 101);

        public GameGuessNumber() {}  // I created an empty constructor only for easier testing

        public void LaunchGame()
        {
            Console.WriteLine("To win the game try to guess the number from 0 till 100 (included):");
            do
            {
                if (!int.TryParse(Console.ReadLine(), out _input))
                {
                    Console.WriteLine("Error! You can enter only numbers.");
                    continue;
                }
                else if (_input > _luckyNumber)
                {
                    Console.WriteLine("My number is smaller!");
                }
                else if (_input < _luckyNumber)
                {
                    Console.WriteLine("My number is bigger!");
                }
            } while (!IsWon(_input, _luckyNumber));
            Console.WriteLine("You won the game!");
        }

        public bool IsWon(int _input, int _luckyNumber)
        {
            if (_input != _luckyNumber)
            {
                return false;
            }
            return true;
        }

        public bool RestartGame(string input)
        {
            if (input.ToUpper() == "R")
            {
                return true;
            }
            return false;
        }
    }
}
