internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Calculator.Add1(10, 15));

        Console.WriteLine(Calculator.Add1(new List<int>() { 1, 2, 3 }));

        Console.WriteLine(Calculator.Add2(10, 15));

        Console.WriteLine(Calculator.Add2(new List<int>() { 1, 2, 3, 4 }));

        /*
         Console.WriteLine(Calculator.Add3(10, 15)); // Compile time Error
        */

        Console.WriteLine( Calculator.Add3(new List<int>() { 1, 2, 3, 4, 5 }));
    }
}

public class Calculator
{
    [Obsolete] // attribute
    public static int Add1(int FirstNumber, int SecondNumber)
    {
        return FirstNumber + SecondNumber;
    }
    public static int Add1(List<int> Numbers)
    {
        int Sum = 0;
        foreach (int Number in Numbers)
        {
            Sum = Sum + Number;
        }
        return Sum;
    }


    [Obsolete("Use Add(List<int> Numbers) instead")] // attribute
    public static int Add2(int FirstNumber, int SecondNumber)
    {
        return FirstNumber + SecondNumber;
    }
    public static int Add2(List<int> Numbers)
    {
        int Sum = 0;
        foreach (int Number in Numbers)
        {
            Sum = Sum + Number;
        }
        return Sum;
    }

    [Obsolete("Use Add(List<int> Numbers) instead", true)]
    public static int Add3(int FirstNumber, int SecondNumber)
    {
        return FirstNumber + SecondNumber;
    }
    public static int Add3(List<int> Numbers)
    {
        int Sum = 0;
        foreach (int Number in Numbers)
        {
            Sum = Sum + Number;
        }
        return Sum;
    }
}

/*
 *Attributes allow you to add declarative information to your programs
 * visual studio, shows a green squiggly line under the  Add(int FirstNumber, int SecondNumber) method. 
 * If you hover the mouse over the squiggly line, you should see the warning message.
 */