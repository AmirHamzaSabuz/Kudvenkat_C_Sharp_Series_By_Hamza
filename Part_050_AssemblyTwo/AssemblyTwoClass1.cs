using Part_050_AssemblyOne;

namespace Part_050_AssemblyTwo
{
    public class AssemblyTwoClass1
    {
        public void Test()
        {
            AssemblyOneClass1 instance = new AssemblyOneClass1();
            /*
            Console.WriteLine(instance.ID);  // Error
            // ID is protected internal. ID is accessible in same assembly
            */
        }

    }
}