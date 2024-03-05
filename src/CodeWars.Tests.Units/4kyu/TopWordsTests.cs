namespace CodeWars.Tests.Units._4kyu;

[TestFixture]
class TopWordsTests
{
    [TestCase(new string[] { "e", "d", "a" }, "a a a  b  c c  d d d d  e e e e e")]
    [TestCase(new string[] { "e", "ddd", "aa" }, "e e e e DDD ddd DdD: ddd ddd aa aA Aa, bb cc cC e e e")]
    [TestCase(new string[] { "won't", "wont" }, "  //wont won't won't ")]
    [TestCase(new string[] { "e" }, "  , e   .. ")]
    [TestCase(new string[] { }, "  ...  ")]
    [TestCase(new string[] { }, "  '  ")]
    [TestCase(new string[] { }, "  '''  ")]
    [TestCase(new string[] { "a", "of", "on" }, "In a village of La Mancha, the name of which I have no desire to call to\nmind, there lived not long since one of those gentlemen that keep a lance\nin the lance-rack, an old buckler, a lean hack, and a greyhound for\ncoursing. An olla of rather more beef than mutton, a salad on most\nnights, scraps on Saturdays, lentils on Fridays, and a pigeon or so extra\non Sundays, made away with three-quarters of his income.")]
    public void Solution_CountMostUseWordsInString_CountCorrectly(string[] top3Words, string inputString)
    {
        ClassicAssert.AreEqual(top3Words.ToList(), TopWords.Top3(inputString));
    }
}