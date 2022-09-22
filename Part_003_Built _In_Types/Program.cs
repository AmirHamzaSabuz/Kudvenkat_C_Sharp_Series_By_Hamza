class Program
{
    static void Main(string[] args)
    {
        char c1 = '1';
        char c2 = 'A';

        if (char.IsDigit(c1))
        {
            Console.WriteLine("c1 is digit. value is " + c1);
        }
        if (char.IsLetter(c2))
        {
            Console.WriteLine("c2 is letter. value is " + c2);
        }

        Console.WriteLine();

        Console.WriteLine("bool.TrueString is {0} ", bool.TrueString);
        Console.WriteLine("bool.FalseString is {0} ", bool.FalseString);

        Console.WriteLine();

        Console.WriteLine("sbyte.MinValue {0} ", sbyte.MinValue);
        Console.WriteLine("sbyte.MaxValue {0} ", sbyte.MaxValue);

        Console.WriteLine();

        Console.WriteLine("byte.MinValue {0} ", byte.MinValue);
        Console.WriteLine("byte.MaxValue {0} ", byte.MaxValue);

        Console.WriteLine();

        Console.WriteLine("short.MinValue {0} ", short.MinValue);
        Console.WriteLine("short.MaxValue {0} ", short.MaxValue);

        Console.WriteLine();

        Console.WriteLine("ushort.MinValue {0} ", ushort.MinValue);
        Console.WriteLine("ushort.MaxValue {0} ", ushort.MaxValue);

        Console.WriteLine();

        Console.WriteLine("int.MinValue {0} ", int.MinValue);
        Console.WriteLine("int.MaxValue {0} ", int.MaxValue);

        Console.WriteLine();

        Console.WriteLine("uint.MinValue {0} ", uint.MinValue);
        Console.WriteLine("uint.MaxValue {0} ", uint.MaxValue);

        Console.WriteLine();

        Console.WriteLine("long.MinValue {0} ", long.MinValue);
        Console.WriteLine("long.MaxValue {0} ", long.MaxValue);

        Console.WriteLine();

        Console.WriteLine("ulong.MinValue" + " " + ulong.MinValue);
        Console.WriteLine("ulong.MaxValue" + " " + ulong.MaxValue);

        Console.WriteLine();


        Console.WriteLine("float.MinValue" + " " + float.MinValue);
        Console.WriteLine("float.MaxValue" + " " + float.MaxValue);

        Console.WriteLine();

        Console.WriteLine("double.MinValue" + " " + double.MinValue);
        Console.WriteLine("double.MaxValue" + " " + double.MaxValue);

        Console.WriteLine();

        int i = 2;
        Console.WriteLine("int i = " + i);

        double d = 2.22;
        Console.WriteLine("double d = " + d);

        bool t = true;
        Console.WriteLine("bool t = " + t);

        bool f = false;
        Console.WriteLine("bool f = " + f);

        /* Wrong code! Error
         * bool b = 0; // I can write only true or false.
        */

        Console.ReadKey();
    }
}