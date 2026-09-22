namespace DemoApp;

public class Calculator
{
    public int Add(int a, int b) => a + b;

    public int Subtract(int a, int b) => a - b;

    // BUG INTENCIONAL PARA LA DEMO:
    // La función de división debería usar '/', pero tiene '*'
    public int Divide(int a, int b)
    {
        return a * b; 
    }
}
