using System;

public class Practice3
{
    // 1
    public static void Q1_DivisibleBy5()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        bool result = number % 5 == 0;
        Console.WriteLine($"Is the number {number} divisible by 5? {result}");
    }

    // 2
    public static void Q2_FirstIsSmallest()
    {
        Console.Write("Enter number1: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number2: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number3: ");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Is the first number the smallest? {a < b && a < c}");
    }

    // 3
    public static void Q3_LargestAmongThree()
    {
        Console.Write("Enter number1: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number2: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number3: ");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Is the first number the largest? {a > b && a > c}");
        Console.WriteLine($"Is the second number the largest? {b > a && b > c}");
        Console.WriteLine($"Is the third number the largest? {c > a && c > b}");
    }

    // 4
    public static void Q4_NaturalNumberSum()
    {
        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n > 0)
        {
            int sum = n * (n + 1) / 2;
            Console.WriteLine($"The sum of {n} natural numbers is {sum}");
        }
        else
        {
            Console.WriteLine($"The number {n} is not a natural number");
        }
    }

    // 5
    public static void Q5_VotingEligibility()
    {
        Console.Write("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18)
            Console.WriteLine($"The person's age is {age} and can vote.");
        else
            Console.WriteLine($"The person's age is {age} and cannot vote.");
    }

    // 6
    public static void Q6_NumberType()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
            Console.WriteLine("Positive");
        else if (number < 0)
            Console.WriteLine("Negative");
        else
            Console.WriteLine("Zero");
    }

    // 7
    public static void Q7_SpringSeason()
    {
        Console.Write("Enter month: ");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter day: ");
        int day = Convert.ToInt32(Console.ReadLine());

        bool isSpring =
            (month == 3 && day >= 20) ||
            (month == 4) ||
            (month == 5) ||
            (month == 6 && day <= 20);

        Console.WriteLine(isSpring ? "Its a Spring Season" : "Not a Spring Season");
    }

    // 8
    public static void Q8_CountdownWhile()
    {
        Console.Write("Enter countdown start number: ");
        int counter = Convert.ToInt32(Console.ReadLine());

        while (counter >= 1)
        {
            Console.WriteLine(counter);
            counter--;
        }
    }

    // 9
    public static void Q9_CountdownFor()
    {
        Console.Write("Enter countdown start number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = n; i >= 1; i--)
            Console.WriteLine(i);
    }

    // 10
    public static void Q10_SumUntilZero()
    {
        double total = 0;
        double input;

        while (true)
        {
            Console.Write("Enter number (0 to stop): ");
            input = Convert.ToDouble(Console.ReadLine());

            if (input == 0)
                break;

            total += input;
        }

        Console.WriteLine($"Total sum is {total}");
    }

    // 11
    public static void Q11_SumUntilNegative()
    {
        double total = 0;

        while (true)
        {
            Console.Write("Enter number: ");
            double input = Convert.ToDouble(Console.ReadLine());

            if (input <= 0)
                break;

            total += input;
        }

        Console.WriteLine($"Total sum is {total}");
    }

    // 12
    public static void Q12_SumCompareWhile()
    {
        Console.Write("Enter n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Not a natural number");
            return;
        }

        int sumLoop = 0, i = 1;
        while (i <= n)
        {
            sumLoop += i;
            i++;
        }

        int sumFormula = n * (n + 1) / 2;
        Console.WriteLine($"While loop sum = {sumLoop}, Formula sum = {sumFormula}");
    }

    // 13
    public static void Q13_SumCompareFor()
    {
        Console.Write("Enter n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Not a natural number");
            return;
        }

        int sum = 0;
        for (int i = 1; i <= n; i++)
            sum += i;

        Console.WriteLine($"Sum using for loop = {sum}, Formula = {n * (n + 1) / 2}");
    }

    // 14
    public static void Q14_FactorialWhile()
    {
        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Not a natural number");
            return;
        }

        int fact = 1, i = 1;
        while (i <= n)
        {
            fact *= i;
            i++;
        }

        Console.WriteLine($"Factorial of {n} is {fact}");
    }

    // 15
    public static void Q15_FactorialFor()
    {
        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Not a natural number");
            return;
        }

        int fact = 1;
        for (int i = 1; i <= n; i++)
            fact *= i;

        Console.WriteLine($"Factorial of {n} is {fact}");
    }

    // 16
    public static void Q16_OddEven()
    {
        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
            Console.WriteLine($"{i} is {(i % 2 == 0 ? "Even" : "Odd")}");
    }

    // 17
    public static void Q17_EmployeeBonus()
    {
        Console.Write("Enter salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter years of service: ");
        int years = Convert.ToInt32(Console.ReadLine());

        if (years > 5)
            Console.WriteLine($"Bonus amount is {salary * 0.05}");
        else
            Console.WriteLine("No bonus");
    }

    // 18
    public static void Q18_MultiplicationTable()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 6; i <= 9; i++)
            Console.WriteLine($"{number} * {i} = {number * i}");
    }
}
