int userNumber = 0;
bool isUserNumberInt;
do
{
    Console.WriteLine("Please enter an integer number between 1 to 3");
    isUserNumberInt = int.TryParse(Console.ReadLine(), out userNumber);
}
while (!isUserNumberInt);

switch (userNumber)
{
    case 1:
        Console.WriteLine("You have entered 1");
        break;
    case 2:
        Console.WriteLine("You have entered 2");
        break;
    case 3:
        Console.WriteLine("You have entered 3");
        break;
    default:
        Console.WriteLine("You didn't entered 1 or 2 or 3");
        break;
}

Console.WriteLine();

// Example of joining multiple case statements together

int userNumber2 = 0;
bool isUserNumber2Int;
do
{
    Console.WriteLine("Please enter an integer number between 4 to 6");
    isUserNumber2Int = int.TryParse(Console.ReadLine(), out userNumber2);
} while (!isUserNumber2Int);

switch (userNumber2)
{
    case 4:
    case 5:
    case 6:
        Console.WriteLine("You have entered {0} ", userNumber2);
        break;
    default:
        Console.WriteLine("You didn't entered 4 or 5 or 6");
        break;
}
Console.ReadKey();