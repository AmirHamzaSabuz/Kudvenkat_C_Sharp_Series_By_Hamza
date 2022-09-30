
using System.Reflection;
namespace Part_055_Late_Binding_Using_Reflection
{
    public class Program 
    {
        private static void Main()
        {
            // Load the current executing assembly as the Customer class is present in it.
            Assembly executingAssembly = Assembly.GetExecutingAssembly();


            // Load the Customer class for which we want to create an instance dynamically
            Type customerType = executingAssembly.GetType("Part_055_Late_Binding_Using_Reflection.Customer");

            // Create the instance of the customer type using Activator class 
            object customerInstance = Activator.CreateInstance(customerType);

            // Get the method information using the customerType and GetMethod()
            MethodInfo getFullName = customerType.GetMethod("GetFullName");

            // Create the parameter array and populate first and last names
            string[] methodParameters = new string[2];
            methodParameters[0] = "Amir"; //FirstName
            methodParameters[1] = "Hamza"; //LastName

            // Invoke the method passing in customerInstance and parameters array
            string fullName = (string)getFullName.Invoke(customerInstance, methodParameters);
            Console.WriteLine("Full Name = {0}", fullName);

            Console.ReadKey();
        }
    }
    public class Customer
    {
        public string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
    }
}


/*Early Binding Example:
 
using System;
namespace Part_055_Late_Binding_Using_Reflection
{
    public class Program
    {
        private static void Main()
        {
            Customer C1 = new Customer();
            string fullName = C1.GetFullName("Amir", "Hamza");
            Console.WriteLine("Full Name = {0}", fullName);
        }
    }
    public class Customer
    {
        public string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
    }
}
 * 
 */