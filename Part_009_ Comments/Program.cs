internal class Program
{
    private static void Main(string[] args)
    {
        // Single line comments

        /*
         * Multi line comments
         */

        Customer customer = new Customer();
        customer.Name = "Hamza";

        Console.WriteLine(customer.Name);
        Console.ReadKey();
    }
}

/// <summary>
/// Represents the properties of Customer
/// </summary>
public class Customer
{
    public string? Name { get; set; }

}