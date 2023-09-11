namespace Library.Tests;
using TestDateFormat;

public class DateFormatterTests
{
    
    [Test]
    public void TestRight()
    {
        string testingDate = "10/11/1997";
        string expectedDateResult = "1997-11-10";
        string testingDateResult = DateFormatter.ChangeFormat(testingDate);
        Assert.AreEqual(testingDateResult, expectedDateResult);
    }

    [Test]
    public void TestWrong()
    {
        string testingDate = "10/11/pedro";
        string expectedDateResult = "Wrong format entered";
        string testingDateResult = DateFormatter.ChangeFormat(testingDate);
        Assert.AreEqual(testingDateResult, expectedDateResult);
    }

    [Test]
    public void TestBlank()
    {
        string testingDate = "";
        string expectedDateResult = "Empty date entered";
        string testingDateResult = DateFormatter.ChangeFormat(testingDate);
        Assert.AreEqual(testingDateResult, expectedDateResult);
    }
}