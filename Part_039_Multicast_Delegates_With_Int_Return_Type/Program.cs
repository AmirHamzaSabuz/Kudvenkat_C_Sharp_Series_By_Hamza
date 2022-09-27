//Example: Multicast delegate with an int return type

//using System;
namespace Part_039_Multicast_Delegates_With_Int_Return_Type
{
    // Deletegate's return type is int
    public delegate int SampleDelegate();

    public class Program
    {
        static void Main()
        {
            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del += SampleMethodTwo;


            // The ValueReturnedByDelegate will be 2, returned by the SampleMethodTwo(),
            // as it is the last method in the invocation list.
            int ValueReturnedByDelegate = del();


            Console.WriteLine("Returned Value = {0}", ValueReturnedByDelegate);

            Console.ReadKey();
        }


        // This method returns one
        public static int SampleMethodOne()
        {
            return 1;
        }


        // This method returns two
        public static int SampleMethodTwo()
        {
            return 2;
        }
    }
}