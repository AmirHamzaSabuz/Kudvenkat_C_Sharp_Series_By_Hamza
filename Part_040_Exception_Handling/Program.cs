using System;
using System.Diagnostics.Metrics;
using System.IO;
using static System.Reflection.Metadata.BlobBuilder;

class ExceptionHandling
{
    public static void Main()
    {
        
        StreamReader streamReader = new StreamReader("C:\\DotNetWorkingSpace_dotnetcore6\\Kudvenkat_C_Sharp_Series_By_Hamza\\Kudvenkat_C_Sharp_Series_By_Hamza\\Part_040_Exception_Handling\\SampleTextFile.txt");
        Console.WriteLine(streamReader.ReadToEnd());
        streamReader.Close();

        Console.WriteLine();
        Console.WriteLine();

        try
        {
            StreamReader streamReader1 = new StreamReader("C:\\NonExistingFile.txt");
            Console.WriteLine(streamReader1.ReadToEnd());
            streamReader1.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(ex.StackTrace);
        }


        Console.WriteLine();
        Console.WriteLine();



        StreamReader streamReader3 = null;
        try
        {
            // This line will throw FileNotFoundException
            streamReader3 = new StreamReader("C:\\NonExistingFile.txt");
            Console.WriteLine(streamReader3.ReadToEnd());
        }
        // This catch block handles only FileNotFoundException
        catch (FileNotFoundException fileNotFoundException)
        {
            // Log or email the exception
            // Code to log or email exception details


            // Display meaningful error message to the end user
            Console.WriteLine("Please check if the file \"{0}\" is present", fileNotFoundException.FileName);
        }

        //Specific exceptions will be caught before the base general exception,
        //so specific exception blocks should always be on top of the base exception block.
        //Otherwise, you will encounter a compiler error.

        // This catch block handles all the other exceptions
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }

        //It is a good practice to always release resources in the finally block,
        //because finally block is guarenteed to execute,
        //irrespective of whether there is an exception or not.

        finally
        {
            if (streamReader3 != null) // to prevent System.NullReferenceException
            {
                streamReader3.Close();

            }
            Console.WriteLine("Finally Block");


        }

        Console.ReadKey();
    }
}