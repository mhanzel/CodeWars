using Newtonsoft.Json.Bson;

namespace CodeWars.Tests.Units._6kyu;
[TestFixture]
public class UniqueInOrderTests
{
    [Test]
    public void EmptyTest()
    {
        Assert.AreEqual("", UniqueInOrder.UniqueInOrderMethod(""));
    }
    [Test]
    public void Test1()
    {
        Assert.AreEqual("ABCDAB", UniqueInOrder.UniqueInOrderMethod("AAAABBBCCDAABBB"));
    }
    public void Test2()
    {
        IEnumerable<int> listOfInt = new List<int>() { 1, 2, 3 };
        IEnumerable<int> listOfIntToCheck = new List<int>() { 1, 2, 2, 3, 3 };
        Assert.AreEqual(listOfInt, UniqueInOrder.UniqueInOrderMethod(listOfIntToCheck));
    }
}
