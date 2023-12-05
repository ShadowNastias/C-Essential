namespace Lesson11.Facroty;

class Program
{
    static void Main()
    {
        var instance = MyClass.FactoryMethod<ExampleClass>();
        Console.WriteLine(instance.GetType().Name);
    }
}

public class ExampleClass
{
}