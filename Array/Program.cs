using System;
namespace Array;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of array");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        for(int i=0;i<size;i++)
        {
            Console.WriteLine("Enter the number");
            array[i] = int.Parse(Console.ReadLine());
        }
        for(int i=0;i<size-1;i++)
        {
            for(int k=i+1;k<size;k++)
            {
                if(array[i]>array[k])
                {
                    int temp = array[i];
                    array[i]=array[k];
                    array[k]=temp;
                }
            }
        }
        for(int j=0;j<size;j++)
        {
            Console.WriteLine($"{array[j]}");
        }
    }
}