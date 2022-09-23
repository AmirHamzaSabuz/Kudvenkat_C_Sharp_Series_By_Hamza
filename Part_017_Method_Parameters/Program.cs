
using System.Diagnostics.CodeAnalysis;
using System.Xml.Schema;

public class Program
{
    public static void Main(string[] args)
    {
        int i = 0;
        ValueType(i);  // Pass By Value
        Console.WriteLine("Pass By Value : i = {0}", i);

        Console.WriteLine();

        int k = 0;
        ReferenceType(ref k); // Pass By Reference
        Console.WriteLine("Pass By Reference : k = {0}", k);

        Console.WriteLine();

        int total = 0;
        int mul = 0;

        Calculate(10, 20, out total, out mul);
        Console.WriteLine("total = " + total + " and muliply = " + mul);

        Console.WriteLine();

        int[] MyNumbers = new int[3];

        MyNumbers[0] = 101;
        MyNumbers[1] = 102;
        MyNumbers[2] = 103;

        ParamsMethod(MyNumbers);
        Console.WriteLine();

        ParamsMethod();
        Console.WriteLine();

        ParamsMethod(1, 2, 3, 4, 5, 6, 7);
        Console.WriteLine();
        ParamsMethod(1, 2, 3, 4, 5);

        Console.ReadKey();
    }

    //Pass By Value
    public static void ValueType(int j)
    {
        j = 100;
    }


    //Pass By Reference
    public static void ReferenceType(ref int j)
    {
        j = 100;
    }

    // out Parameters
    public static void Calculate(int fn, int sn, out int sum, out int multiply)
    {
        sum = fn + sn;
        multiply = fn * sn;
    }

    //Parameter array with params

    /*
     * public static void ParamsMethod(params int[] Numbers, params string[] Names) // illegal! wrong!
     * public static void ParamsMethod(params int[] Numbers, int x) // illegal! wrong!
     * public static void ParamsMethod(int x, params int[] Numbers) // ok
     * params array will be the last one
    */

    public static void ParamsMethod(params int[] Numbers)
    {
        Console.WriteLine("There are {0} elements", Numbers.Length);
        foreach (int number in Numbers)
        { 
            Console.WriteLine(number);
        }
    }

}