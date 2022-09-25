using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        int i = 0;
        if (i == 10) 
        {
            int j = 20;
            Customer customer1 = new Customer();
            customer1.Id = 101;
            customer1.Name = "Amir";
        }
        int a = 10;
        int b = a;
        b = b + 1;
        Console.WriteLine("a = {0}, b = {1}", a, b);

        Customer customer2 = new Customer();
        customer2.Id = 102;
        customer2.Name = "Muntaha";

        Customer customer3 = customer2;
        customer3.Name = "Nasrin";

        Console.WriteLine("customer2.Name = {0}, customer3.Name = {1}", customer2.Name, customer3.Name);



    }
}
public class Customer 
{
    public int Id { get; set; } 
    public string Name { get; set; }

    public Customer() // Class can contain explicit parameterless constructors
    {

    }

    ~Customer() //Class types can contain destructors
    {
    }
}

public struct Employee
{
    public int Id { get; set; }
    public string Name { get; set; }

    /* Structs can not contain explicit parameterless constructors
    public Employee() 
    {

    }
    */

    /* Only class types can contain destructors. struct types can not contain destructors.
    ~Employee() //Wrong. Error.
    {
    }
    */

    // Struct and Class both can inherit from an interface

    // Struct can not inherit from another class or struct

    // Structs are sealed type. Structs can not be base. A class or struct can not inherit from another struct.

    // Sealed class can not be a base class.

    // Sealed is used to prevent a class from being inherited. That means sealed is used to prevent a class from being base class.
}