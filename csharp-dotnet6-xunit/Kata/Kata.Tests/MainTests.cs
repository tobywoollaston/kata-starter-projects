using FluentAssertions;
using Xunit;

namespace Kata.Tests;

public class MainTests
{
    [Fact]
    public void Main_ShouldReturn_True()
    {
        var result = new Main().Run();

        result.Should().Be(true);
    }
}