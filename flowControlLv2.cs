using System;

public class Practice4
{
    //1
    public static void Q1_LeapYear()
    {
        Console.Write("Enter year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        Console.WriteLine($"Is the year {year} a leap year? {isLeapYear}");

    }

    //2
    public static void Q2_GradeCalculation()
    {
        Console.Write("Enter Physics marks: ");
        int physics = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Chemistry marks: ");
        int chemistry = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Maths marks: ");
        int maths = Convert.ToInt32(Console.ReadLine());

        int total = physics + chemistry + maths;
        double percentage = (total / 300.0) * 100;

        string grade;
        string remarks;

        if (percentage >= 80)
        {
            grade = "A";
            remarks = "Level 4, above agency-normalized standards";
        }
        else if (percentage >= 70)
        {
            grade = "B";
            remarks = "Level 3, at agency-normalized standards";
        }
        else if (percentage >= 60)
        {
            grade = "C";
            remarks = "Level 2, below but approaching agency-normalized standards";
        }
        else if (percentage >= 50)
        {
            grade = "D";
            remarks = "Level 1, well below agency-normalized standards";
        }
        else if (percentage >= 40)
        {
            grade = "E";
            remarks = "Level 1-, too below agency-normalized standards";
        }
        else
        {
            grade = "R";
            remarks = "Remedial standards";
        }

        Console.WriteLine("\n----- Result -----");
        Console.WriteLine($"Physics   : {physics}");
        Console.WriteLine($"Chemistry : {chemistry}");
        Console.WriteLine($"Maths     : {maths}");
        Console.WriteLine($"Average Percentage : {percentage}%");
        Console.WriteLine($"Grade : {grade}");
        Console.WriteLine($"Remarks : {remarks}");
    }

    //3
    public static void Q3_CheckPrimeNumber()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        bool isPrime = true;
        if (number <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
        {
            Console.WriteLine($"{number} is a Prime Number");
        }
        else
        {
            Console.WriteLine($"{number} is NOT a Prime Number");
        }
    }

    //4
    public static void Q4_FizzBuzz()
    {
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Please enter a positive integer");
            return;
        }

        for (int i = 1; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.Write("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.Write("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.Write("Buzz");
            }
            else
            {
                Console.Write(i);
            }
        }
    }

    //5
    public static void Q5_FizzBuzzWhile()
    {
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Please enter a positive integer");
            return;
        }

        int i = 1;
        while (i <= number)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }

            i++;
        }
    }

    //6
    public static void Q6_CalculateBMI()
    {
        Console.Write("Enter weight in kg: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter height in cm: ");
        double heightCm = Convert.ToDouble(Console.ReadLine());

        double heightMeter = heightCm / 100;

        double bmi = weight / (heightMeter * heightMeter);

        string status;

        if (bmi <= 18.4)
        {
            status = "Underweight";
        }
        else if (bmi <= 24.9)
        {
            status = "Normal";
        }
        else if (bmi <= 39.9)
        {
            status = "Overweight";
        }
        else
        {
            status = "Obese";
        }

        Console.WriteLine("\n----- BMI Result -----");
        Console.WriteLine($"Weight : {weight} kg");
        Console.WriteLine($"Height : {heightCm} cm");
        Console.WriteLine($"BMI    : {bmi}");
        Console.WriteLine($"Status : {status}");
    }

    //7
    public static void Q7_YoungestAndTallestFriend()
    {
        Console.Write("Enter Amar's age: ");
        int amarAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Amar's height: ");
        double amarHeight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Akbar's age: ");
        int akbarAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Akbar's height: ");
        double akbarHeight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Anthony's age: ");
        int anthonyAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Anthony's height: ");
        double anthonyHeight = Convert.ToDouble(Console.ReadLine());

        string youngest;
        if (amarAge <= akbarAge && amarAge <= anthonyAge)
            youngest = "Amar";
        else if (akbarAge <= amarAge && akbarAge <= anthonyAge)
            youngest = "Akbar";
        else
            youngest = "Anthony";

        string tallest;
        if (amarHeight >= akbarHeight && amarHeight >= anthonyHeight)
            tallest = "Amar";
        else if (akbarHeight >= amarHeight && akbarHeight >= anthonyHeight)
            tallest = "Akbar";
        else
            tallest = "Anthony";

        Console.WriteLine("\n----- Result -----");
        Console.WriteLine($"The youngest friend is {youngest}");
        Console.WriteLine($"The tallest friend is {tallest}");
    }

    //8
    public static void Q8_GreatestFactor()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int greatestFactor = 1;

        for (int i = number - 1; i >= 1; i--)
        {
            if (number % i == 0)
            {
                greatestFactor = i;
                break;
            }
        }

        Console.WriteLine($"The greatest factor of {number} other than itself is {greatestFactor}");
    }

    //9

    public static void Q9_PowerOfNumber()
    {
        Console.Write("Enter the base number: ");
        int baseNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the exponent: ");
        int exponent = Convert.ToInt32(Console.ReadLine());
        int result = 1;
        for (int i = 1; i <= exponent; i++)
        {
            result *= baseNumber;
        }
        Console.WriteLine($"{baseNumber} raised to the power of {exponent} is {result}");

    }

    //10
    public static void Q10_FactorsOfNumber()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Factors of {number} are:");
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    //11
    public static void Q11_MultiplesOfNumber()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Multiples of {number} up to 100 are:");
        for (int i = 1; i <= 100; i++)
        {
            if (i % number == 0)
            {
                Console.WriteLine(i);
            }
        }

    }
        
}