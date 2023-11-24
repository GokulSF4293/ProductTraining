using System;
using System.Runtime.InteropServices;
namespace WhileLoop;
class Program
{
    public static void Main(string[] args)
    {
        string option = "Y";
        while (option == "Y")
        {
            Console.WriteLine("Which is the captial of india?\n1. Chennai\n2. Delhi\n3. Mumbai\n4. Kolkata");
            int answer = int.Parse(Console.ReadLine());
            if(answer == 2) 
            {
                Console.WriteLine("Correct answer.");
            }
            else
            {
                Console.WriteLine("Incorrect answer enter the correct answer.");
            }
            Console.WriteLine("Press Y to continue and Press N to close.");
            option = Console.ReadLine().ToUpper();
        }
    }
}