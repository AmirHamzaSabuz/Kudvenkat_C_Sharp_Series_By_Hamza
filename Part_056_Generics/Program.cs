using System;
namespace Part_056_Generics
{
    public class MainClass
    {
        private static void Main()
        {
            bool Equal1 = Calculator1.AreEqual<int>(2, 1);
            if (Equal1)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

            bool Equal2 = Calculator1.AreEqual<string>("A", "A");
            if (Equal2)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

            Console.WriteLine();
            Console.WriteLine();

            bool Equal3 = Cal2<int>.AreEqual(2, 1);

            if (Equal3)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

            bool Equal4 = Cal2<string>.AreEqual("B", "B");
            if (Equal4)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }
    public class Calculator1
    {
        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }


    public class Cal2<T> 
    {
        public static bool AreEqual(T value1, T value2)
        {
            return value1.Equals(value2);

        }
    }

}



