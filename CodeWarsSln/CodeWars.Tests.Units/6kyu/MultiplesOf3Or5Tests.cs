namespace CodeWars.Tests.Units._6kyu;

[TestFixture]
public class MultiplesOf3Or5Tests
{
    [TestCase(10, 23)]
    [TestCase(16, 60)]
    public void Solution_SumCaseNumbers_SumCorretly(int inputValue, int outputValue)
    {
        Assert.AreEqual(outputValue, MultiplesOf3Or5.Solution(inputValue));
    }
}