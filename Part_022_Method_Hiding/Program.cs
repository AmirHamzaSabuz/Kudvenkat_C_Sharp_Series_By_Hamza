internal class Program
{
    private static void Main(string[] args)
    {
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.FirstName = "Amir";
        FTE.LastName = "Hamza";
        FTE.YearlySalary = 50000;
        //FTE.PrintFullName();

        PartTimeEmployee PTE = new PartTimeEmployee();
        PTE.FirstName = "Sidratul";
        PTE.LastName = "Muntaha";
        PTE.HourlyRate = 20;
        
        
        Console.WriteLine();
        PTE.PrintFullNameWithSalam(); // printed from child class because Child class method hides the same name base class method
        ((Employee)PTE).PrintFullNameWithSalam(); // printed from base class. casted in base class
        Console.WriteLine();
        PTE.PrintFullNameWithHello(); // printed from base class because in child class method we wrote base.PrintFullNameWithHello();        

        Console.WriteLine();

        // Employee type object but PartTimeEmployee() constructor method is called. Here We get only base class properties or fields.
        Employee PTE1 = new PartTimeEmployee(); 
        PTE1.FirstName = "Arian";
        PTE1.LastName =  "Muntaqa";
   
        PTE1.PrintFullNameWithSalam(); // printed from base class because base class type object.

        Console.ReadKey();
    }
}

public class Employee
{
    public string FirstName;
    public string LastName;
    public string Email;



    public void PrintFullNameWithHello() 
    {
        Console.WriteLine("Hello " + FirstName + " " + LastName + ". From Base Class");
    }

    public void PrintFullNameWithSalam()
    {
        Console.WriteLine("Assalamu alaikum, " + FirstName + " " + LastName + ". From Base class");
    }

}

public class FullTimeEmployee : Employee
{
    public float YearlySalary;
}

public class PartTimeEmployee : Employee
{
    public float HourlyRate;



    public new void PrintFullNameWithHello()
    {
        base.PrintFullNameWithHello(); // from base class
    }

    public new void PrintFullNameWithSalam() // it hides the same name method of base class.
    {
        Console.WriteLine("Assalamu alikum." + FirstName + " "+ LastName + ". From Child class");
    }

}

