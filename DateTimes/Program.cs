using System;
using System.ComponentModel;
namespace DateTimes;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"{DateTime.Now.Month}");
        DateTime date = DateTime.Now.AddDays(-3);
        Console.WriteLine($"{date.ToString("dd/MM/yyy")}");
        Console.WriteLine($"{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}");
    }
}