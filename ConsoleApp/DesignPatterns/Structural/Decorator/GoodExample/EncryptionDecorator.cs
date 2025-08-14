namespace ConsoleApp.DesignPatterns.Structural.Decorator.GoodExample;

public class EncryptionDecorator : DataDecorator
{
    public EncryptionDecorator(Data data) : base(data)
    {
    }

    public override void Save(string data)
    {
        Console.WriteLine("Encryping data");
        var encrypted = Encrypt(data);
        _data.Save(encrypted);
    }

    // This can now be private, encapsulating this code
    private string Encrypt(string data)
    {
        return "$dc&^*()';,,£@%%*(~)`"; // pretend to encrypt data
    }
}