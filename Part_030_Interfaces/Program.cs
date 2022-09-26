internal class Program
{
    private static void Main(string[] args)
    {
        Customer customer = new Customer();
        customer.Print();

        /* // Can not create an instacne of the abstract type or interface
        I3 i3 = new I3(); // Wrong code. Error
        */

        // We can not creat an instance of an interface, but an interface reference variable can point to a derived class object.

        I3 i3 = new D();
        i3.I3Method();
        /*
        i3.I4Method(); // Wrong Code . Error
        */

        I4 i4 = new D();
        i4.I3Method();
        i4.I4Method();

        Console.ReadKey();
    }
}

interface ICustomer
{
    /* // Interface can not contain fields
    int ID; // wrong, Error
    */


    // Print() method must be implemented in Customer class because Customer class inherits ICustomer interface
    void Print();


    /* //The modifier public is not valid 
     * public void Print2();
    */


    /* //interface members can not have a definition
    void Print1() 
    {
        Console.WriteLine("Hello ");
    }
    */


    /* // Naming rule violation
    interface Customer 
    {
    }
    */
}

interface I2 
{
    void I2Method(); 
}


public class Customer : ICustomer, I2 // Class can inherit from multiple interfaces at same time.
{
    // public void Print(int x) // illegal. because in interface there is no parameter
    public void Print() 
    {
        Console.WriteLine("Hello");
    }

    public void I2Method()  
    {
        Console.WriteLine("I2 method");
    }
}


public class A 
{
}

public class B 
{
}

/* class cannot inherit from multiple base class
public class C : A, B
{ 
}
*/

interface I3
{
    void I3Method();
}

interface I4 : I3 // interface inherit another interface
{
    void I4Method();
}

public class D : I4
{
    public void I3Method() 
    {
    }
    public void I4Method() 
    {
    }

}

