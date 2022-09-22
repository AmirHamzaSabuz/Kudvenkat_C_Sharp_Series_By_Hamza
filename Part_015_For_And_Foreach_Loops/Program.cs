int[] Numbers = new int[3];

Numbers[0] = 101;
Numbers[1] = 102;
Numbers[2] = 103;

Console.WriteLine("while loop");
int i = 0;
while (i < Numbers.Length)
{
    Console.WriteLine(Numbers[i]);
    i++;
}

Console.WriteLine();
Console.WriteLine("while loop, using Numbers[j++]");
int j = 0;
while (j < Numbers.Length)
{
    Console.WriteLine(Numbers[j++]);

}

Console.WriteLine();

Console.WriteLine("for loop");
for (int k = 0; k < Numbers.Length; k++)
{
    Console.WriteLine(Numbers[k]);
}

Console.WriteLine();

Console.WriteLine("foreach");

foreach (int Number in Numbers)
{
    Console.WriteLine(Number);
}

Console.WriteLine();

Console.WriteLine("For loop with break");
for (int a = 0; a <= 20; a++)
{
    Console.WriteLine(a);
    if (a == 10)
        break;
}

Console.WriteLine();

Console.WriteLine("For loop. Even Numbers from 0 to 20");
for (int c = 0; c <= 20; c += 2) // c+=2 means c = c + 2
{
    Console.WriteLine(c);
}

Console.WriteLine();

Console.WriteLine("For loop with continue. Even Numbers from 0 to 20");
for (int b = 0; b <= 20; b++)
{
    if (b % 2 == 1)
        continue;
    Console.WriteLine(b);
}

Console.ReadLine();
