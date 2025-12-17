using System;

public class Practice5
{
    //1
    public static void Q1_ArmstrongNumber()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int originalNumber = number;
        int sumOfCubes = 0;
        while (number > 0)
        {
            int digit = number % 10;
            sumOfCubes += digit * digit * digit;
            number /= 10;
        }
        if (sumOfCubes == originalNumber)
        {
            Console.WriteLine($"{originalNumber} is an Armstrong number.");
        }
        else
        {
            Console.WriteLine($"{originalNumber} is not an Armstrong number.");
        }

    }

    //2
    public static void Q2_NumberOfDigits()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        while (number != 0)
        {
            number /= 10;
            count++;
        }
        Console.WriteLine($"The number of digits is: {count}");

    }

    //3
    public static void Q3_HarshadNumber()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int originalNumber = number;
        int sumOfDigits = 0;
        while (number != 0)
        {
            int digit = number % 10;
            sumOfDigits += digit;
            number /= 10;
        }
        if (originalNumber % sumOfDigits == 0)
        {
            Console.WriteLine($"{originalNumber} is a Harshad number.");
        }
        else
        {
            Console.WriteLine($"{originalNumber} is not a Harshad number.");
        }
    }

    //4
    public static void Q4_AbundantNumber()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int sumOfDivisors = 0;
        for (int i = 1; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                sumOfDivisors += i;
            }
        }
        if (sumOfDivisors > number)
        {
            Console.WriteLine($"{number} is an Abundant number.");
        }
        else
        {
            Console.WriteLine($"{number} is not an Abundant number.");
        }
    }
}