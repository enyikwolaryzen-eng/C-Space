using System;

namespace CSpace
{
    class Program6
    {
        static void Main(string[] args)
        {
            int num1; // Your first number
            int num2; // yYour second number

            int result; // The Result

            string?  answer; // Answer

            System.Console.WriteLine("Hello, Welcome to the calculator program");
            System.Console.WriteLine(" Please enter your first number"); 

            num1 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Please enter your second number");

            num2 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("What type of operation would you like to do ?");
            System.Console.WriteLine("Please enter A for Addition, S for subtraction, M for Multiplication and D for Division");  // To select different modes of Operation

            answer = Console.ReadLine();

            if(answer == "A")  // For Addition
            {
                result = num1 +num2;
            }
            else if(answer =="S") // For subtraction 
            {
                result = num1 - num2;
            }
            else if(answer =="M") // For Multiplication
            {
                result = num1 * num2;
            }
            else // Anything else for Division 
            {
                result = num1 / num2;
            }

            System.Console.WriteLine("the result is " + result);
            System.Console.WriteLine("Thank you for using my first calculator program");

            System.Console.WriteLine("Come Back Next Time");

            System.Console.ReadKey();

        }
    }
}        