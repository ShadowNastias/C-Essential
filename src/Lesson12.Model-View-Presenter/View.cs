namespace Lesson12.Model_View_Presenter;

public class View : IView
{
    private Presenter _presenter;

    public void SetPresenter(Presenter presenter)
    {
        _presenter = presenter;
    }

    public void DisplayData(string data)
    {
        Console.WriteLine("Відображення даних у View: " + data);
    }
}