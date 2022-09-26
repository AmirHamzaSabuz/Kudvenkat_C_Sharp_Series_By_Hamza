internal class Program 
{
    private static void Main(string[] args)
    {
        
        
    }


}

public abstract class Customer 
{
    int Id;
    public void Print()
    {
        Console.WriteLine("Print");
    }
}

public interface ICustomer
{
    void Print();
    //public void Print(); // We should not use the modifier public.

    //void Print1() { } // interface members should not have a definition.

    /* interface can not have fields.
    int Id; // illegal. Error. Wrong code.
    */
}

// Abstract classes can have implementations for some of its members(method),
// but the interface can't have implementation for any of its members.

// Interfaces can Not have fields where as an abstract class can have fields.

// An interface can inherit from another interface only and can not inherit from an abstract class,
// where as an abstract class can inherit from another abstract class or another interface.

// A class can inherit from multiple interfaces at the same time,
// where as a class can not inherit from multiple classes at the same time.

// Abstract class members can have acccess modifiers 
// where as instance members can not have access modifires.
