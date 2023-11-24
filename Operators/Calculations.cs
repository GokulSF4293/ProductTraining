using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Operators
{
    public class Calculations
    {
        public static void Addition(double number1,double number2)
        {
            Console.WriteLine($"{number1+number2}");
        }

        public static void Subtraction(double number1,double number2)
        {
            Console.WriteLine($"{number1-number2}");
        }

        public static void Multiplication(double number1,double number2)
        {
            Console.WriteLine($"{number1*number2}");        }

        public static void Division(double number1,double number2)
        {
            Console.WriteLine($"{number1/number2}");
        }

        public static void Modules(double number1,double number2)
        {
            Console.WriteLine($"{number1%number2}");
        }

        public static void Check(double number1,double number2,double number3)
        {
            if(number1 > number2 && number1 > number3)
            {
                Console.WriteLine($"Largest number : {number1}");
            }
            else if(number2 > number3)
            {
                Console.WriteLine($"Largest number : {number2}");
            }
            else
            {
                Console.WriteLine($"Largest number : {number3}");
            }
        }
    }
}