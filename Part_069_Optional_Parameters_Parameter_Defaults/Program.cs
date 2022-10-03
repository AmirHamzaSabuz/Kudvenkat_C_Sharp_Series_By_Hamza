internal class Program
{
    private static void Main(string[] args)
    {
        AddNumbers(10, 20, new int[] { 30, 40 });

        AddNumbers(10, 20);

        Console.WriteLine();

        Test3(1, 2); // a = 1, b = 2, c = 20

        Console.WriteLine();

        Test3(1, c:3); // a = 1, b = 10, c = 3

        Console.ReadKey();
    }

    public static void AddNumbers(int firstNumber, int secondNumber, int[] restOfNumbers = null)
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

    /*
    //optional parameters must appear after all required parameters
    public static void Test1(int a = 10, int b, int c) // Error
    {
        // Do something
    }
    */ 

    public static void Test2(int b, int c, int a = 10)
    {
        // Do something
    }

    public static void Test3(int a, int b = 10, int c = 20)
    {
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("c = " + c);
    }


}