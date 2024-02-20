using Library;

namespace Tests.LibraryTests;
public class WordProcessorTest
{
    [Fact]
    public void CountWords()
    {
        //Arrange
        var mock = new Mock<IFileReader>();
        mock.Setup(mock => mock.ReadFile(It.IsAny<string>())).Returns("Hello World");
        var processor = new WordProcessor(mock.Object);
        //Act
        var res = processor.CountWords();
        //Assert
        Assert.Equal(2, res);
    }

    [Fact]
    public void CountCharacters()
    {
        //Arrange
        var mock = new Mock<IFileReader>();
        mock
            .Setup(muck => muck.ReadFile(It.IsAny<string>()))
            .Returns("Hello World");
        var proccess = new WordProcessor(mock.Object);
        //Act
        var res = proccess.CountCharacters();
        //Assert
        Assert.Equal(11, res);



    }
}

