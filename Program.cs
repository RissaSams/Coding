using System;

namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            string userProblem;
            double num1, num2, total;
            while (true)
            {
                userProblem = GetInput("Enter a math problem or exit: ");
                if (userProblem == "exit")
                {
                    break;
                }
                string[] userProblemsParts = userProblem.Split(" ");
                Double.TryParse(userProblemsParts[0], out num1);
                Double.TryParse(userProblemsParts[2], out num2);

                if (userProblemsParts[1] == "+")
                {
                    total = num1 + num2;
                    Console.WriteLine("The total is: " + total);
                }
                else if (userProblemsParts[1] == "-")
                {
                    total = num1 - num2;
                    Console.WriteLine("The total is: " + total);
                }
                else if (userProblemsParts[1] == "*")
                {
                    total = num1 * num2;
                    Console.WriteLine("The total is: " + total);
                }
                else if (userProblemsParts[1] == "/")
                {
                    total = num1 / num2;
                    Console.WriteLine("The total is: " + total);
                }
                else if (userProblemsParts[1] == "^")
                {
                    total = Math.Pow(num1, num2);
                    Console.WriteLine("The total is: " + total);
                }
                else if (userProblemsParts[1] == "%")
                {
                    total = num1 % num2;
                    Console.WriteLine("The total is: " + total);
                }
            }
        }

        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            string str = Console.ReadLine();
            return str;
        }   // end of the GetInput method

        public static int GetNumber(string prompt)
        {
            int userNumber;
            string strNumber = GetInput(prompt);
            while (!Int32.TryParse(strNumber, out userNumber))
            {
                Console.WriteLine("That is not an integer");
                strNumber = GetInput(prompt);
            }
            return userNumber;
        }   // end of the GetNumber method
    }
}
