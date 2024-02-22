namespace CodeWars.Tests.Units._6kyu;

[TestFixture]
public class IsANumberPrimeTests
{
    [TestCase(2)]
    [TestCase(5)]
    [TestCase(2999)]
    [TestCase(2147483647)]
    public void IsPrime_WhenCalled_ShouldReturnTrue(int n)
    {
        Assert.AreEqual(IsANumberPrime.IsPrime(n), true);
    }
    [TestCase(0)]
    [TestCase(1)]
    public void IsPrime_WhenCalled_ShouldReturnFalse(int n)
    {
        Assert.AreEqual(IsANumberPrime.IsPrime(n), false);
    }
}
