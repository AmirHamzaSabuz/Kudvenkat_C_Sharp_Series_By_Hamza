using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Part_066_Overloading_Indexers
{
    public class Company
    {
        private List<Employee> listEmployees;

        public Company()
        {
            listEmployees = new List<Employee>();

            // Add new Employees
            listEmployees.Add(new Employee() { EmployeeId = 1, Name = "A", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 2, Name = "B", Gender = "Female" });
            listEmployees.Add(new Employee() { EmployeeId = 3, Name = "C", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 4, Name = "D", Gender = "Female" });
            listEmployees.Add(new Employee() { EmployeeId = 5, Name = "E", Gender = "Female" });
            listEmployees.Add(new Employee() { EmployeeId = 6, Name = "F", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 7, Name = "G", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 8, Name = "H", Gender = "Male" });
        } // End Constructor

        public string this[int employeeId]
        {
            get
            {
                return listEmployees.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name;
            }
            set
            {
                listEmployees.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name = value;
            }
        }

        public string this[string Gender]
        {
            get
            {
                return listEmployees.Count(emp => emp.Gender == Gender).ToString();
            }
            set
            {
                foreach (Employee employee in listEmployees)
                {
                    if (employee.Gender == Gender)
                    {
                        employee.Gender = value;
                    }
                }
            }
        }
    }
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}