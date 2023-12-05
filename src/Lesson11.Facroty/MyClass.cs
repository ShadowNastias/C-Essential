namespace Lesson11.Facroty;

public class MyClass
{
    public static T FactoryMethod<T>() where T : new()
    {
        return new T();
    }
}