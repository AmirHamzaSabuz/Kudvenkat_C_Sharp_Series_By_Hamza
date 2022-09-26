internal class Program
{
    private static void Main(string[] args)
    {
        /*
        D d = new D();
        d.Print();
        */
        Console.WriteLine("Hello, World!");
    }
}

class A
{ 
    public virtual void Print() 
    {
        Console.WriteLine("A Implementation");
    }
}
class B : A
{
    public override void Print()
    {
        Console.WriteLine("B Implementation");
    }
}

class C : A
{
    public override void Print()
    {
        Console.WriteLine("C Implementation");
    }
}

/* // Class can not inherit from multiple base calss.
class D : B, C //illegal. Error.
{ 

}
*/



// class B & class C inherit from class A
// class D inherits from both B & C
// if a method in D calls a method defined in A (and does not override the method)
// and B & C have overriden the method differently
// then from which class does it inherit? B or C ?
// This ambiguity is called as Diamond problem.
