using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int zero = 1;
        // int count = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (zero != 0)
        {
            Console.Write("Enter number: ");
            zero = int.Parse(Console.ReadLine());
            if (zero!= 0)
            {
                numbers.Add(zero);
            }
            // count = count ++;
        }
        int sum = 0;
        foreach (int number in numbers)
        {    
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}.");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}.");

    }
}