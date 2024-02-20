using Library;

namespace Tests.LibraryTests;
public class HelloWolrdTest
{
    readonly HelloWolrd _helloWolrd;
    public HelloWolrdTest()
    {
        _helloWolrd = new();
    }

    [Fact]
    public void GetHelloWorld()
    {
        //Act
        string res = _helloWolrd.GetHelloWorld();
        //Assert
        Assert.NotNull(res);
        Assert.NotEmpty(res);
        Assert.Contains("Hello W", res);
    }
    [Fact]
    public void GetHelloWorld_EndWith()
    {
        //Act
        string res = _helloWolrd.GetHelloWorld();
        //Assert
        Assert.NotNull(res);
        Assert.NotEmpty(res);
        Assert.EndsWith("World!", res);
    }
    [Fact]
    public void IsAdult()
    {
        //Act
        bool res = _helloWolrd.IsAdult(18);
        //Assert
        Assert.True(res);
    }
    [Fact]
    public void IsAdult_LessOf18()
    {
        //Act
        bool res = _helloWolrd.IsAdult(15);
        //Assert
        Assert.False(res);
    }
    [Fact]
    public void IsAdult_NegativeAge()
    {
        //Act
        bool res = _helloWolrd.IsAdult(-10);
        //Assert
        Assert.False(res);
    }
}
