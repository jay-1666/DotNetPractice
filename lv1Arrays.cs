using System;

public class Practice6
{
    // 1
    public static void Q1_VotingEligibilityArray()
    {
        int[] ages = new int[10];

        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write($"Enter age of student {i + 1}: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());
        }

        foreach (int age in ages)
        {
            if (age < 0)
                Console.WriteLine("Invalid age");
            else if (age >= 18)
                Console.WriteLine($"The student with the age {age} can vote.");
            else
                Console.WriteLine($"The student with the age {age} cannot vote.");
        }
    }

    // 2
    public static void Q2_NumberCheckArray()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        foreach (int num in numbers)
        {
            if (num > 0)
                Console.WriteLine(num % 2 == 0 ? $"{num} is Positive Even" : $"{num} is Positive Odd");
            else if (num < 0)
                Console.WriteLine($"{num} is Negative");
            else
                Console.WriteLine("Zero");
        }

        int first = numbers[0];
        int last = numbers[numbers.Length - 1];

        if (first == last)
            Console.WriteLine("First and last elements are equal");
        else if (first > last)
            Console.WriteLine("First element is greater than last");
        else
            Console.WriteLine("First element is less than last");
    }

    // 3
    public static void Q3_MultiplicationTable()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] table = new int[10];

        for (int i = 1; i <= 10; i++)
        {
            table[i - 1] = number * i;
        }

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} * {i} = {table[i - 1]}");
        }
    }

    // 4
    public static void Q4_StoreNumbersAndSum()
    {
        double[] numbers = new double[10];
        double total = 0.0;
        int index = 0;

        while (true)
        {
            Console.Write("Enter number: ");
            double input = Convert.ToDouble(Console.ReadLine());

            if (input <= 0 || index == 10)
                break;

            numbers[index++] = input;
        }

        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(numbers[i]);
            total += numbers[i];
        }

        Console.WriteLine($"Total sum is {total}");
    }

    // 5
    public static void Q5_MultiplicationTable6to9()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] results = new int[4];
        int idx = 0;

        for (int i = 6; i <= 9; i++)
        {
            results[idx++] = number * i;
        }

        idx = 0;
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine($"{number} * {i} = {results[idx++]}");
        }
    }

    // 6
    public static void Q6_MeanHeight()
    {
        double[] heights = new double[11];
        double sum = 0;

        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write($"Enter height of player {i + 1}: ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
            sum += heights[i];
        }

        Console.WriteLine($"Mean height of players is {sum / heights.Length}");
    }

    // 7
    public static void Q7_OddEvenArrays()
    {
        Console.Write("Enter a natural number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Invalid input");
            return;
        }

        int[] odd = new int[number / 2 + 1];
        int[] even = new int[number / 2 + 1];
        int oddIndex = 0, evenIndex = 0;

        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
                even[evenIndex++] = i;
            else
                odd[oddIndex++] = i;
        }

        Console.WriteLine("Odd Numbers:");
        for (int i = 0; i < oddIndex; i++)
            Console.Write(odd[i] + " ");

        Console.WriteLine("\nEven Numbers:");
        for (int i = 0; i < evenIndex; i++)
            Console.Write(even[i] + " ");
    }

    // 8
    public static void Q8_FactorsArray()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int maxFactor = 10;
        int[] factors = new int[maxFactor];
        int index = 0;

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                if (index == maxFactor)
                {
                    maxFactor *= 2;
                    int[] temp = new int[maxFactor];
                    Array.Copy(factors, temp, factors.Length);
                    factors = temp;
                }
                factors[index++] = i;
            }
        }

        Console.WriteLine("Factors are:");
        for (int i = 0; i < index; i++)
            Console.Write(factors[i] + " ");
    }

    // 9
    public static void Q9_Copy2Dto1D()
    {
        Console.Write("Enter rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter columns: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[rows, cols];
        int[] array = new int[rows * cols];
        int index = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Enter element [{i},{j}]: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                array[index++] = matrix[i, j];
            }
        }

        Console.WriteLine("1D Array:");
        foreach (int val in array)
            Console.Write(val + " ");
    }

    // 10
    public static void Q10_FizzBuzzArray()
    {
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Invalid input");
            return;
        }

        string[] result = new string[number + 1];

        for (int i = 1; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                result[i] = "FizzBuzz";
            else if (i % 3 == 0)
                result[i] = "Fizz";
            else if (i % 5 == 0)
                result[i] = "Buzz";
            else
                result[i] = i.ToString();
        }

        for (int i = 1; i <= number; i++)
            Console.WriteLine($"Position {i} = {result[i]}");
    }
}
