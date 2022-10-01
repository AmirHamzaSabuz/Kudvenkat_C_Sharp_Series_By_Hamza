using System;
public class MainClass
{
    public static void Main()
    {
        Customer C1 = new Customer();
        Console.WriteLine(C1.ToString());
        //output: Customer


        Console.WriteLine();

        Customer C2 = null;

        string str = Convert.ToString(C2);
        // value of str is "". value of C2 is null

        Console.WriteLine(str);

        try
        {
             Console.WriteLine(C2.ToString()); // Null Reference Exception
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

public class Customer
{
    public string Name { get; set; }
}