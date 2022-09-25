internal class Program
{
    private static void Main(string[] args)
    {
        Program P = new Program();

        // Array and params Array
        int[] ints = { 1, 2, 3 };
        P.Add(10, ints);
        Console.WriteLine();

        P.Add(100, new int[] { 1, 2, 3, 4 });
        //P.Add(1000, 1,2,3,4); //illegal because the array is not params

        Console.WriteLine();
        P.Add1(1000, 1, 2, 3); // legal because the array is params
        Console.ReadKey();
    }

    public void Add(int FirstNumber, int SecondNumber)
    // overloading. it's legal. Because there is no Add method with 2 int parameters
    {
        Console.WriteLine("Sum = {0} ", FirstNumber + SecondNumber);
    }

    public void Add(int FirstNumber, int SecondNumber, int ThirdNumber)
    // overloading. it's legal. Because there is no Add method with 3 int parameters
    {
        Console.WriteLine("Sum = {0} ", FirstNumber + SecondNumber + ThirdNumber);
    }

    public void Add(float FirstNumber, int SecondNumber)
    // overloading. it's legal. because there is no Add method with first parameter float and second parameter int
    {
        Console.WriteLine("Sum = {0} ", FirstNumber + SecondNumber);
    }

    public void Add(float FirstNumber, float SecondNumber)
    // overloading. it's legal. because there is no Add method with two float parameters
    {
        Console.WriteLine("Sum = {0} ", FirstNumber + SecondNumber);
    }

    public void Add(int FirstNumber, int SecondNumber, out int Sum)
    // overloading. it's legal. because there is no Add method with 1st & 2nd parameter int but 3rd parameter out int
    {
        Sum = FirstNumber + SecondNumber;
        Console.WriteLine("Sum = {0} ", Sum);

    }

    public void Add(int FirstNumber, int[] NumberArray)
    // overloading. it's legal. because there is no Add method with 1st parameter int & 2nd parameter array
    {
        foreach (var Number in NumberArray)
        {
            Console.WriteLine(Number + FirstNumber);
        }
    }

    // public void Add(int FirstNumber, params int[] NumberArray) // illegal because - There is a method - public void Add(int FirstNumber, int[] NumberArray) 

    //public static void Add(int FirstNumber, int SecondNumber) // illegal because - There is a method - public void Add(int FirstNumber, int SecondNumber)

    // public int Add(int FirstNumber, int SecondNumber) // illegal because - There is a method - public void Add(int FirstNumber, int SecondNumber)

    // void Add(int FirstNumber, int SecondNumber) // illegal because - There is a method - public void Add(int FirstNumber, int SecondNumber)

    public void Add1(int FirstNumber, params int[] NumberArray)
    {
        foreach (var Number in NumberArray)
        {
            Console.WriteLine(Number + FirstNumber);
        }
    }

    // public void Add1(int FirstNumber, int[] NumberArray) // illegal because - There is a method - public void Add1(int FirstNumber, params int[] NumberArray)

}

