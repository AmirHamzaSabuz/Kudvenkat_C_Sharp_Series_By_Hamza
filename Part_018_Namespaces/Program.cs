using PATA = Part_018_ProjectA_TeamA;
using PATB = Part_018_ProjectA_TeamB;
internal class Program
{
    private static void Main(string[] args)
    {
        PATA.ClassA.Print();
        PATB.ClassA.Print();

        Console.ReadKey();
    }
}


