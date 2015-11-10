using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            long a;
            Console.WriteLine(@"Please,  type the number:
            1. Farmer, wolf, goat and cabbage puzzle
            2. Console calculator
            3. Factorial calculation
            4. Advanced task
            ");
            
            a = long.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Farmer_puzzle();
                    Console.WriteLine("");
                    break;
                case 2:
                    Calculator();
                    Console.WriteLine("");
                    break;
                case 3:
                    Factorial_calculation();
                    Console.WriteLine("");
                    break;
                case 4:
                    Advanced_task();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }








        #region farmer
        static void Farmer_puzzle()
        {

        var welcMessage = FarmerMessages.InputMessage;
            int[] sol1 = {3, 8, 2, 7, 1, 8, 3};
            int[] sol2 = {3, 8, 1, 7, 2, 8, 3};
            byte inputNum;
            bool isInputCorrect;
            byte solNumFlag = 0;


            Console.WriteLine(welcMessage);

            for (int i = 0; i <= 6; i++)
            {
                inputNum = byte.Parse(Console.ReadLine());

                if (solNumFlag == 0)
                {
                    if ((inputNum == sol1[i]) && (inputNum != sol2[i]))
                        solNumFlag = 1;
                    else if ((inputNum != sol1[i]) && (inputNum == sol2[i]))
                        solNumFlag = 2;
                }
                
                isInputCorrect = ((inputNum == sol1[i] && solNumFlag != 2) || (inputNum == sol2[i] && solNumFlag != 1));
                if (isInputCorrect)
                {
                    if (i < 6)
                    {
                        Console.WriteLine("Correct step");
                        Console.WriteLine("Type your next step");
                    }
                    else
                    {
                        Console.WriteLine("Correct step");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Failure");
                    return;
                }
            }

            Console.WriteLine("Oh! You done it!");
           
        }

        
        #endregion

        #region calculator
       
        static void Calculator()
        {
            Console.WriteLine(@"Select the arithmetic operation:
                1. Multiplication
                2. Divide
                3. Addition
                4. Substraction
                5. Exponentiation");

           
            
            var CorrectOptype = false;
            byte OperationTypeNum = 0;
            double operand1, operand2;
            double result = 0;
            string[] OperationType = {"Multiplication", "Divide", "Addition", "Substraction", "Exponentiation"};
            string[] OperationTypeSymbol = { "*", "/", "+", "-", "^" };

            
            while (!CorrectOptype)
            {
                OperationTypeNum = byte.Parse(Console.ReadLine());
                CorrectOptype = ((OperationTypeNum == 1) || (OperationTypeNum == 2) || (OperationTypeNum == 3) || (OperationTypeNum == 4) || (OperationTypeNum == 5));
                if (!CorrectOptype)
                    Console.WriteLine("Please choose correct operation type");
            };
            

            Console.WriteLine("Enter first operand:");
            operand1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second operand:");
            operand2 = int.Parse(Console.ReadLine());

            switch (OperationTypeNum)
            {
                case 1:
                    result = operand1 * operand2;
                    break;
                case 2:
                    result = operand1 / operand2;
                    break;
                case 3:
                    result = operand1 + operand2;
                    break;
                case 4:
                    result = operand1 - operand2;
                    break;
                case 5:
                    result = Math.Pow(operand1, operand2);
                    break;
                default:
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Operation {0}:", OperationType[OperationTypeNum-1]);
            Console.WriteLine("{0} {1} {2} = {3}", operand1, OperationTypeSymbol[OperationTypeNum-1], operand2, result );

            
        }
        #endregion

        #region Factorial
        static void Factorial_calculation()
        {
        long f, result;

        Console.WriteLine("Enter the number to obtain factorial of it");
        f = long.Parse(Console.ReadLine());
            result=1;

            if (f==0) result=1;
            else
                {
            for (int i = 1; i <= f; i++)
                result = result * i;
                };

            Console.WriteLine("Factorial of {0} = {1}", f, result);
            //Console.ReadLine();
        }
        #endregion

        #region AdvancedTask
        static void Advanced_task()
        {
            const int max = 200;
            Random rnd = new Random();
            var value = rnd.Next(max) + 1;
            int guess;
            var guessed = false;

            Console.WriteLine("You have to guess the number between 1 and {0}", max);
            while (!guessed)
                {
                Console.WriteLine("Enter you guess please:");
                guess = int.Parse(Console.ReadLine());
                if (guess > value)
                    Console.WriteLine("{0} - Too high!", guess);
                else if (guess < value)
                    Console.WriteLine("{0} - Too low!", guess);
                else
                    {
                    Console.WriteLine("{0} is right! Congratulations", guess);
                    guessed = true;
                    }
                }
        }

        #endregion
    }
}
