public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Even Numbers from 0 to 10");
        //static method called in static method. Use the Class Name
        Program.EvenNumbers(10);
        Console.WriteLine("");

        
        Console.WriteLine("Even Numbers from 0 to 10");
        //static method called in static method. For same class Class Name is not used.
        EvenNumbers(10);
        Console.WriteLine("");

        Program p = new Program();

        
        Console.WriteLine("Odd Numbers from 0 to 10");
        // Instance method or non static method called in static method. Use object.
        p.OddNumbers(10);
        Console.WriteLine("");

        //Add method is int type. There is no print order in Add method.
        Console.WriteLine("Sum of 10 & 20 is {0} ", p.Add(10,20));
        Console.WriteLine("");

        //Multiply method is void type. There is a print order in Multiply method.
        p.Multiply(10,20);


        Console.ReadKey();
        //
    }

    public static void EvenNumbers(int target) 
    {
        for (int i = 0; i <= target; i += 2)
        { 
            Console.WriteLine(i);
        }
    }

    public void OddNumbers(int target) 
    {
        
        for (int i = 1; i <= target; i += 2)
        {
            Console.WriteLine(i);
        }
    }

    public int Add(int a, int b)
    { 
        return a + b;
    }

    public void Multiply(int a, int b)
    {
        Console.WriteLine("Product of the two numbers is {0} ",a*b);
    }
}