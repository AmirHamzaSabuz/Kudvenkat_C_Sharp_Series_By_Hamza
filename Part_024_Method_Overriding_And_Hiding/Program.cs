
internal class Program
{
    private static void Main(string[] args)
    {
        BaseClass1 B1 = new DerivedClass1(); //Base class reference of child class object
        B1.Print(); // using override // output: I am a derived class print method

        BaseClass2 B2 = new DerivedClass2(); //Base class reference of child class object
        B2.Print(); // using new  // output: I am a base class print method

        Console.WriteLine();

        DerivedClass1 D1 = new DerivedClass1();
        D1.Print(); // using override // output: I am a derived class print method
        DerivedClass2 D2 = new DerivedClass2();
        D2.Print(); // using new  // output: I am a derived class print method


        Console.ReadKey();
    }
}

public class BaseClass1
{
    public virtual void Print()
    {
        Console.WriteLine("I am a base class print method");
    }
}

public class DerivedClass1 : BaseClass1
{
    public override void Print()
    {
        Console.WriteLine("I am a derived class print method");
    }
}

public class BaseClass2
{
    public void Print()
    {
        Console.WriteLine("I am a base class print method");
    }
}

public class DerivedClass2 : BaseClass2
{
    public new void Print()
    {
        Console.WriteLine("I am a derived class print method");
    }
}
