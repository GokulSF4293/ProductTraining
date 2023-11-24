using System;
namespace Operators;
class Program
{
    public static void Main(string[] args)
    {
        Calculations.Addition(23,45);
        Calculations.Subtraction(48,12);
        Calculations.Multiplication(12,12);
        Calculations.Division(20,20);
        Calculations.Modules(10,5);

        Calculations.Check(23,44,54);
        Calculations.Check(10,2,3);
    }
}