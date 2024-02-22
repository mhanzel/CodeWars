namespace CodeWars.Tests.Units._6kyu;

[TestFixture]
public class ArraydiffTests
{
    [TestCase(new int[] { 1, 2 }, new int[] { 1 }, new int[] { 2 })]
    [TestCase(new int[] { 1, 2, 2 }, new int[] { 1 }, new int[] { 2, 2 })]
    [TestCase(new int[] { 1, 2, 2 }, new int[] { 2 }, new int[] { 1 })]
    [TestCase(new int[] { 1, 2, 2 }, new int[] { 1 }, new int[] { 2, 2 })]
    [TestCase(new int[] { 1, 2 }, new int[] { 1, 2 }, new int[] { })]
    [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2 }, new int[] { 3 })]
    public void SampleTest(int[] inputOne, int[] inputTwo, int[] assertOutput)
    {
        //Assert.That(Arraydiff.ArrayDiff(inputOne, inputTwo), Is.EqualTo(assertOutput));
        Assert.AreEqual(assertOutput, Arraydiff.ArrayDiff(inputOne, inputTwo));
    }
    [TestCase(new int[] { 1, 2 }, new int[] { 1 }, new int[] { 2 })]
    [TestCase(new int[] { 1, 2, 2 }, new int[] { 1 }, new int[] { 2, 2 })]
    [TestCase(new int[] { 1, 2, 2 }, new int[] { 2 }, new int[] { 1 })]
    [TestCase(new int[] { 1, 2, 2 }, new int[] { 1 }, new int[] { 2, 2 })]
    [TestCase(new int[] { 1, 2 }, new int[] { 1, 2 }, new int[] { })]
    [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2 }, new int[] { 3 })]
    public void SampleTestBetter(int[] inputOne, int[] inputTwo, int[] assertOutput)
    {
        //Assert.That(Arraydiff.ArrayDiff(inputOne, inputTwo), Is.EqualTo(assertOutput));
        Assert.AreEqual(assertOutput, Arraydiff.ArrayDiffBetter(inputOne, inputTwo));
    }
}
