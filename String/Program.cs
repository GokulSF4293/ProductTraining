using System;
using System.Linq;
namespace String;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the string");
        string name = Console.ReadLine();
        char[] name1 = name.ToCharArray();
        Console.WriteLine("Odd number of characters");
        for(int i=0;i<name1.Length;i++)
        {
            if(i%2 !=  0)
            {
                Console.WriteLine($"{name1[i]}");
            }
        }
        Console.WriteLine("Reverse String:");
        for(int i=name1.Length-1;i>-1;i--)
        {
            Console.Write($"{name1[i]}");
        }
        Console.WriteLine($"\nLenght of the above string : {name1.Length}");
        Console.WriteLine($"The capitalize of N in string:");
        for(int i=0;i<name1.Length;i++)
        {
            if(name1[i] ==  'n')
            {
                Console.Write($"N");
            }
            else
            {
                Console.Write($"{name1[i]}");
            }
        }

        Console.WriteLine("\nEnter the string");
        string string1 = Console.ReadLine();
        Console.WriteLine("Enter the string");
        string string2 = Console.ReadLine();
        string subString1 = string1.Substring(0,4);
        string subString2 = string2.Substring(string2.Length-3,3);
        Console.WriteLine($"Concatenate : ");
        Console.Write($"{subString1+subString2}");
        Console.WriteLine("\n");
        string array = "Chennai,Trichy,Mumbai";
        string[] newArray = array.Split(",");
        for(int i=0;i<newArray.Length;i++)
        {
            Console.WriteLine($"{newArray[i]}");
        }
    }
}