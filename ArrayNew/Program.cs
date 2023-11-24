using System;
using System.Linq;
using System.Reflection.Emit;
namespace ArrayNew;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of array");
        int size = int.Parse(Console.ReadLine());
        int[] numbers = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Enter the number");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int[] odd = numbers.Where(n=>n%2!=0).OrderByDescending(n=>n).ToArray();
        int[] even = numbers.Where(n=>n%2==0).OrderBy(n=>n).ToArray();
        Console.WriteLine("Odd Numbers in descending order");
        for(int i=0;i<odd.Length;i++)
        {
            Console.Write($"{odd[i]} ");
        }
        Console.WriteLine("\nEven numbers in ascending order");
        for(int i=0;i<even.Length;i++)
        {
            Console.Write($"{even[i]} ");
        }
    }
}
