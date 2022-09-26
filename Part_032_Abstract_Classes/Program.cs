internal class Program : AnotherClass2 //Customer
{
    private static void Main(string[] args)
    {
        /* // illegal. because AnotherClass2 abstract type. 
         * // Can not create an instance of the abstract type or interface
         * AnotherClass2 ac2 = new AnotherClass2(); 
         */
        AnotherClass2 ac2 = new Program();
        ac2.Print();

        AnotherClass1 ac1 = new AnotherClass1(); // instance can be created because AnotherClass1 is not abstract type 
        ac1.Print();

        Program program1 = new Program();
        program1.Print();

        Customer program2 = new Program();
        program2.Print();

        Console.WriteLine();

        ac2.Print1();
        ac1.Print1();
        program1.Print1();
        program2.Print1();

        Console.ReadKey();
    }

    public override void Print() 
    {
        Console.WriteLine("Hello Program");
    }

}

abstract class Customer 
{
    
    public abstract void Print();

    /*Can not declare a body because it is abstract
    public abstract void Print1() { } // Illegal. Wrong code. Error. 
    */

    public void Print1()  // Must declare a body because it is not abstract method
    {
        Console.WriteLine( "Non abstract or implemented method" );
    }
}

class AnotherClass1 : Customer
{
    public override void Print() // Option_1 - Must be implemented the base class abstract members.
    {
        Console.WriteLine("Hello AnotherClass1 ");
    }
}

abstract class AnotherClass2 : Customer // Option_2 - derived class is marked as abstract class
{

}




// A non abstract class, derived from an abstract class, must provide implementations for all inherited abstract members.

// If a class inherits an abstract class there are two options available for that class. 

// Provide implementation for all the abstract members inherited from the base class.

// If the class does not wish to provide implementation for all the abstract members inherited from the abstract class, then the class has to be marked as abstract class.


// We can not create any object of abstract class


// An abstract class only be used as a base class

// An abstract class can not be seald.

// Sealed class can not be a base class.

// An abstract class may contain abstract members (methods, properties, indexers, and events) but not mandatory.

// Although all the members of a class are non abstract or implemented, the class can be a abstract class