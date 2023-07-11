using NUnit.Framework;

namespace Kata.Tests;

public class MainTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Main_ShouldReturn_True()
    {
        var result = new Main().Run();
        
        Assert.True(result);
    }
}