using System;
namespace ExceptionHandling;
class Program{
    public static void Main(string[] args)
    {
        int [] numbers = new int[3];
        try
        {    
            Console.WriteLine("Enter the number 1:");
            bool temp = int.TryParse(Console.ReadLine(),out numbers[0]);
            while(!temp)
            {
                Console.WriteLine("Re-Enter the number 1:");
                temp = int.TryParse(Console.ReadLine(),out numbers[0]);
            }

            Console.WriteLine("Enter the number 2:");
            bool temp1 = int.TryParse(Console.ReadLine(),out numbers[1]);
            while(!temp1)
            {
                Console.WriteLine("Re-Enter the number 2:");
                temp = int.TryParse(Console.ReadLine(),out numbers[1]);
            }
            numbers[2]=numbers[0]/numbers[1];
            Console.WriteLine(numbers[2]);
        }
        catch(DivideByZeroException)
        {
            Console.WriteLine("Infinity");
        }
        catch(FormatException e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine(e.StackTrace);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine(e.StackTrace);
        } 
    }
}
