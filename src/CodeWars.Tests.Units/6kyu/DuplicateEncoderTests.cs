namespace CodeWars.Tests.Units._6kyu;

[TestFixture]
public class DuplicateEncoderTests
{
    [Test]
    public void BasicTests()
    {
        ClassicAssert.AreEqual("(((", DuplicateEncoder.DuplicateEncode("din"));
        ClassicAssert.AreEqual("()()()", DuplicateEncoder.DuplicateEncode("recede"));
        ClassicAssert.AreEqual(")())())", DuplicateEncoder.DuplicateEncode("Success"), "should ignore case");
        ClassicAssert.AreEqual("))((", DuplicateEncoder.DuplicateEncode("(( @"));
    }
}
