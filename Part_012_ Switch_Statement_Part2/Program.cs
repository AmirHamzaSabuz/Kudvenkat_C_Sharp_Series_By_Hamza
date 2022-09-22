int totalCoffeeCost = 0;
string? userDecision;

do
{
    int userChoice = 0;
    bool isUserChoiceInt;
    do
    {
        do
        {
            Console.WriteLine("Select your coffee size: 1 for Small, 2 for Medium, 3 for Large. Write an integer form 1 to 3");
            isUserChoiceInt = int.TryParse(Console.ReadLine(), out userChoice);
        } while (!isUserChoiceInt);


        switch (userChoice)
        {
            case 1:
                totalCoffeeCost = totalCoffeeCost + 1;
                break;
            case 2:
                totalCoffeeCost = totalCoffeeCost + 2;
                break;
            case 3:
                totalCoffeeCost = totalCoffeeCost + 3;
                break;
            default:
                Console.WriteLine("Your Choice {0} is invalid", userChoice);
                //goto Start
                break;
        }
    } while (userChoice != 1 && userChoice != 2 && userChoice != 3);


    do
    {
        Console.WriteLine("Do you want to buy another coffee - Yes or No?");
        userDecision = Console.ReadLine().ToUpper();

        if (userDecision != "YES" && userDecision != "NO")
        {
            Console.WriteLine("Your choice {0} is invalid. Please try again", userDecision);
        }
    } while (userDecision != "YES" && userDecision != "NO");
} while (userDecision.ToUpper() != "NO");

Console.WriteLine("Thank you for shopping with us");
Console.WriteLine("Bill amount = {0} ", totalCoffeeCost);

Console.ReadKey();