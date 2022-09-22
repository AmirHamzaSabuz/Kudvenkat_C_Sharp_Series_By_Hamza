class Program
{
    static void Main()
    {
        int iUserNumber;
        bool isUserNumberInt;
        do
        {
            Console.WriteLine("Please enter an integer number between 1 & 3");
            string? str = Console.ReadLine();
            isUserNumberInt = int.TryParse(str, out iUserNumber);
        } while (isUserNumberInt == false);

        if (iUserNumber == 1)
        {
            Console.WriteLine("You have entered 1");
        }
        else if (iUserNumber == 2)
        {
            Console.WriteLine("You have entered 2");
        }
        else if (iUserNumber == 3)
        {
            Console.WriteLine("You have entered 3");
        }
        else
        {
            Console.WriteLine("Your number is not between 1 and 3");
        }

        Console.WriteLine();

        int i1 = 10;
        int i2 = 20;

        // && check the first condition. if false, doesn't check the second, goes to else. So it is faster.
        if (i1 == 10 && i2 == 20)
        {
            Console.WriteLine("Both conditions are true");
        }
        else
        {
            Console.WriteLine("At least one of the conditions is false");
        }

        // & must check both conditions.
        if (i1 == 10 & i2 == 20)
        {
            Console.WriteLine("Both conditions are true");
        }
        else
        {
            Console.WriteLine("At least one of the conditions is false");
        }

        // || check the first condition. if true, doesn't check the second, enter in the if. So it is faster.
        if (i1 == 10 || i2 == 20)
        {
            Console.WriteLine("At least one of the conditions is true");
        }
        else
        {
            Console.WriteLine("Both conditions are false");
        }

        // | must check both conditions.
        if (i1 == 10 | i2 == 20)
        {
            Console.WriteLine("At least one of the conditions is true");
        }
        else
        {
            Console.WriteLine("Both conditions are false");
        }

        Console.ReadKey();
    }
}