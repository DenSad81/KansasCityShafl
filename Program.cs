using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int lenghtOfArray = 10;
        int[] array = new int[lenghtOfArray];

        CreateArray(array);
        Console.WriteLine();
        PrintArray(array);
        Console.WriteLine();
        ShafflArray(array);
        Console.WriteLine();
        PrintArray(array);
        Console.WriteLine();
    }

    static void ShafflArray(int[] array)
    {
        Random random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            int targetPositionInArray = random.Next(0, array.Length);
            int temp = array[targetPositionInArray];
            array[targetPositionInArray] = array[i];
            array[i] = temp;
        }
    }
    static void CreateArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
            array[i] = i;
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
            Console.Write(array[i] + "  ");
    }
}