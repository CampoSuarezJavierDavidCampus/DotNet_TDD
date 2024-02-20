namespace Library;
public class Calculator
{
    public int Sum(int num1, int num2)
    {
        return num2 + num1;
    }

    public int Substract(int num1, int num2)
    {
        return num1 - num2;
    }

    public int Multiply(int num1, int num2)
    {
        return (num1 * num2);
    }

    public int Divide(int num1, int num2)
    {
        if (num2 == 0) { return 0; }
        return num1 / num2;
    }

    public int[] Peers()
    {
        List<int> result = new List<int>();
        for (int i = 0; i < 1000; i++)
        {
         if(i%2 == 0)
            {
                result.Add(i);
            }
        }
        return [..result];
    }

}