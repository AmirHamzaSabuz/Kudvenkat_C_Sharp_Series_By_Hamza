using System.Collections;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] Numbers = new int[3];
        Numbers[0] = 101;
        Numbers[1] = 102;
        Numbers[2] = 103;
        //Numbers[3] = 104; // Error

        foreach (int Number in Numbers)
        { 
            Console.WriteLine(Number);
        }

        // Arrays are strongly typed 
        // in above example 
        // Numbers[2] = "A" // Error

        // Zero index based
        // No add method 
        //Numbers[0] = 101; 

        // Can not grow in size
        //Numbers[3] = 104; // Error

        Console.WriteLine();

        ArrayList arrayList = new ArrayList(3);
        //ArrayList arrayList = new ArrayList();

        arrayList.Add(101); // It has Add method
        arrayList.Add(102);
        arrayList.Add(103);
        arrayList.Add(104); // Can grow in size
        arrayList.Add("A"); // Not strongly typed 

        foreach (var al in arrayList)
        {
            Console.WriteLine(al);
        }

        Console.WriteLine();

        List<int> ints = new List<int>(3);
        //List<int> ints = new List<int>();

        ints.Add(101); // It Has Add method
        ints.Add(102);
        ints.Add(103);
        ints.Add(104); // Can grow in size
        //ints.Add("A"); // Error // List<T> is strongly typed

        foreach (var i in ints)
        {
            Console.WriteLine(i);
        }

        Console.ReadKey();

    }
}