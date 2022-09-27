//Approach 2:

//using System;
namespace Part_039_Multicast_Delegates_Approach2
{
    public delegate void SampleDelegate();

    public class Program
    {
        static void Main()
        {
            // In this example del is a multicast delegate. You use += operator 
            // to chain delegates together and -= operator to remove.

            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del += SampleMethodTwo;
            del += SampleMethodThree;
            del -= SampleMethodTwo;

            del();

            Console.ReadKey();
        }


        public static void SampleMethodOne()
        {
            Console.WriteLine("SampleMethodOne Invoked");
        }


        public static void SampleMethodTwo()
        {
            Console.WriteLine("SampleMethodTwo Invoked");
        }


        public static void SampleMethodThree()
        {
            Console.WriteLine("SampleMethodThree Invoked");
        }
    }
}