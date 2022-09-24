internal class Program 
{
    private static void Main(string[] args)
    {
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.FirstName = "Amir";
        FTE.LastName = "Hamza";
        FTE.YearlySalary = 50000;
        FTE.PrintFullName();

        PartTimeEmployee PTE = new PartTimeEmployee();
        PTE.FirstName = "Sidratul";
        PTE.LastName = "Muntaha";
        PTE.HourlyRate = 20;
        PTE.PrintFullName();

        Console.WriteLine();

        ChildClass1 ch1 = new ChildClass1();

        Console.WriteLine();

        ChildClass2 ch2 = new ChildClass2();

        Console.WriteLine();

        ChildClass3 ch3 = new ChildClass3();    

        Console.ReadKey();
    }
}

public class Employee 
{
    public string FirstName;
    public string LastName;
    public string Email;

    public void PrintFullName() 
    {
        Console.WriteLine(FirstName + " " + LastName);
    }

}

public class FullTimeEmployee : Employee
{
    public float YearlySalary;
}

public class PartTimeEmployee : Employee
{
    public float HourlyRate; 
}

class A 
{
}

class B
{ 
}
/* Wrong code. Illegal. Error // More than one base class is illegal.
 * public class C : A , B // Multiple class inheritance is not possible.
 * { 
 * }
 */

class C : FullTimeEmployee // Multilevel class inheritance is possible.
{ 
}


class ParentClass1
{
    public ParentClass1() 
    {
        Console.WriteLine("Parent1 Class Constructor called before child class constructor call");
    }
}

class ChildClass1 : ParentClass1
{
    public ChildClass1() 
    {
        Console.WriteLine("Child1 class constructor");
    }
}


class ParentClass2
{
    public ParentClass2()
    {
        Console.WriteLine("By default parameterless Parent2 Class Constructor called before child2 class constructor call");
    }

    public ParentClass2(string message)
    {
        Console.WriteLine(message);
    }
}

class ChildClass2 : ParentClass2
{
    public ChildClass2()
    {
        Console.WriteLine("Child2 class constructor");
    }
}

class ParentClass3
{
    public ParentClass3()
    {
        Console.WriteLine("parameterless Parent3 Class Constructor");
    }

    public ParentClass3(string message)
    {
        Console.WriteLine(message);
    }
}

class ChildClass3 : ParentClass3
{
    public ChildClass3() : base("Derived class controlling parent class. parameterized Parent class constructor called")
    {
        Console.WriteLine("Child3 class constructor");
    }
}