namespace Lesson12.Model_View_Presenter;

public class Presenter
{
    private readonly Model _model;
    private readonly IView _view;

    // Конструктор, який ініціалізує модель і в'ю
    public Presenter(Model model, IView view)
    {
        _model = model;
        _view = view;
        _view.SetPresenter(this);
    }

    // Метод для обробки запиту на оновлення даних
    public void UpdateModelData(string newData)
    {
        _model.UpdateData(newData);
        UpdateView();
    }

    // Метод для оновлення в'ю новими даними з моделі
    public void UpdateView()
    {
        var data = _model.GetData();
        _view.DisplayData(data);
    }
}