using System;
using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace Part_058_Override_Equals_Method
{
    public class MainClass
    {
        private static void Main()
        {
            int i = 10;
            int j = 10;


            Console.WriteLine("i == j is " + (i == j)); 
            // both value 10 // true

            Console.WriteLine("i.Equals(j) is " + i.Equals(j)); 
            // both value 10 // true


            Console.WriteLine();


            Direction direction1 = Direction.East; 
            // direction1 is value type

            Direction direction2 = Direction.East; 
            // direction2 is value type


            Console.WriteLine("direction1 == direction2 is " + (direction1 == direction2)); 
            // both value 1 // true

            Console.WriteLine("direction1.Equals(direction2) is " + direction1.Equals(direction2)); 
            // both value 1 // true


            Console.WriteLine();


            /*
             * If the type is a reference type, then by default "==" operator checks for reference equality 
             * and .Equals() method checks for value equality. 
             * Let's understand what we mean by reference and value equality.
             */

            Customer1 C1 = new Customer1();
            C1.FirstName = "Amir"; 
            C1.LastName = "Hamza";

            Customer1 C2 = C1;
            // C1 & C2 both are Reference Type variable
            //C1 & C2 both object reference variables are pointing to the same object, new Customer1()


            Console.WriteLine("C1 == C2 is " + (C1 == C2));
            // == Checks reference equality 
            // C1 & C2 both indicates or referes the same object 
            // output: true 

            Console.WriteLine("C1.Equals(C2) is " + C1.Equals(C2));
            // Equals() method checks value equality. 
            // Object is only one, so obviously the values are also equal.
            // output: true


            Console.WriteLine();


            Customer1 C3 = new Customer1();
            C3.FirstName = "Amir";
            C3.LastName = "Hamza";


            Customer1 C4 = new Customer1();
            C4.FirstName = "Amir";
            C4.LastName = "Hamza";


            Console.WriteLine("C3 == C4 is " + (C3 == C4));
            // == Checks reference equality
            // C3 & C4 are referring to different objects 
            // output: false

            Console.WriteLine("C3.Equals(C4) is " + C3.Equals(C4));
            // Equals() method checks value equality.
            // Inspite of the values across C3 and C4 being the same, returns flase
            // because we didn't override the Equals() Method.
            // output: false

            //Hence, it makes sense to override, the Equals() method to return true
            //when the values across the objects are same.


            Console.WriteLine();


            Customer2 C5 = new Customer2();
            C5.FirstName = "Amir";
            C5.LastName = "Hamza";


            Customer2 C6  = new Customer2();
            C6.FirstName = "Amir";
            C6.LastName = "Hamza";


            Console.WriteLine("C5 == C6 is " + (C5 == C6));
            // == Checks reference equality
            // C5 & C6 are referring to different objects 
            // output: false

            Console.WriteLine("C5.Equals(C6) is " + C5.Equals(C6));
            // Equals() method checks value equality.
            // Values of C5 and C6 are the same
            // The Equals() Method is overriden
            // output: true

            Console.ReadKey();
        }
    }

    public enum Direction
    {
        East = 1,
        West = 2,
        North = 3,
        South = 4
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


        public override bool Equals(object obj)
        {
            // If the passed in object is null
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Customer2))
            {
                return false;
            }
            return (this.FirstName == ((Customer2)obj).FirstName)
                && (this.LastName == ((Customer2)obj).LastName);
        }


        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ LastName.GetHashCode();
        }
    }
}

