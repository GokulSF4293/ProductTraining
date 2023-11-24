using System;
using System.Globalization;
namespace LoopingStatement;
class Program
{
    public static void Main(string[] args)
    {
        double sum = 0;
        double average = 0;
        for(int i=0;i<10;i++)
        {
            Console.WriteLine("Enter the number");
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }
        average = sum/10;
        Console.WriteLine($"Sum : {sum}\nAverage : {average}");
    }
}