namespace CodeWars.Tests.Units._6kyu;

[TestFixture]
public class UniqueInOrderTests
{
    [Test]
    public void EmptyTest()
    {
        ClassicAssert.AreEqual("", UniqueInOrder.UniqueInOrderMethod(""));
    }
    [Test]
    public void Test1()
    {
        ClassicAssert.AreEqual("ABCDAB", UniqueInOrder.UniqueInOrderMethod("AAAABBBCCDAABBB"));
    }
    public void Test2()
    {
        IEnumerable<int> listOfInt = new List<int>() { 1, 2, 3 };
        IEnumerable<int> listOfIntToCheck = new List<int>() { 1, 2, 2, 3, 3 };
        ClassicAssert.AreEqual(listOfInt, UniqueInOrder.UniqueInOrderMethod(listOfIntToCheck));
    }
}
