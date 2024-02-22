namespace CodeWars.Tests.Units._6kyu;

[TestFixture]
public class DuplicateEncoderTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual("(((", DuplicateEncoder.DuplicateEncode("din"));
        Assert.AreEqual("()()()", DuplicateEncoder.DuplicateEncode("recede"));
        Assert.AreEqual(")())())", DuplicateEncoder.DuplicateEncode("Success"), "should ignore case");
        Assert.AreEqual("))((", DuplicateEncoder.DuplicateEncode("(( @"));
    }
}
