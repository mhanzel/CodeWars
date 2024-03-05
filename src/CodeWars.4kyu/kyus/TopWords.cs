using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars._4kyu.kyus
{
    /*
     * TODO
     * FIX, maybe change all func.
     */
    public class TopWords
    {
        public static List<string> Top3(string wordsToCheck)
        {
            var Top3Words = new List<TopWordsKey>();

            wordsToCheck = wordsToCheck.ToLower().Replace("\n", "");

            string[] replaceables = new[] { "+", "&&", "||", "!", "(", ")", "-", "{", "}", "[", "]", "^", "~", "*", "?", ":", ".", ",", $"//", $@"\\" };
            string rxString = string.Join("|", replaceables.Select(s => Regex.Escape(s)));
            string clearWorks = Regex.Replace(wordsToCheck, rxString, string.Empty);

            var tempSplitedWords = clearWorks.Split(' ');
            var splitedWords = new List<string>();

            foreach (var word in tempSplitedWords)
            {
                if (string.IsNullOrEmpty(word))
                    continue;
                else if (Regex.Matches(word, @"[a-zA-Z]").Count == 0)
                    continue;
                else
                    splitedWords.Add(word);
            }

            foreach (var word in splitedWords)
            {
                if (Top3Words.Select(x => x.Word).Contains(word))
                    Top3Words.FirstOrDefault(x => x.Word == word).Counter += 1;
                else
                    Top3Words.Add(new TopWordsKey(word));
            }

            var sss = Top3Words.OrderByDescending(x => x.Counter).Select(x => x.Word).Take(3).ToList();

            return Top3Words.OrderByDescending(x => x.Counter).Select(x => x.Word).Take(3).ToList();
        }
    }

    public class TopWordsKey
    {
        public string Word { get; set; }
        public int Counter { get; set; }

        public TopWordsKey(string word)
        {
            Word = word;
            Counter = 1;
        }

        public TopWordsKey()
        {
        }
    }
}
