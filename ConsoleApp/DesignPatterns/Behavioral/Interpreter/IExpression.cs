namespace ConsoleApp.DesignPatterns.Behavioral.Interpreter;

public interface IExpression
{
    int Interpret(Context context);
}