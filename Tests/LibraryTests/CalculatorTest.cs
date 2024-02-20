using Library;
namespace Tests.LibraryTests;
public class CalculatorTest
{
    readonly Calculator _calculator;
    public CalculatorTest()
    {
        _calculator = new();
    }
    [Fact]
    public void Sum()
    {
        //Act
        int res = _calculator.Sum(4, 3);
        //Assert
        Assert.Equal(7, res);
    }

    [Fact]
    public void Substract()
    {
        //Act
        int res = _calculator.Substract(4, 3);
        //Assert
        Assert.Equal(1, res);
    }

    [Fact]
    public void Multiply()
    {
        //Act
        int res = _calculator.Multiply(4, 3);
        //Assert
        Assert.Equal(12, res);
    }

    [Fact]
    public void Divide()
    {
        //Act
        int res = _calculator.Divide(4, 2);
        //Assert
        Assert.Equal(2, res);
    }

    [Fact]
    public void Divide_by0()
    {
        //Act
        int res = _calculator.Divide(4, 0);
        //Assert
        Assert.Equal(0, res);
    }

    [Theory]
    [ClassData(typeof(TestPeersClassData))]
    public void Peers(int evenNumber)
    {
        //Act
        int[] res = _calculator.Peers();
        //Assert
        Assert.Contains(evenNumber, res);
    }

    [Theory]
    [InlineData(235)]
    [InlineData(255)]
    [InlineData(683)]
    [InlineData(865)]
    [InlineData(975)]
    public void Peers_notPeers(int oddNumber)
    {
        //Act
        int[] res = _calculator.Peers();
        //Assert
        Assert.DoesNotContain(oddNumber, res);
    }
}

