using System;
namespace IfStatement;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Grade:");
        string grade = Console.ReadLine().ToUpper();
        if(grade == "A")
        {
            Console.WriteLine("Grade A denotes 9 Points");
        }
        else if(grade == "B")
        {
            Console.WriteLine("Grade B denotes 8 Points");
        }
        else if(grade == "C")
        {
            Console.WriteLine("Grade C denotes 7 Points");
        }
        else if(grade == "D")
        {
            Console.WriteLine("Grade D denotes 6 Points");
        }
        else        
        {
            Console.WriteLine("This is not valid Grade");
        }
    }
}