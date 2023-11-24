using System;
namespace SwitchStatement;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number");
        int number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number");
        int number2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the option to perform task\n1. Add\n2. Subtract\n3. Divide\n4. Multiply");
        int option = int.Parse(Console.ReadLine());
        double number3;
        switch(option)
        {
            case 1:
            {
                number3 = number1 + number2;
                Console.WriteLine($"{number3}");
                break;
            }
            case 2:
            {
                number3 = number2 - number1;
                Console.WriteLine($"{number3}");
                break;
            }
            case 3:
            {
                number3 = number2 / number1;
                Console.WriteLine($"{number3}");
                break;
            }
            case 4:
            {
                number3 = number1 * number2;
                Console.WriteLine($"{number3}");
                break;
            }
        }
    }
}