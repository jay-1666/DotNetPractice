using System;

public class Practice2
{
    // 1
    public static void Q1_QuotientRemainder()
    {
        Console.Write("Enter number1: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number2: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        int quotient = number1 / number2;
        int remainder = number1 % number2;

        Console.WriteLine(
            $"The Quotient is {quotient} and Remainder is {remainder} of two numbers {number1} and {number2}"
        );
    }

    // 2
    public static void Q2_IntOperations()
    {
        Console.Write("Enter a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        int r1 = a + b * c;
        int r2 = a * b + c;
        int r3 = c + a / b;
        int r4 = a % b + c;

        Console.WriteLine(
            $"The results of Int Operations are {r1}, {r2}, {r3}, and {r4}"
        );
    }

    // 3
    public static void Q3_DoubleOperations()
    {
        Console.Write("Enter a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double r1 = a + b * c;
        double r2 = a * b + c;
        double r3 = c + a / b;
        double r4 = a % b + c;

        Console.WriteLine(
            $"The results of Double Operations are {r1}, {r2}, {r3}, and {r4}"
        );
    }

    // 4
    public static void Q4_CelsiusToFahrenheit()
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine(
            $"The {celsius} Celsius is {fahrenheit} Fahrenheit"
        );
    }

    // 5
    public static void Q5_FahrenheitToCelsius()
    {
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        double celsius = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine(
            $"The {fahrenheit} Fahrenheit is {celsius} Celsius"
        );
    }

    // 6
    public static void Q6_TotalIncome()
    {
        Console.Write("Enter salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter bonus: ");
        double bonus = Convert.ToDouble(Console.ReadLine());

        double income = salary + bonus;

        Console.WriteLine(
            $"The salary is INR {salary} and bonus is INR {bonus}. Hence Total Income is INR {income}"
        );
    }

    // 7
    public static void Q7_SwapNumbers()
    {
        Console.Write("Enter number1: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number2: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        int temp = number1;
        number1 = number2;
        number2 = temp;

        Console.WriteLine(
            $"The swapped numbers are {number1} and {number2}"
        );
    }

    // 8
    public static void Q8_TripDetails()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter from city: ");
        string fromCity = Console.ReadLine();

        Console.Write("Enter via city: ");
        string viaCity = Console.ReadLine();

        Console.Write("Enter destination city: ");
        string toCity = Console.ReadLine();

        Console.Write("Enter distance from source to via (miles): ");
        double fromToVia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter distance from via to destination (miles): ");
        double viaToFinal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter time taken (hours): ");
        double timeTaken = Convert.ToDouble(Console.ReadLine());

        double totalDistance = fromToVia + viaToFinal;
        double speed = totalDistance / timeTaken;

        Console.WriteLine(
            $"The results of the trip are: {name}, {totalDistance} miles, {speed} miles/hour"
        );
    }

    // 9
    public static void Q9_AthleteRounds()
    {
        Console.Write("Enter side1 (meters): ");
        double s1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side2 (meters): ");
        double s2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side3 (meters): ");
        double s3 = Convert.ToDouble(Console.ReadLine());

        double perimeter = s1 + s2 + s3;
        double rounds = 5000 / perimeter;

        Console.WriteLine(
            $"The total number of rounds the athlete will run is {rounds} to complete 5 km"
        );
    }

    // 10
    public static void Q10_ChocolatesDistribution()
    {
        Console.Write("Enter number of chocolates: ");
        int chocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of children: ");
        int children = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(
            $"The number of chocolates each child gets is {chocolates / children} and the number of remaining chocolates is {chocolates % children}"
        );
    }

    // 11
    public static void Q11_SimpleInterest()
    {
        Console.Write("Enter principal: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter rate: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter time: ");
        double time = Convert.ToDouble(Console.ReadLine());

        double interest = (principal * rate * time) / 100;

        Console.WriteLine(
            $"The Simple Interest is {interest} for Principal {principal}, Rate of Interest {rate} and Time {time}"
        );
    }

    // 12 
    public static void Q12_PoundsToKg()
    {
        Console.Write("Enter weight in pounds: ");
        double pounds = Convert.ToDouble(Console.ReadLine());

        double kg = pounds / 2.2;

        Console.WriteLine(
            $"The weight of the person in pounds is {pounds} and in kg is {kg}"
        );
    }
}
