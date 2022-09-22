class Program
{
    static void Main(string[] args)
    {
        /*
         * In C# types  are divided into 2 broad categories.
         * Value Types  - int, float, double, structs, enums etc
         * Reference Types – Interface, Class, delegates, arrays etc
         * By default value types are non nullable. To make them nullable use ?
         */

        //Example of nullable type
        bool? areYouMajor = null;

        if (areYouMajor == true)
        {
            Console.WriteLine("You are major");
        }

        else if (areYouMajor == false)
        {
            Console.WriteLine("You are not major");
        }

        Console.WriteLine("You didn't answer");

        Console.WriteLine();

        int? TicketsOnSale = null;
        int AvailaleTickets;

        if (TicketsOnSale == null)
        {
            AvailaleTickets = 0;
        }
        else
        {
            AvailaleTickets = TicketsOnSale.Value;
            //AvailaleTickets = (int)TicketsOnSale;
            //AvailaleTickets = (int)TicketsOnSale.Value;
        }
        Console.WriteLine("AvailaleTickets : " + AvailaleTickets);

        Console.WriteLine();

        //NULL coalescing operator
        // ??
        AvailaleTickets = TicketsOnSale ?? 0;

        Console.WriteLine("AvailaleTickets : " + AvailaleTickets);

        Console.ReadLine();

    }
}