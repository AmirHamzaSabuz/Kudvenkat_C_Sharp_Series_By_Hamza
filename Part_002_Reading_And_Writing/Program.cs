class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter your First name");
        string? FirstName = Console.ReadLine();

        Console.WriteLine("Please enter your last name");
        string? LastName = Console.ReadLine();

        Console.WriteLine("Hello {0} {1}", FirstName, LastName); // Placeholder Syntax
        Console.WriteLine("Your full name is " + FirstName + " " + LastName); // Concatenation

        Console.ReadKey();

    }
}