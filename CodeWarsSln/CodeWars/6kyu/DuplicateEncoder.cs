namespace CodeWars._6kyu;

public class DuplicateEncoder
{
    public static string DuplicateEncode(string word)
    {
        word = word.ToLower();
        var listOfCharsToCheck = word.ToCharArray().ToList();
        var listOfCharsToUse = word.ToCharArray().ToList();
        var listOfDuplicateChars = new List<int>();
        var stringOut = string.Empty;

        listOfCharsToCheck.ForEach(x =>
        {
            listOfDuplicateChars.Add(listOfCharsToUse.Count(y => x == y));
        });
        listOfDuplicateChars.ForEach(x =>
        {
            if (x == 1) stringOut += "(";
            else stringOut += ")";
        });
        return stringOut;
    }
    public static string DuplicateEncodeBest(string word)
    {
        return new string(word.ToLower().Select(ch => word.ToLower().Count(innerCh => ch == innerCh) == 1 ? '(' : ')').ToArray());
    }
}
/*
 * 
The goal of this exercise is to convert a string to a new string where each character in the new string is "(" if that character appears only once in the original string, or ")" if that character appears more than once in the original string. Ignore capitalization when determining if a character is a duplicate.

Examples
"din"      =>  "((("
"recede"   =>  "()()()"
"Success"  =>  ")())())"
"(( @"     =>  "))((" 
 * 
 * 
 */
