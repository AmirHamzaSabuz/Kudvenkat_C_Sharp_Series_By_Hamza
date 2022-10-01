using System;

// Part 57 - Why You Should Override ToString Method
namespace Part_057_Override_ToString_Method
{
    public class MainClass
    {
        private static void Main()
        {
            int Number = 10;

            Console.WriteLine(Number.ToString());

            Customer1 C1 = new Customer1();
            C1.FirstName = "Amir";
            C1.LastName = "Hamza";

            Console.WriteLine("Did not override ToString Method. So C1.ToString() prints Type Name. Type Name is " + C1.ToString());

            Console.WriteLine();

            Customer2 C2 = new Customer2();
            C2.FirstName = "Amir";
            C2.LastName = "Hamza";

            Console.WriteLine("Override ToString Method. So C2.ToString() = " + C2.ToString());

            Console.WriteLine();

            Console.WriteLine("Override ToString Method. So Convert.ToString(C2) = " + Convert.ToString(C2));

            Console.ReadKey();
        }
    }

    public class Customer1
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }


    }

    public class Customer2
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName ;
        }
    }
}

