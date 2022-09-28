using Part_050_AssemblyOne;

namespace Part_050_Assembly_Three
{
    public class Assembly_Three_Class1 : AssemblyOneClass1
    {
        public void Test()
        {
            AssemblyOneClass1 assemblyOneClass1 = new AssemblyOneClass1();
            /*
            Console.WriteLine(assemblyOneClass1.Name); // Error
            */
            // Access the base class member using the base keyword           
            Console.WriteLine(base.Name);

            Console.WriteLine(this.Name);

            Assembly_Three_Class1 assembly_Three_Class1 = new Assembly_Three_Class1();
            Console.WriteLine(assembly_Three_Class1.Name);
        }
    }
}