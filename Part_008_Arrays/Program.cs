internal class Program
{
    private static void Main(string[] args)
    {
        // Initialize and assign values in different lines
        int[] EvenNumbers = new int[3];
        EvenNumbers[0] = 0;
        EvenNumbers[1] = 2;
        EvenNumbers[2] = 4;

        Console.WriteLine("Even Numers");
        for (int i = 0; i < EvenNumbers.Length; i++)
        {
            Console.WriteLine(EvenNumbers[i]);
        }

        Console.WriteLine();

        // Initialize and assign values in the same line
        int[] OddNumbers = { 1, 3, 5 };

        Console.WriteLine("Odd Numbers");

        for (int i = 0; i < OddNumbers.Length; i++)
        {
            Console.WriteLine(OddNumbers[i]);
        }


        Console.ReadKey();
    }
}