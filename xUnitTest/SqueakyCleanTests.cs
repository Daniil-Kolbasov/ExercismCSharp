using ExercismCSharpLib;

namespace xUnitTest;

public class SqueakyCleanTests
{
    [Fact]
    public void ReplaceAnySpaceWithUnderscores()
    {
        Assert.Equal("my___Id", SqueakyClean.Clean("my   Id"));
    }

    [Fact]
    public void ReplaceControlCharactersWihtCTRL()
    {
        Assert.Equal("myCTRLId", SqueakyClean.Clean("my\0Id"));
    }

    [Fact]
    public void ConvertKebabCaseToCamelCase()
    {
        Assert.Equal("àḂç", SqueakyClean.Clean("à-ḃç"));
    }

    [Fact]
    public void OmitCharactersNotLetters()
    {
        Assert.Equal("", SqueakyClean.Clean("1😀2😀3😀"));
    }

    [Fact]
    public void OmitGreekLowerCaseLetters()
    {
        Assert.Equal("MyOFinder", SqueakyClean.Clean("MyOβιεγτFinder"));
    }
}
