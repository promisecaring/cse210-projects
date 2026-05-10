using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Collect numbers from the user
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);

        // Calculate sum, largest number, and smallest positive number
        int sum = 0;
        int largest = numbers[0];
        int smallestPositive = int.MaxValue;

        foreach (int num in numbers)
        {
            sum += num;

            if (num > largest)
            {
                largest = num;
            }

            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num;
            }
        }

        // Calculate average
        double average = (double)sum / numbers.Count;

        // Display results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

        // Display smallest positive number if one exists
        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        // Sort and display the list
        numbers.Sort();

        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}