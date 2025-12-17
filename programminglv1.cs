using System;

public class Practice1
{
    // 1
    public static void Q1_AgeOfHarry()
    {
        int birthYear = 2000;
        int currentYear = 2024;
        int age = currentYear - birthYear;
        Console.WriteLine($"Harry's age in {currentYear} is {age}");
    }

    // 2
    public static void Q2_AveragePCM()
    {
        int maths = 94, physics = 95, chemistry = 96;
        double average = (maths + physics + chemistry) / 3.0;
        Console.WriteLine($"Sam’s average mark in PCM is {average}%");
    }

    // 3
    public static void Q3_KmToMilesFixed()
    {
        double km = 10.8;
        double miles = km / 1.6;
        Console.WriteLine($"The distance {km} km in miles is {miles}");
    }

    // 4
    public static void Q4_ProfitLoss()
    {
        int costPrice = 129;
        int sellingPrice = 191;
        int profit = sellingPrice - costPrice;
        double profitPercent = (profit * 100.0) / costPrice;

        Console.WriteLine(
            $"The Cost Price is INR {costPrice} and Selling Price is INR {sellingPrice}\n" +
            $"The Profit is INR {profit} and the Profit Percentage is {profitPercent}%"
        );
    }

    // 5
    public static void Q5_PensDistribution()
    {
        int pens = 14;
        int students = 3;
        Console.WriteLine(
            $"The Pen Per Student is {pens / students} and the remaining pen not distributed is {pens % students}"
        );
    }

    // 6
    public static void Q6_FeeDiscountFixed()
    {
        double fee = 125000;
        double discountPercent = 10;
        double discount = fee * discountPercent / 100;
        Console.WriteLine(
            $"The discount amount is INR {discount} and final discounted fee is INR {fee - discount}"
        );
    }

    // 7
    public static void Q7_EarthVolume()
    {
        double radius = 6378;
        double volumeKm = (4.0 / 3) * Math.PI * Math.Pow(radius, 3);
        double volumeMiles = volumeKm / Math.Pow(1.609, 3);

        Console.WriteLine(
            $"The volume of earth in cubic kilometers is {volumeKm} and cubic miles is {volumeMiles}"
        );
    }

    // 8
    public static void Q8_KmToMilesUserInput()
    {
        Console.Write("Enter km: ");
        double km = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"The total miles is {km / 1.6} mile for the given {km} km");
    }

    // 9
    public static void Q9_FeeDiscountUserInput()
    {
        Console.Write("Enter fee: ");
        double fee = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter discount percent: ");
        double percent = Convert.ToDouble(Console.ReadLine());

        double discount = fee * percent / 100;
        Console.WriteLine(
            $"The discount amount is INR {discount} and final discounted fee is INR {fee - discount}"
        );
    }

    // 10
    public static void Q10_HeightConversion()
    {
        Console.Write("Enter height in cm: ");
        double cm = Convert.ToDouble(Console.ReadLine());

        double inches = cm / 2.54;
        int feet = (int)(inches / 12);

        Console.WriteLine(
            $"Your Height in cm is {cm} while in feet is {feet} and inches is {inches % 12}"
        );
    }

    // 11
    public static void Q11_BasicCalculator()
    {
        Console.Write("Enter number1: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter number2: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(
            $"The addition, subtraction, multiplication and division value of 2 numbers {a} and {b} is " +
            $"{a + b}, {a - b}, {a * b}, {a / b}"
        );
    }

    // 12
    public static void Q12_TriangleArea()
    {
        Console.Write("Enter base: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter height: ");
        double h = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Area of triangle is {0.5 * b * h}");
    }

    // 13
    public static void Q13_SquareSide()
    {
        Console.Write("Enter perimeter: ");
        double p = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"The length of the side is {p / 4} whose perimeter is {p}");
    }

    // 14
    public static void Q14_FeetToYardsMiles()
    {
        Console.Write("Enter distance in feet: ");
        double feet = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(
            $"Distance is {feet / 3} yards and {(feet / 3) / 1760} miles"
        );
    }

    // 15
    public static void Q15_TotalPrice()
    {
        Console.Write("Enter unit price: ");
        double price = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter quantity: ");
        int qty = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(
            $"The total purchase price is INR {price * qty} if the quantity {qty} and unit price is INR {price}"
        );
    }

    // 16
    public static void Q16_Handshakes()
    {
        Console.Write("Enter number of students: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"The maximum number of handshakes is {(n * (n - 1)) / 2}");
    }
}
