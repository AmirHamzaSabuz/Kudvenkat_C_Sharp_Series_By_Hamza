class Program
{
    public static void Main(string[] args)
    {
        //Normal string
        string strNormalString = "Normal String";
        Console.WriteLine(strNormalString);

        Console.WriteLine();

        // Displaying double quotes in c#
        string strDoubleQuotes1 = " \"Double\" \"Quotes\" ";
        Console.WriteLine(strDoubleQuotes1);

        Console.WriteLine();

        string strDoubleQuotes2 = "\"Double\" \"Quotes\"";
        Console.WriteLine(strDoubleQuotes2);

        Console.WriteLine();

        // Displaying new line character in c#
        string strNewLineBreak = "Displaying\nNew\nLine\n";
        Console.WriteLine(strNewLineBreak);

        Console.WriteLine();

        string strWithoutVerbatimLiteral = "C:\\DotNetWorkingSpace_dotnetcore6\\C# Kudvenkat\\Kudvenkat_C_Sharp_Series";
        Console.WriteLine(strWithoutVerbatimLiteral);

        Console.WriteLine();

        string strVerbatimLiteral = @"C:\DotNetWorkingSpace_dotnetcore6\C# Kudvenkat\Kudvenkat_C_Sharp_Series";
        Console.WriteLine(strVerbatimLiteral);

        Console.WriteLine();

        Console.ReadKey();
    }
}