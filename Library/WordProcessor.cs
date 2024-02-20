using System.Security.Cryptography.X509Certificates;

namespace Library;
public class WordProcessor(IFileReader fileReader)
{
    string _RootFile = "C:/Users/campo_suarez/Documents/Projects/DotNet/DDD/TestLibrary/TestLibrary/filetest.txt";
    public int CountWords()
    {
        return fileReader.ReadFile(_RootFile).Split(" ").Length;
    }

    public int CountCharacters()
    {
        return fileReader.ReadFile(_RootFile).Length;
    }
}

