namespace DemoApp;

public class Calculator
{
    public int Add(int a, int b) => a + b;

    public int Subtract(int a, int b) => a - b;

    // Fixed the Division method to properly divide values
    public int Divide(int a, int b)
    {
        return a / b; 
    }
}