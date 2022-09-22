public class Program
{
    public static void Main(string[] args)
    {
        //Assignment Operator Example. 
        // Single = is assignment operator
        int denominator = 10;
        int numerator = 20;

        //Arithmetic operator example
        //   +, -,  *, %, /
        int quotient = numerator / denominator;
        Console.WriteLine("quotient is " + quotient.ToString());

        Console.WriteLine();

        int remainder = numerator % denominator;
        Console.WriteLine("remainder is " + remainder);

        Console.WriteLine();

        //Comparison Operator
        //  ==, !=, <, <=, >, >=
        if (denominator == 10)
        {
            Console.WriteLine("denominator is " + 10);
        }

        Console.WriteLine();

        if (denominator != 20)
        {
            Console.WriteLine("denominator is not 20");
        }

        Console.WriteLine();

        //Conditional Operator 
        // &&, ||
        if (denominator == 10 && numerator == 20)
        {
            Console.WriteLine("Both conditions are true");
        }

        Console.WriteLine();

        if (denominator == 10 || numerator == 21)
        {
            Console.WriteLine("At least one condition is true");
        }

        Console.WriteLine();

        //Ternary Operator
        // ?:

        bool isDenominator10 = denominator == 10 ? true : false;
        Console.WriteLine("isDenominator10 " + isDenominator10);

        Console.WriteLine();

        Console.ReadKey();
    }
}