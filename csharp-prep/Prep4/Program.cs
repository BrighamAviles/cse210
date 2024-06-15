using System;

class Program
{
    static void Main(string[] args)
        {
        List<int> numbers = new List<int>();
        int input = -1; 

        Console.WriteLine("Enter a series of numbers. Enter 0 to stop:");

        while (input != 0)
        {
            Console.Write("Enter a number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine("Sum of the numbers: " + sum);

        double average = (double)sum / numbers.Count;
        Console.WriteLine("Average of the numbers: " + average);

        int maxNumber = numbers[0];
        foreach (int number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }
        Console.WriteLine("Maximum number: " + maxNumber);
    }
}
