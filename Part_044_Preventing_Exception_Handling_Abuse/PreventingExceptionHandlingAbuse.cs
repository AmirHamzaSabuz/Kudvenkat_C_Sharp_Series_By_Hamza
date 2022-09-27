
using System;
public class PreventingExceptionHandlingAbuse
{
    public static void Main()
    {
        try 
        {
            Console.WriteLine("Please enter Numerator");
            int Numerator;

            bool IsNumeratorConversionSuccesful = int.TryParse(Console.ReadLine(), out Numerator);

            if (IsNumeratorConversionSuccesful)
            {
                Console.WriteLine("Please enter Denominator");
                int Denominator;

                bool IsDenominatorConversionSuccessful = int.TryParse(Console.ReadLine(), out Denominator);

                if (IsDenominatorConversionSuccessful && Denominator != 0)
                {
                    int Result = Numerator / Denominator;
                    Console.WriteLine("Result = {0}", Result);
                }
                else
                {
                    if (IsDenominatorConversionSuccessful && Denominator == 0)
                    {
                        Console.WriteLine("Denominator cannot be zero");
                    }
                    else
                    {
                        Console.WriteLine("Only numbers between {0} && {1} are allowed",
                            Int32.MinValue, int.MaxValue);
                    }
                }
            }
            else
            {
                Console.WriteLine("Only numbers between {0} && {1} are allowed", int.MinValue, Int32.MaxValue);
            }
        } // End try block
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    } // End Main method
}


/*
int i = 12;
// System.FormatException: 'Input string was not in a correct format.'
//because { 0} // Space is not valid before 0
Console.WriteLine("Hello { 0}", i); // Illegal, Error, Wrong code

int a = 5;
int b = 6;
// System.FormatException: 'Input string was not in a correct format.'
//because { 1} // Space is not valid before 1
Console.WriteLine("Hello {0} { 1}", a, b); // Illegal, Error, Wrong code
*/

