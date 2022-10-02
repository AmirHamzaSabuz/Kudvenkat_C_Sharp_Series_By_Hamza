using Part_062_Partial_Classes_abstract_sealed_inheritance;

internal class MainClass
{
    private static void Main(string[] args)
    {
        TestAbstract2 testAbstract2 = new TestAbstract2();
        testAbstract2.TestAbstract2_Method();

        TestSealed2 testSealed2 = new TestSealed2();
        testSealed2.TestSealed2_Method();

        Console.ReadKey();
    }
}