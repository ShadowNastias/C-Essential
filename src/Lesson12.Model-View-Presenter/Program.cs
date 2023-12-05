namespace Lesson12.Model_View_Presenter;

class Program
{
    static void Main(string[] args)
    {
        // Створення екземплярів Model та View
        var model = new Model();
        var view = new View(); // Переконайтеся, що клас View реалізує IView

        // Створення Presenter та ініціалізація з Model і View
        var presenter = new Presenter(model, view);

        // Демонстрація взаємодії:
        // Можливо, викликати метод UpdateModelData для демонстрації оновлення даних
        presenter.UpdateModelData("Нові дані");
    }
}