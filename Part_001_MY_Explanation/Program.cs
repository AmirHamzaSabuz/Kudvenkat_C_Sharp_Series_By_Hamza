/*
 * // In dot net 6, whatever I want to write, bydefault it will autometically goes in Main() Method.
 * // If I want to write a method outside the Main() method,  
 * // in the Console line or after the console line I have to press Alt + Enter. 
 * // Then I have to Go the option
 * // Convert to 'Program.Main' style Program
*/

/* 
 * //For dot net 6 using System is unnecessary 
 * using System; 
*/

internal class Program
/*
 * //I can use 
 * class Program
 * //or
 * public class Program
 */

{
    private static void Main(string[] args)
    /*  
     *  private static void Main()
     */
    {
        Console.WriteLine("Hello, World!");

        Main1();
        Main2();
        Main(); // I can use 2 methods with same name nestedly. It is local. Program does not starts from here.
        Main3();

        /* 
         * // Wrong Code! Error!
         * Main4(); // You can not call a global non static method within a global static method without object reference
        */
        Program program = new Program();
        program.Main4();

        Console.ReadKey();

        static void Main() // We can use 2 methods with same name nestedly. Program does not starts from here.
        {
            Console.WriteLine("another Main method in actual Main method. Program does not starts from here.");
        }

        static void Main1()
        {
            Console.WriteLine("Method 1");
            /* 
             * // Wrong Code! Error!
             * Main2(); //I can not call a local non static method within a local static method
            */
        }
        void Main2()
        {
            Console.WriteLine("Method 2");
            Main1();
        }

    }
    static void Main3()
    {
        Console.WriteLine("Method 3");
        /*
         * Main4(); // You can not call a global non static method within a global static method without object reference
        */
    }
    void Main4()
    {
        Console.WriteLine("Method 4");
        Main3();
        /*
         * // I canot use local method in global method
         * Main2(); // Wrong code! Error!
         */
    }

    /* 
     * // Wrong code! Error! you can not write separately 2 methods with same name. 
     * static void Main() //Wrong code! Error!
     * {
     *      Console.WriteLine("another Main method outside Main method");
     * }
    */

}