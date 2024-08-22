using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyNumberGuessingGameProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isCorrectGuess = false;
            Random random = new Random();
            int randomNum = random.Next(1,20);

            Console.WriteLine("Hey!Welcome to the Number Guessing Game");
            Console.WriteLine("A number between 1 and 20 will be generated");
            Console.WriteLine("if ypu guess the correct number,you win");
            //this while loop keep running if correct guess is false
            while (!isCorrectGuess)
            {
                Console.WriteLine("Please enter your guess");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > randomNum)
                {
                    Console.WriteLine("Your guess is too high.");
                }
                else if (guess < randomNum)
                {
                    Console.WriteLine("Your guess is too low");
                }
                else
                {
                    Console.WriteLine("Correct!");
                    isCorrectGuess = true;
                }
            }
            Console.WriteLine("Amazing dear! You have won the number guessing game!");
            Console.ReadKey();
        }
    }
}
