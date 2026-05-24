using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows;

namespace Ryzen
{
    class Program5
    {
        public static void Main(string[] args)
        {
            string name = "Ella";
            System.Console.Write("My friend name is ");
            System.Console.WriteLine(name);

            string textPositive = " 4.56";
            double Positive = Convert.ToDouble(textPositive);
            System.Console.WriteLine(Positive);


            string textPosition = "3.14";
            float Position = Convert.ToSingle(textPosition);
            System.Console.WriteLine(Position);

            string textNaira = "50.60";
            decimal Naira = Convert.ToDecimal(textNaira);
            System.Console.WriteLine(Naira);

            
            bool  isMale = true;
            System.Console.WriteLine(isMale);

            isMale = false;
            System.Console.WriteLine(isMale);
            

            int age =25;

            // = +  // operators 
            age -= 12;
            System.Console.WriteLine(age);

            int cat = 30;

            // = +  // operators 
            cat *=2;
            System.Console.WriteLine(cat);
         
           //  name += " is Programming";( to add varibales_)

            System.Console.ReadLine();


            

            
        }

    }

}
