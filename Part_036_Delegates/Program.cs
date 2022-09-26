// Delegate Declaration. 
public delegate void HelloFunctionDelegate(string Message);

internal class Program
{
    private static void Main(string[] args)
    {

        HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
        del("Hello from Delegte");

        Console.ReadKey();
    }

    public static void Hello(string strMessage) 
    {
        Console.WriteLine(strMessage);
    }

}


// A delegate is a type safe function pointer. 

/*
 That is, they hold reference(Pointer) to a function. 


The signature of the delegate must match the signature of the function, the delegate points to, otherwise you get a compiler error. 
This is the reason delegates are called as type safe function pointers.


A Delegate is similar to a class. 
You can create an instance of it, 
and when you do so, you pass in the function name as a parameter to the delegate constructor, 
and it is to this function the delegate will point to.
 */