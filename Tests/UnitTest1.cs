using mobprogramming;
using Xunit;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var list = new List<string> { "1", "2", "Fizz", "4" };
        var fizzBuzz = new Fizzbuzz();
        var actual = fizzBuzz.Run(4);
        Assert.Equal(list, actual);
    }
}