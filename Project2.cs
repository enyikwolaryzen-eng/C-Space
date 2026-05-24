using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Compression;
using System.Linq;

namespace NewWork
{
    
    class Program2
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("I like Ella"); // This is a comment

            string name = "Tony";   // This is a string variable
             System.Console.WriteLine(name);
             
            int age = 19;   // This is an integer variable
             System.Console.WriteLine(int.MinValue);
             System.Console.WriteLine(int.MaxValue);
             System.Console.WriteLine(age);

            string textace ="-75";
            int ace =  Convert.ToInt32(textace);// conrt a string to interger
            System.Console.WriteLine(ace);

            bool is_he_dead = false;  // This is a boolean variable 
            System.Console.WriteLine(is_he_dead);   

            string textbigNumber = "30000000";  // This is a bigNumber variablein place of intergers in a string form converted into a bigNumber
            long bigNumber= Convert.ToInt64(textbigNumber);
            System.Console.WriteLine(bigNumber);
          

            double negative = -75.53; // This is a double variable
            System.Console.WriteLine(negative);
            System.Console.WriteLine(double.MinValue);
            System.Console.WriteLine(double.MaxValue);

            float  height = 175.50f;   // This is a float variable
            System.Console.WriteLine(height);
            System.Console.WriteLine(float.MinValue);
            System.Console.WriteLine(float.MaxValue);

            decimal dollars = 53.99M ; // This is a decimal
            System.Console.WriteLine(dollars);
            System.Console.WriteLine(decimal.MinValue);
            System.Console.WriteLine(Decimal.MaxValue);


        }

    }

}
