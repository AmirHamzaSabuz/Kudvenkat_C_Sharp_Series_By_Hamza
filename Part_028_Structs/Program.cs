using System.Reflection.Emit;

internal class Program
{
    private static void Main(string[] args)
    {
        Customer customer1 = new Customer(101, "Hamza");
        customer1.PrintDetails();

        Customer customer2 = new Customer();
        customer2.Id = 102;
        customer2.Name = "Muntaha";
        customer2.PrintDetails();

        Customer customer3 = new Customer { Id = 103, Name= "Muntasir" };
        customer3.PrintDetails();
    }
}

public struct Customer 
{
    private int _id;
    private string _name;

    public int Id 
    {
        get { return _id; }
        set { _id = value; }
    }

    public string Name { get => _name; set => _name = value; }

    public Customer(int id, string name)
    {
        this._id = id;
        _name = name;

    }

    public void PrintDetails() 
    {
        Console.WriteLine("Id = {0} && Name = {1} ", this._id, this._name);
    }
    
}