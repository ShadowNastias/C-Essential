namespace Lesson12.Model_View_Presenter;

public class Model
{
    // Припустимо, що у нас є деякі дані
    public string Data { get; set; }

    // Метод для зміни даних
    public void UpdateData(string newData)
    {
        Data = newData;
        // Тут можна викликати подію або делегата для сповіщення Presenter про зміни
    }

    // Метод для отримання даних
    public string GetData()
    {
        return Data;
    }
}