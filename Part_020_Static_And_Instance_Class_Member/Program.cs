class Circle 
{
    static float _PI; 
    int _radius;

    // when we create object, at first static constructor will be called then non static constructor will be called 
    // public static Circle() // illegal or Wrong. Access modifier can not be used.
    static Circle() 
    {
        Circle._PI = 3.141F; // for static, use Class name.
        Console.WriteLine("Static constructor called. Value of PI = " + _PI);
        Console.WriteLine();
    }

    public Circle(int radius)
    {
       this._radius = radius; // for non static, use this keyword
        Console.WriteLine("Instance constructor called");
    }
    public float CalculateArea() 
    {
        return Circle._PI * this._radius * this._radius;
    }
    public static void Print()
    {
        Console.WriteLine("Static method Print() is called");
    }
}

class Test
{
    public static float P;

    static Test()
    {
        // P = 3.141F;
        Test.P = 3.141F;
    }
    
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine();

        Circle c1 = new Circle(5);
        float area = c1.CalculateArea();
        Console.WriteLine("Area is {0} ", area);

        Console.WriteLine();

        Circle c2 = new Circle(6);
        float area2 = c2.CalculateArea();
        Console.WriteLine("Area is {0} ", area2);
        Console.WriteLine();

        Circle.Print(); // Class Name is used. Not object name.

        Console.WriteLine();

        Console.WriteLine("We did't create an object. We used a static field and static constructor autometically called. P = " + Test.P);

        Console.ReadKey();
    }
}