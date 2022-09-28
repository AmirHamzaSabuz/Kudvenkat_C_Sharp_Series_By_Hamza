
using Part_050_Assembly_Three;
using Part_050_AssemblyOne;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Assembly_Three_Class1 assembly_Three_Class1 = new Assembly_Three_Class1();
        assembly_Three_Class1.Test();

        AssemblyOneClass2 assemblyOneClass2 = new AssemblyOneClass2();
        assemblyOneClass2.Test();
    }
}