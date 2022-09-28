using System;
public class EnumsDetails
{
    public static void Main()
    {
        int[] Values = (int[])Enum.GetValues(typeof(Gender)); // Values means 1, 2,3  of Gender class

        Console.WriteLine("Gender Enum Values");

        foreach (int value in Values)
        {
            Console.WriteLine(value);
        }

        Console.WriteLine();


        string[] Names = Enum.GetNames(typeof(Gender)); // Names means Unknown, Male, Female of Gender class
        Console.WriteLine("Gender Enum Names");
        foreach (string Name in Names)
        {
            Console.WriteLine(Name);
        }
    }
}
public enum Gender : int // values = 1, 2, 3, Names 
{
    Unknown = 1,
    Male = 2,
    Female = 3
}

/*
1. Enums are enumerations.
2. Enums are strongly typed constants. 
	Hence, an explicit cast is needed to convert from enum type to an integral type and vice versa. 
	Also, an enum of one type cannot be implicitly assigned to an enum of another type 
	even though the underlying value of their members are the same.
3. The default underlying type of an enum is int.
4. The default value for first element is ZERO and gets incremented by 1.
5. It is possible to customize the underlying type and values.
6. Enums are value types.
7. Enum keyowrd (all small letteres) is used to create enumerations, 
	where as Enum class, contains static GetValues() and GetNames() methods 
	which can be used to list Enum underlying type values and Names.


// Default underlying type is int and the value starts at ZERO
public enum Gender
{
    Unknown,
    Male,
    Female
}


// Gender enum underlying type is now short and the value starts at ONE
public enum Gender : short
{
    Unknown = 1,
    Male = 2,
    Female = 3
}


// Enum values need not be in sequential order. Any valid underlying type value is allowed 
public enum Gender : short
{
    Unknown = 10,
    Male = 22,
    Female = 35
}


// This enum will not compile, bcos the maximum value allowed for short data type is 32767. 
public enum Gender : short
{
    Unknown = 10,
    Male = 32768,
    Female = 35
} 


Note: Use short.MaxValue to find out the maximum value that a short data type can hold


An explicit cast is needed to convert from enum type to an integral type and vice versa.
int i = Gender.Male;
The above line will not compile. A compiler error will be generated stating:
Cannot implicitly convert type 'Gender' to 'int'. An explicit conversion exists (are you missing a cast?)


Gender female = 2; 
The above line will also not compile. A slightly different compiler error will be generated stating
Cannot implicitly convert type 'int' to 'Gender'. An explicit conversion exists (are you missing a cast?)



Enum of one type cannot be implicitly assigned to an enum of another type even though the underlying value of their members are the same. 
An explicit cast is required as shown below.
 */
