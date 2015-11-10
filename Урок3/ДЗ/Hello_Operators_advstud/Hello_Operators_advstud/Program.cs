using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Operators_advstud
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MyMax = 200;

            Random random = new Random();
            int Guess_number = random.Next(MyMax) + 1;
            int Guess_1 = 0;
            int Guess_2 = 0;

            Console.WriteLine("Try to guess...");
            Console.WriteLine("The number is between 1 and {0}.", MyMax);

            while (Guess_1 != Guess_number)
            {
                Guess_2++;

                Console.Write("Enter your guess: ");
                int.TryParse(Console.ReadLine(), out Guess_1);

                if (Guess_1 > Guess_number)
                {
                    Console.WriteLine("{0}  - Too high!", Guess_1);
                }
                else if (Guess_1 < Guess_number)
                {
                    Console.WriteLine("{0}  - Too low!", Guess_1);
                }
                else
                {
                    Console.WriteLine("{0} is right! Congratulations.", Guess_1);
                    Console.WriteLine("Number of guesses: {0}", Guess_2);
                }
            }
        }
    }
}
