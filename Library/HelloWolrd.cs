namespace Library;
public class HelloWolrd
{
    public string GetHelloWorld()
    {
        return "Hello World!";
    }

    public bool IsAdult(int age)
    {
        if(age < 18) return false;
        return true;
    }
}
