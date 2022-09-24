internal class Program
{
    private static void Main(string[] args)
    {
        Employee[] employees = new Employee[4];
        employees[0] = new Employee();
        employees[1] = new PartTimeEmployee();
        employees[2] = new FullTimeEmployee();
        employees[3] = new TemporaryEmployee();

        foreach (Employee e in employees) 
        {
            e.PrintFullName();
        }

        Console.ReadKey();
        
    }
}

public class Employee 
{
    public string FirstName = "Amir";
    public string LastName = "Hamza";

    public virtual void PrintFullName() 
    {
        Console.WriteLine(FirstName +" "+ LastName);
    }
}

public class PartTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " - Part Time");
    }
}

public class FullTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " - Full Time");
    }

}

public class TemporaryEmployee : Employee
{
   
}

/* If we don't use "virtual" and "override", for base type or Employee type object, base class method will be called.
 * output:
 * Amir Hamza
 * Amir Hamza
 * Amir Hamza
 * Amir Hamza
 */

/* If we use "virtual" and "override", child class methods will be called 
 * //In fourth line, base class method is called because there is no method in TemporaryEmploye child class.
 * output:
 * Amir Hamza
 * Amir Hamza - Part Time
 * Amir Hamza - Full Time
 * Amir Hamza
 */

/* Polymorphism allows us to invoke derived class methods through a base class reference.
 * In the base class the method is declared as virtual, and in the derived class we override the same method. 
 */

