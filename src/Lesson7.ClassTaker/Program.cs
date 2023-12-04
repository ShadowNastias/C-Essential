namespace Lesson7.ClassTaker;

class MyClass {
    public string change;
}

struct MyStruct {
    public string change;
}

class Program {
    static void Main(string[] args) {
        MyClass myClass = new MyClass();
        MyStruct myStruct = new MyStruct();

        // Встановлення початкових значень
        myClass.change = "не змінено";
        myStruct.change = "не змінено";

        // Виклик методів
        ClassTaker(myClass);
        StructTaker(myStruct);

        // Виведення результатів
        Console.WriteLine("Клас: " + myClass.change);
        Console.WriteLine("Структура: " + myStruct.change);

        // Аналіз результатів
        Console.WriteLine("\nАналіз:");
        Console.WriteLine("Значення поля класу змінилося, оскільки класи передаються за посиланням.");
        Console.WriteLine("Значення поля структури не змінилося, оскільки структури передаються за значенням.");
    }

    static void ClassTaker(MyClass myClass) {
        myClass.change = "змінено";
    }

    static void StructTaker(MyStruct myStruct) {
        myStruct.change = "змінено";
    }
}