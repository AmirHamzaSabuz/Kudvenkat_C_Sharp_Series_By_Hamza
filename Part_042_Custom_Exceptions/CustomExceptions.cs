using System;
using System.Runtime.Serialization;


public class CustomExceptions
{
    public static void Main()
    {
        try
        {
            throw new UserAlreadyLoggedInException("User Already logged in");
        }
        catch (UserAlreadyLoggedInException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.ReadKey();
    }
}


[Serializable]
public class UserAlreadyLoggedInException : Exception
{
    public UserAlreadyLoggedInException() : base()
    {
    }


    public UserAlreadyLoggedInException(string message) : base(message)
    {
    }


    public UserAlreadyLoggedInException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}