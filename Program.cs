using System;
using System.Numerics;

class MinMaxComparison
{
    static void Main()
    {
        // Integer type
        int num1 = -3, num2 = 53;
        int product = num1 * num2;
        int sum = num1 + num2;
        FindMinMaxAndCompare(num1, num2);

        // Short type
        short short1 = -300, short2 = 5000;
        short shortProduct = (short)(short1 * short2);
        short shortSum = (short)(short1 + short2);
        FindMinMaxAndCompare(short1, short2);

        // Long type
        long long1 = -123456789L, long2 = 987654321L;
        long longProduct = long1 * long2;
        long longSum = long1 + long2;
        FindMinMaxAndCompare(long1, long2);

        // Float type
        float float1 = -3.14f, float2 = 2.718f;
        float floatProduct = float1 * float2;
        float floatSum = float1 + float2;
        FindMinMaxAndCompare(float1, float2);

        // Double type
        double double1 = -123.456, double2 = 789.123;
        double doubleProduct = double1 * double2;
        double doubleSum = double1 + double2;
        FindMinMaxAndCompare(double1, double2);

        // Decimal type
        decimal decimal1 = -98765.4321m, decimal2 = 12345.6789m;
        decimal decimalProduct = decimal1 * decimal2;
        decimal decimalSum = decimal1 + decimal2;
        FindMinMaxAndCompare(decimal1, decimal2);
    }

    static void FindMinMaxAndCompare<T>(T a, T b) where T : IComparable<T>
    {
        T min = (a.CompareTo(b) < 0) ? a : b;
        T max = (a.CompareTo(b) > 0) ? a : b;
        bool isGreater = a.CompareTo(b) > 0;

        Console.WriteLine($"The max of {a} and {b} is {max}. The min of {a} and {b} is {min}.");
        Console.WriteLine($"{a} is greater than {b}, {isGreater}");
    }
}