using System;
using System.IO;
class Program
{
    public static void Main()
    {
        try
        {
            try
            {
                Console.WriteLine("Enter First Number");
                int FN = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter Second Number");
                int SN = Convert.ToInt32(Console.ReadLine());


                int Result = FN / SN;
                Console.WriteLine("Result = {0}", Result);
            }
            catch (Exception ex)
            {
                string filePath = "C:\\NonExistingFile.txt";
                if (File.Exists(filePath))
                {
                    StreamWriter sw = new StreamWriter(filePath);
                    sw.WriteLine(ex.GetType().Name);
                    sw.WriteLine(ex.Message);
                    sw.WriteLine(ex.StackTrace);
                    sw.Close();
                    Console.WriteLine("There is a problem! Plese try later");
                }
                else
                {
                    //To retain the original exception pass it as a parameter
                    //to the constructor, of the current exception
                    throw new FileNotFoundException(filePath + " Does not Exist", ex);
                }
            }
        }// End outer try block
        catch (Exception exception)
        {
            Console.WriteLine();
            Console.WriteLine();


            //ex.Message will give the current exception message
            Console.WriteLine("Current or Outer Exception = " + exception.Message);


            //Check if inner exception is not null before accessing Message property
            //else, you may get Null Reference Excception
            if (exception.InnerException != null)
            {
                Console.WriteLine("Inner Exception = {0} ", exception.InnerException.Message);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Current Exception Name = {0}", exception.GetType().Name);

            if (exception.InnerException != null)
            {
                Console.WriteLine("Inner Exception Name = {0}", exception.InnerException.GetType().Name);
            }
        }

        Console.WriteLine();
        Console.WriteLine();

        try
        {
            try
            {
                Console.WriteLine("Enter First Number");
                int FN = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter Second Number");
                int SN = Convert.ToInt32(Console.ReadLine());


                int Result = FN / SN;
                Console.WriteLine("Result = {0}", Result);
            }
            catch (Exception ex)
            {
                string filePath = @"C:\DotNetWorkingSpace_dotnetcore6\Kudvenkat_C_Sharp_Series_By_Hamza\Kudvenkat_C_Sharp_Series_By_Hamza\Part_041_Inner_Exceptions\Log.txt";
                if (File.Exists(filePath))
                {
                    StreamWriter sw = new StreamWriter(filePath);
                    sw.WriteLine(ex.GetType().Name);
                    sw.WriteLine(ex.Message);
                    sw.WriteLine(ex.StackTrace);
                    sw.Close();
                    Console.WriteLine("There is a problem! Plese try later");
                }
                else
                {
                    //To retain the original exception pass it as a parameter
                    //to the constructor, of the current exception
                    throw new FileNotFoundException(filePath + " Does not Exist", ex);
                }
            }
        }// End outer try block
        catch (Exception exception)
        {
            Console.WriteLine();
            Console.WriteLine();


            //ex.Message will give the current exception message
            Console.WriteLine("Current or Outer Exception = " + exception.Message);


            //Check if inner exception is not null before accessing Message property
            //else, you may get Null Reference Excception
            if (exception.InnerException != null)
            {
                Console.WriteLine("Inner Exception = {0} ", exception.InnerException.Message);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Current Exception Name = {0}", exception.GetType().Name);

            if (exception.InnerException != null)
            {
                Console.WriteLine("Inner Exception Name = {0}", exception.InnerException.GetType().Name);
            }
        }

        Console.ReadKey();
    } // End Main Method
}