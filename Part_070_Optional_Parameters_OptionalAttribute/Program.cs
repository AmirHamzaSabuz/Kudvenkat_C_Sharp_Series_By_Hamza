using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        AddNumbers1(10, 20, new int[] { 30, 40 });

        AddNumbers1(10, 20);

        AddNumbers2(10, 20, new int[] { 30, 40 });

        AddNumbers2(10, 20);


    }

    public static void AddNumbers1(int firstNumber, int secondNumber, [Optional] int[] restOfNumbers)
    {
        int result = firstNumber + secondNumber;

        if (restOfNumbers != null)
        {
            foreach (int i in restOfNumbers)
            {
                result += i;
            }
        }

        Console.WriteLine("Result = " + result);
    }

    public static void AddNumbers2(int firstNumber, int secondNumber, [OptionalAttribute] int[] restOfNumbers)
    {
        int result = firstNumber + secondNumber;

        if (restOfNumbers != null)
        {
            foreach (int i in restOfNumbers)
            {
                result += i;
            }
        }

        Console.WriteLine("Result = " + result);
    }
}