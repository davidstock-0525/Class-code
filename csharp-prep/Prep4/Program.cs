using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int number = 4;
        int sum = 0;
        int largest = 0;
        List <int> numbers = new List<int>();
        while (number != 0)
        {
        Console.Write("Please enter a number");
        string input = Console.ReadLine();
        number = int.Parse(input);
        if (largest < number)
            {
                largest = number;
            }
        numbers.Add(number);
        }
        foreach (int numero in numbers)
        {
            sum = sum + (numero);
        }
        int average = sum/(numbers.Count-1);
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"the average is {average}");
        Console.WriteLine($"The largest number is {largest}");
    }
}