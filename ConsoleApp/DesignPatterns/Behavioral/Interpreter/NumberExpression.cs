namespace ConsoleApp.DesignPatterns.Behavioral.Interpreter;

public class NumberExpression : IExpression
{
    private readonly int _number;

    public NumberExpression(int number)
    {
        _number = number;
    }

    public NumberExpression(string number)
    {
        _number = int.Parse(number);
    }

    public int Interpret(Context context)
    {
        return _number;
    }
}