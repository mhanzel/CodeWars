namespace CodeWars.Tests.Units._6kyu;

[TestFixture]
public class DecomposeANumberTests
{   
    private static void testing(string actual, string expected)
    {
        Assert.AreEqual(expected, actual);
    }
    private static string ArrToStr(long[] arr)
    {
        return "[" + string.Join(", ", from i in arr select i.ToString()) + "]";
    }

    [Test]
    public static void test1()
    {
        long[][] ans = DecomposeANumber.Decompose(0);
        string ansStr = ArrToStr(ans[0]) + ArrToStr(ans[1]);
        testing(ansStr, "[][0]");

        ans = DecomposeANumber.Decompose(4);
        ansStr = ArrToStr(ans[0]) + ArrToStr(ans[1]);
        testing(ansStr, "[2][0]");

        ans = DecomposeANumber.Decompose(9);
        ansStr = ArrToStr(ans[0]) + ArrToStr(ans[1]);
        testing(ansStr, "[3][1]");

        ans = DecomposeANumber.Decompose(25);
        ansStr = ArrToStr(ans[0]) + ArrToStr(ans[1]);
        testing(ansStr, "[4, 2][0]");

        ans = DecomposeANumber.Decompose(8330475);
        ansStr = ArrToStr(ans[0]) + ArrToStr(ans[1]);
        testing(ansStr, "[22, 13, 10, 8, 7, 6, 6, 5, 5, 5, 4, 4, 4, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2][0]");
    }

}
