
//ctrl + k + x
// "Insert Snippet
// select Visual C#
// select for
// first editable field is selected automatically. 
// Upon changing the first editable field,
// press TAB to move to the next editable field.
// To come to the previous editable field use SHIFT + TAB. 
// Press ENTER or ESC keys to cancel field editing and return the Code Editor to normal.

for (int j = 101; j <= 110; j++)
{
    Console.WriteLine(j);
}

Console.WriteLine();
Console.WriteLine();


//Surround-with code snippets: These snippets surrounds the selected code, with the code snippets code.
//1.Select the code to surround, and use keyboard shortcut CTRL K + S
//2. Select the code to surround, right click and select "Surround with.." option from the context menu
//3. Select the code to surround, then click on Edit menu, select "IntelliSense" and then select the "Surround With" command.
for (int j = 1; j <= 3; j++)
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine();
    Console.WriteLine();
}

Console.ReadKey();