using System;

namespace Operators_Fulton_Christoper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Intitializes an integer that multiplies two integers
            int intMult = 6 * 45;
            // Intitialized an integer that adds integers
            int intAdd = 55 + 66;

            // Prints the maxium and minimum of the two integer variables
            Console.WriteLine($"The max of {intMult} and {intAdd} is {Math.Max(intMult, intAdd)}." +
                $"The min of the two is {Math.Min(intMult, intAdd)}");
            
            // Intitializes boolean to see if intMult is grater than intAdd 
            bool isintGreater = intMult > intAdd;
            // Prints if intMult is greater than intAdd
            Console.WriteLine($"{intMult} is greater than {intAdd}, {isintGreater}.");


            // Intitializes an short that multiplies two shorts
            short shortMult = 6 * 45;
            // Intitialized an short that adds shorts
            short shortAdd = 55 + 66;

            // Prints the maxium and minimum of the two short variables
            Console.WriteLine($"The max of {shortMult} and {shortAdd} is {Math.Max(shortMult, shortAdd)}." +
                $"The min of the two is {Math.Min(shortMult, shortAdd)}");

            // Intitializes boolean to see if shortMult is grater than shortAdd 
            bool isshortGreater = shortMult > shortAdd;
            // Prints if shortMult is greater than shortAdd
            Console.WriteLine($"{shortMult} is greater than {shortAdd}, {isshortGreater}.");


            // Intitializes an long that multiplies two longs
            long longMult = 6 * 45;
            // Intitialized an long that adds longs
            long longAdd = 55 + 66;

            // Prints the maxium and minimum of the two long variables
            Console.WriteLine($"The max of {longMult} and {longAdd} is {Math.Max(longMult, longAdd)}." +
                $"The min of the two is {Math.Min(longMult, longAdd)}");

            // Intitializes boolean to see if longMult is grater than longAdd 
            bool islongGreater = longMult > longAdd;
            // Prints if longMult is greater than longAdd
            Console.WriteLine($"{longMult} is greater than {longAdd}, {islongGreater}.");



            // Intitializes an float that multiplies two floats
            float floatMult = 6.5f * 45.24f;
            // Intitialized an float that adds floats
            float floatAdd = 55.35f + 66.15f;

            // Prints the maxium and minimum of the two float variables
            Console.WriteLine($"The max of {floatMult} and {floatAdd} is {Math.Max(floatMult, floatAdd)}." +
                $"The min of the two is {Math.Min(floatMult, floatAdd)}");

            // Intitializes boolean to see if floatMult is grater than floatAdd 
            bool isfloatGreater = floatMult > floatAdd;
            // Prints if floatMult is greater than floatAdd
            Console.WriteLine($"{floatMult} is greater than {floatAdd}, {isfloatGreater}.");


            // Intitializes an double that multiplies two doubles
            double doubleMult = 6.69 * 45.58;
            // Intitialized an double that adds doubles
            double doubleAdd = 55.48 + 66.15;

            // Prints the maxium and minimum of the two double variables
            Console.WriteLine($"The max of {doubleMult} and {doubleAdd} is {Math.Max(doubleMult, doubleAdd)}." +
                $"The min of the two is {Math.Min(doubleMult, doubleAdd)}");

            // Intitializes boolean to see if doubleMult is grater than doubleAdd 
            bool isdoubleGreater = doubleMult > doubleAdd;
            // Prints if doubleMult is greater than doubleAdd
            Console.WriteLine($"{doubleMult} is greater than {doubleAdd}, {isdoubleGreater}.");


            // Intitializes an decimal that multiplies two decimals
            decimal decimalMult = (decimal)(6.25 * 45.15);
            // Intitialized an decimal that adds decimals
            decimal decimalAdd = (decimal)(55.66 + 66.55);

            // Prints the maxium and minimum of the two decimal variables
            Console.WriteLine($"The max of {decimalMult} and {decimalAdd} is {Math.Max(decimalMult, decimalAdd)}." +
                $"The min of the two is {Math.Min(decimalMult, decimalAdd)}");

            // Intitializes boolean to see if decimalMult is grater than decimalAdd 
            bool isdecimalGreater = decimalMult > decimalAdd;
            // Prints if decimalMult is greater than decimalAdd
            Console.WriteLine($"{decimalMult} is greater than {decimalAdd}, {isdecimalGreater}.");
        }
    }
}
