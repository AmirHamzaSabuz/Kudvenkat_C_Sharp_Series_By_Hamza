internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Implicit conversion is done by the compiler:
         * When there is no loss of information if the conversion is done
         * There is no possibility of throwing exceptions during the conversion
         */
        int i1 = 100;
        float f1;

        f1 = i1; // Implicit conversion
        Console.WriteLine(f1);

        Console.WriteLine();


        float f2 = 123.45F;
        int i2;

        /*
         * i2 = f2; // Compile Error
         */

        // explicit conversion using cast () operator
        i2 = (int)f2; // value of i2 is 123
        Console.WriteLine(i2); // output: 123

        Console.WriteLine();

        float f3 = 123456789123456.123F;
        int i3;

        //explicit conversion using cast () operator
        i3 = (int)f3; // value of i3 is -2147483648
        Console.WriteLine(i3); //output: -2147483648

        Console.WriteLine();

        float f4 = 123456789123456.123F;
        int i4;
        /*
         *  // explicit conversion using Convert class
         * i4 = Convert.ToInt32(f4); // System.OverflowException: 'Value was either too large or too small for an Int32.'
         */

        try
        {
            //explicit conversion using Convert class
            i4 = Convert.ToInt32(f4);
            Console.WriteLine(i4);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message); // output: Value was either too large or too small for an Int32.
        }

        Console.WriteLine();

        /*
         * Difference between Parse and TryParse
         * 1. If the number is in a string format you have 2 options - Parse() and TryParse() 
         * 2. Parse() method throws an exception if it cannot parse the value, 
         * whereas TryParse() returns a bool indicating whether it succeeded or failed.
         * 3. Use Parse() if you are sure the value will be valid, otherwise use TryParse()
         */

        string strNumber1 = "100G";
        int intNumber1;

        /*
         * intNumber1 = strNumber1; // Compile Error
        */

        /*
         * intNumber1 = int.Parse(strNumber1); //System.FormatException: 'Input string was not in a correct format.'
        */

        try
        {
            intNumber1 = int.Parse(strNumber1); //Parse() method throws an exception if it cannot parse the value
            Console.WriteLine(intNumber1);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine();

        //Use Parse() if you are sure the value will be valid
        string strNumber2 = "100";
        int intNumber2;

        intNumber2 = int.Parse(strNumber2);
        Console.WriteLine(intNumber2);

        Console.WriteLine();


        //TryParse() returns a bool indicating whether it succeeded or failed
        string strNumber3 = "100G";
        int intNumber3;


        bool isConversionSuccessfull1 = int.TryParse(strNumber3, out intNumber3);

        if (isConversionSuccessfull1)
        {
            Console.WriteLine(intNumber3);
        }
        else
        {
            Console.WriteLine("Please enter a valid number");
        }

        Console.WriteLine();

        //TryParse() returns a bool indicating whether it succeeded or failed
        string strNumber4 = "100";
        int intNumber4;


        bool isConversionSuccessfull2 = int.TryParse(strNumber4, out intNumber4);

        if (isConversionSuccessfull2)
        {
            Console.WriteLine(intNumber4);
        }
        else
        {
            Console.WriteLine("Please enter a valid number");
        }



        Console.ReadKey();
    }
}
