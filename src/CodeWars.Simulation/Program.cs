

using CodeWars._4kyu.kyus;

internal class Program
{
    private static void Main(string[] args)
    {
        var inputString = "  '  ";
        var output = TopWords.Top3(inputString);
        Console.WriteLine(output);    
    }
}