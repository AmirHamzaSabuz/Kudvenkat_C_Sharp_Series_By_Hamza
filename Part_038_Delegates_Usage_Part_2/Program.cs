internal class Program
{
    private static void Main(string[] args)
    {
        List<Employee> empList = new List<Employee>();
        empList.Add(new Employee() { Id = 101, Name = "Arian", Experience = 5, Salary = 50000 });
        empList.Add(new Employee() { Id = 102, Name = "Shakil", Experience = 4, Salary = 40000 });
        empList.Add(new Employee() { Id = 103, Name = "Rofiq", Experience = 6, Salary = 60000 });
        empList.Add(new Employee() { Id = 104, Name = "Rashed", Experience = 3, Salary = 30000 });

        //IsPromotable isPromotable = new IsPromotable(Promote);

        //Employee.PromoteEmployee(empList, isPromotable);
        Employee.PromoteEmployee(empList, emp => emp.Experience >= 5);
        Console.ReadKey();
    }

    //public static bool Promote(Employee emp) 
    //{
    //    if (emp.Experience >= 5)
    //    {
    //        return true;
    //    }
    //    else 
    //    {
    //        return false;
    //    }
    //}
}

delegate bool IsPromotable(Employee emp);

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote) 
    {
        foreach (Employee employee in employeeList )
        {
            if (IsEligibleToPromote(employee))
            {
                Console.WriteLine(employee.Name + " - promoted");
            }
        }
    }
}