

// In this code, that means in part 037, delegate is not used.

// Without using delegate, the code is like this.

//using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {
        List<Employee> empList = new List<Employee>();
        empList.Add(new Employee() { Id = 101, Name = "Arian", Experience = 5, Salary = 50000});
        empList.Add(new Employee() { Id = 102, Name = "Shakil", Experience = 4, Salary = 40000 });
        empList.Add(new Employee() { Id = 103, Name = "Rofiq", Experience = 6, Salary = 60000 });
        empList.Add(new Employee() { Id = 104, Name = "Rashed", Experience = 3, Salary = 30000 });

        Employee.PromoteEmployee(empList);
        Console.ReadKey();
    }
}

class Employee 
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    public static void PromoteEmployee(List <Employee> employeeList ) 
    {
        foreach (Employee employee in employeeList)
        {
            if (employee.Experience >= 5)
            { 
                Console.WriteLine (employee.Name + " - promoted");
            }
        }
    }
}