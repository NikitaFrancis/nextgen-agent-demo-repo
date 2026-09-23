namespace DemoApp;

public class Calculator
{
    public int Multiply(int a, int b)
    {
        return a + b; // Bug intencional: suma en lugar de multiplicación
    }

    public int Divide(int a, int b)
    {
        return a / b;
    }
}
