//A Multicast delegate is a delegate that has references to more than one function. 
//When you invoke a multicast delegate, 
//all the functions the delegate is pointing to, are invoked.

//There are 2 approaches to create a multicast delegate.

//Approach 1:

//using System;
namespace Part_039_Multicast_Delegates_Approach1
{
    public delegate void SampleDelegate();

    public class Program
    {
        static void Main()
        {
            SampleDelegate del1, del2, del3, del4;
            del1 = new SampleDelegate(SampleMethodOne);
            del2 = new SampleDelegate(SampleMethodTwo);
            del3 = new SampleDelegate(SampleMethodThree);
            del4 = del1 + del2 + del3 - del2;

            /*
            SampleDelegate del1 = new SampleDelegate(SampleMethodOne);
            SampleDelegate del2 = new SampleDelegate(SampleMethodTwo);
            SampleDelegate del3 = new SampleDelegate(SampleMethodThree);
            SampleDelegate del4 = del1 + del2 + del3 - del2;
            */

            // In this example del4 is a multicast delegate. You use +(plus) 
            // operator to chain delegates together and -(minus) operator to remove.

            del4();

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