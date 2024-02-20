namespace Library;
public class FileReader:IFileReader
{
    public string ReadFile(string fileRoot)
    {
        StreamReader streamReader = new(fileRoot);
        string infoFile = streamReader.ReadToEnd();
        streamReader.Close();
        return infoFile;
    }

}

public interface IFileReader{
    string ReadFile(string fileRoot);
}


