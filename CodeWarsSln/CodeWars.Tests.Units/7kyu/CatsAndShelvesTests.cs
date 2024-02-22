namespace CodeWars.Tests.Units._7kyu;

[TestFixture]
public class CatsAndShelvesTests
{
    private static void testing(int actual, int expected)
    {
        Assert.AreEqual(expected, actual);
    }
    [Test]
    public static void Mew()
    {
        testing(CatsAndShelves.Cats(1, 5), 2);
    }
    [Test]
    public static void OneMoreMew()
    {
        testing(CatsAndShelves.Cats(2, 5), 1);
    }
    [Test]
    public static void MewBetter()
    {
        testing(CatsAndShelves.CatsBetter(1, 5), 2);
    }
    [Test]
    public static void OneMoreMewBetter()
    {
        testing(CatsAndShelves.CatsBetter(2, 5), 1);
    }
}
