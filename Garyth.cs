using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld 
{
    class Program1
    {
        static void Main(string[] args)
        {
            var number = 2;
            int count = 10;
            float totalPrice=  20.95f;
            char character = 'A';
            string firstName = "Tony";
            bool isWorking = false;

            System.Console.WriteLine(number);
            System.Console.WriteLine(count);
            System.Console.WriteLine(totalPrice);
            System.Console.WriteLine(character);
            System.Console.WriteLine(firstName);
            System.Console.WriteLine(isWorking);


        }
    }
}