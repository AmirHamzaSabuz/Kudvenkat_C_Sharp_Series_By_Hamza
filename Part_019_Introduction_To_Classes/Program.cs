internal class Program
{
    private static void Main(string[] args)
    {
        Customer customer = new Customer(); 
        Customer customer1 = new Customer("Amir", "Hamza");

        customer.PrintFullName();
        customer1.PrintFullName();

        Console.ReadKey();
    }
}

class Customer 
{
    string _firstName;
    string _lastName;

    //Constructor with parameter
    public Customer(string firstName, string lastName) 
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    //Constructor without parameter
    public Customer() : this("No first name provided &", "No last name provided")
    {
    }

    public void PrintFullName() 
    {
        Console.WriteLine("Full Name = {0} {1}", _firstName, _lastName);
    }

    ~Customer() //Destructor
    {
        //Clean up code
    }
}