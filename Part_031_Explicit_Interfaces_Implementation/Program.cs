internal class Program : I1, I2, I3, I4, I5, I6
{
    private static void Main(string[] args)
    {
        Program P = new Program();
        P.InterfaceMethod();
        ((I1)P).InterfaceMethod();
        ((I2)P).InterfaceMethod();

        Console.WriteLine();

        /*
        P.InterfaceMethodAnother(); // illegal. Error
        */
        ((I3)P).InterfaceMethodAnother();
        ((I4)P).InterfaceMethodAnother();

        Console.WriteLine();

        I3 i3 = new Program();
        I4 i4 = new Program();

        i3.InterfaceMethodAnother();
        i4.InterfaceMethodAnother();

        Console.WriteLine();



        P.AnotherInterfaceMethod(); // By default 
        ((I6)P).AnotherInterfaceMethod();

        Console.ReadKey();
    }


    public void InterfaceMethod()
    {
        Console.WriteLine("Interface method");
    }

    void I3.InterfaceMethodAnother() // Explicit implementation
    {
        Console.WriteLine("I3 Interface method");
    }

    void I4.InterfaceMethodAnother() // Explicit implementation
    {
        Console.WriteLine("I4 Interface method");
    }


    public void AnotherInterfaceMethod() // By default it is I5.AnotherInterfaceMethod()
    {
        Console.WriteLine("I5 Interface method");
    }

    void I6.AnotherInterfaceMethod() 
    {
        Console.WriteLine("I6 Interface method");
    }
    

}

interface I1 
{
    void InterfaceMethod(); 
}

interface I2
{
    void InterfaceMethod();
}

interface I3
{ 
    void InterfaceMethodAnother(); 
}


interface I4 
{
    void InterfaceMethodAnother();
}

interface I5
{
    void AnotherInterfaceMethod();
}


interface I6
{
    void AnotherInterfaceMethod();
}

