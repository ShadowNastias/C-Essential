namespace Lesson12.Model_View_Presenter;

public interface IView
{
    // Метод для встановлення презентера
    void SetPresenter(Presenter presenter);

    // Методи для відображення даних користувачу
    void DisplayData(string data);
}