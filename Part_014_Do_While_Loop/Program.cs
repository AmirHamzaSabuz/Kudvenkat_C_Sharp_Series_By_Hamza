string userChoice = string.Empty;
do
{
    int userTarget = 0;
    bool isUserTargetInt;

    do
    {
        Console.WriteLine("Please enter your target integer number");
        isUserTargetInt = int.TryParse(Console.ReadLine(), out userTarget);
    }
    while (!isUserTargetInt);


    int start = 0;
    while (start <= userTarget)
    {
        Console.Write(start + " ");
        start = start + 2;
    }
    Console.WriteLine();

    do
    {
        Console.WriteLine("Do you want to continue - Yes or No?");
        userChoice = Console.ReadLine().ToUpper();
        if (userChoice != "YES" && userChoice != "NO")
        {
            Console.WriteLine("Invalid choice. Please say Yes or No");
        }
    }
    while (userChoice != "YES" && userChoice != "NO");
} while (userChoice == "YES");
Console.ReadKey();