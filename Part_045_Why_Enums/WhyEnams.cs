using System;
public class WhyEnums
{
    public static void Main()
    {
        Customer[] customers = new Customer[3];
        customers[0] = new Customer()
        {
            Name = "Amir",
            Gender = 1 // In which way we may know that 1 = Male ? So we need Enums
        };
        customers[1] = new Customer()
        {
            Name = "Muntaha",
            Gender = 2
        };
        customers[2] = new Customer()
        {
            Name = "Muntaqa",
            Gender = 0
        };
        foreach (Customer customer in customers)
        {
            Console.WriteLine("Name = {0} && Gender = {1}", customer.Name, GetGender(customer.Gender));
        }
    }


    public static string GetGender(int gender)
    {
        // The swicth here is less readable because of these integral numbers
        switch (gender)
        {
            case 0:
                return "Unknown";
            case 1:
                return "Male";
            case 2:
                return "Female";
            default:
                return "Invalid Data for Gender";
        }
    }
}


// 0 - Unknown
// 1 - Male
// 2 - Female


public class Customer
{
    public string? Name { get; set; }
    public int Gender { get; set; }
}