namespace Assignment1_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a simple console application and declare basic datatypes
            //like int, float, decimal, double and print their min and max values.
            int maxInteger, minInteger;
            float maxFloat, minFloat;
            decimal maxDecimal, minDecimal;
            double maxDouble, minDouble;
            maxInteger = int.MaxValue;
            minInteger = int.MinValue;
            maxFloat = float.MaxValue;
            minFloat = float.MinValue;
            maxDecimal = decimal.MaxValue;
            minDecimal = decimal.MinValue;
            maxDouble = double.MaxValue;
            minDouble = double.MinValue;
            Console.WriteLine("The maximum value for an integer is: " +maxInteger);
            Console.WriteLine("The minimum value for an integer is: " +minInteger);
            Console.WriteLine("The maximum value for a float is: " +maxFloat);
            Console.WriteLine("The minimum value for a float is: " +minFloat);
            Console.WriteLine("The maximum value for a decimal is: " +maxDecimal);
            Console.WriteLine("The minimum value for a decimal is:  " +minDecimal);
            Console.WriteLine("The maximum value for a double is: " +maxDouble);
            Console.WriteLine("The minimum value for a double is: " +minDouble);
        }
    }
}
