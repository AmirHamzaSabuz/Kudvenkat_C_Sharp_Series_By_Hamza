using System;
using System.Text;

public class MainClass
{
    public static void Main()
    {
        string userString = "C#";
        userString += " Video";
        userString += " Tutorial";
        userString += " for";
        userString += " beginners";
        Console.WriteLine(userString);

        StringBuilder userStringBuilder = new StringBuilder("C#");
        userStringBuilder.Append(" Video");
        userStringBuilder.Append(" Tutorial");
        userStringBuilder.Append(" for");
        userStringBuilder.Append(" beginners");
        Console.WriteLine(userStringBuilder.ToString());

        Console.WriteLine();

        string strNumbers = string.Empty;
        for (int i = 0; i < 1000; i++)
        {
            strNumbers += i.ToString() + " ";
        }
        Console.WriteLine(strNumbers);

        Console.WriteLine();

        StringBuilder strBuilNumbers = new StringBuilder();
        for (int i = 1000;  i< 2000; i++)
        {
            strBuilNumbers.Append(i.ToString() + " ");
        }
        Console.WriteLine(strBuilNumbers);
    }
}

/*
 * 1. Objects of type StringBuilder are mutable where as objects of type System.String are immutable.
 * 
 * 2. As StringBuilder objects are mutable, they offer better performance than string objects of type System.String.
 * 
 * 3. StringBuilder class is present in System.Text namespace where String class is present in System namespace.
 * 
 * 4. The number of orphaned string objects are about thousand, that get created on the heap 
 * when we used objects of type System.String for printing 0 to 999 numbers.
 * 
 * 5. On the other hand only one object is created 
 * when we used object of type System.Text.StringBuilder for printing 1000 to 1999 numbers.
 */