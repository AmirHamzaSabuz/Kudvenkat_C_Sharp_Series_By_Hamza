//Example: Multicast delegate with an integer output parameter.

//using System;
namespace Part_039_Multicast_Delegates_Integer_Output_Parameter 
{
    // Deletegate has an int output parameter
    public delegate void SampleDelegate(out int Integer);

    public class Program 
    {
        static void Main()
        {
            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del += SampleMethodTwo;


            // The ValueFromOutPutParameter will be 2, initialized by SampleMethodTwo(),
            // as it is the last method in the invocation list.
            int ValueFromOutPutParameter = -1;
            del(out ValueFromOutPutParameter);


            Console.WriteLine("Returned Value = {0}", ValueFromOutPutParameter);

            Console.ReadKey();
        }


        // This method sets ouput parameter Number to 1
        public static void SampleMethodOne(out int Number)
        {
            Number = 1;
        }


        // This method sets ouput parameter Number to 2
        public static void SampleMethodTwo(out int Number)
        {
            Number = 2;
        }
    }
}